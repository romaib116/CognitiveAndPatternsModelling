using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using CognitiveMaps.FCM.Models;
using CognitiveMaps.Helpers;
using QuickGraph;

namespace CognitiveMaps.FCM.BL
{
    /// <summary>
    /// Логика типовой НКК (не серой)
    /// </summary>
    public class MapBL
    {
        public string ReportFileName
        {
            get
            {
                return "ReportFCMGraph";
            }
        }

        public string ReportFilePath
        {
            get
            {
                return string.Format(@"C:\temp\{0}.jpg", ReportFileName);
            }
        }

        #region Вспомогательные методы
        /// <summary>
        /// При необходимости расширения матрицы
        /// </summary>
        /// <param name="newSize"> Новый размер </param>
        /// <returns></returns>
        private double[,] ResizeArray(Map map, int newSize)
        {
            double[,] newArray = new double[newSize, newSize];
            for (int i = 0; i < Math.Sqrt(map.WeightMatrix.Length); i++)
            {
                for (int j = 0; j < Math.Sqrt(map.WeightMatrix.Length); j++)
                {
                    newArray[i, j] = map.WeightMatrix[i, j];
                }
            }
            return newArray;
        }

        /// <summary>
        /// Проверка на существование переданной вершины
        /// </summary>
        /// <param name="conceptId"> Вершина </param>
        /// <returns></returns>
        private bool IsExistVertex(Map map, string conceptId)
        {
            return map.Concepts.Where(v => v.Id == conceptId).Any();
        }

        /// <summary>
        /// Получаем индекс в матрице весов по ИДу концепта
        /// </summary>
        /// <param name="conceptId"></param>
        /// <returns></returns>
        private int GetIndexByConceptId (string conceptId)
        {
            int result;
            int.TryParse(string.Join("", conceptId.Where(c => char.IsDigit(c))), out result);
            return result;
        }

        /// <summary>
        /// Функция активации (сигмоида)
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        protected double Sigmoid(double x)
        {
            return 1 / (1 + Math.Exp(-x));
        }

        /// <summary>
        /// Метод умножения значений векторов на матрицу весов
        /// </summary>
        /// <param name="weightsMatrix"></param>
        /// <param name="conceptsVector"></param>
        /// <returns></returns>
        protected List<Concept> MultiplyMatrixByVector(double[,] weightsMatrix, List<Concept> conceptsVector)
        {
            var result = new List<Concept>();

            var sizeMatrix = Math.Sqrt(weightsMatrix.Length);
            for (int row = 0; row < sizeMatrix; row++)
            {
                double newValue = 0.0;
                for (int col = 0; col < sizeMatrix; col++)
                {
                    newValue += weightsMatrix[col, row] * conceptsVector[col].Value;
                }
                result.Add(new Concept { 
                    Id = conceptsVector[row].Id,
                    IsDriver = conceptsVector[row].IsDriver,
                    IsTarget = conceptsVector[row].IsTarget,
                    Value = newValue,
                    TargetValue = conceptsVector[row].TargetValue,
                    Name = conceptsVector[row].Name
                });
            }

            return result;
        }
        #endregion

        /// <summary>
        /// Создать карту
        /// </summary>
        /// <returns></returns>
        public Map CreateFcm()
        {
            return new Map();
        }

        public AdjacencyGraph<string, Edge<string>> CreateFcmGraph(Map map)
        {
            var result = new AdjacencyGraph<string, Edge<string>>();

            foreach (var concept in map.Concepts)
            {
                result.AddVertex(concept.Id);
            }

            for (int i = 0; i < Math.Sqrt(map.WeightMatrix.Length); i++)
            {
                for (int j = 0; j < Math.Sqrt(map.WeightMatrix.Length); j++)
                {
                    if (map.WeightMatrix[i, j] != 0)
                        result.AddEdge(new Edge<string>(map.Concepts[i].Id, map.Concepts[j].Id));
                }
            }
            Visualizer.Visualize(result, ReportFileName);
            System.Threading.Thread.Sleep(500);

            return result;
        }


        /// <summary>
        /// Добавить вершину
        /// </summary>
        /// <param name="name"> Название </param>
        /// <param name="value"> Описание </param>
        public void AddConcept(Map map, string name, double value)
        {
            //Пополняем список вершин
            map.Concepts.Add(new Concept
            {
                Id = "C" + map.Concepts.Count,
                Name = name,
                Value = value
            });
            map.WeightMatrix = ResizeArray(map, map.Concepts.Count);
        }

        /// <summary>
        /// Добавить вес между вершинами
        /// </summary>
        /// <param name="map"> НКК </param>
        /// <param name="firstVertexID"> 1 вершина </param>
        /// <param name="secondVertexID"> 2 вершина </param>
        /// <param name="weight"> Вес </param>
        public void AddWeight(Map map, string firstConceptId, string secondConceptId, double weight)
        {
            //Если оба концепта существуют и указан корректный вес
            if (IsExistVertex(map, firstConceptId) && IsExistVertex(map, secondConceptId) &&
                weight > -1 && weight < 1)
            {
                //Если текущее количество вершин больше матрицы весов
                if (map.Concepts.Count > Math.Sqrt(map.WeightMatrix.Length))
                {
                    //Расширяем
                    map.WeightMatrix = ResizeArray(map, map.Concepts.Count);
                }
                //Присваиваем вес
                map.WeightMatrix[GetIndexByConceptId(firstConceptId), GetIndexByConceptId(secondConceptId)] = weight;
            }
        }


        /// <summary>
        /// Сделать концепт драйвером (его значение будет неизменно в процессе обучения НКК)
        /// </summary>
        /// <param name="map"></param>
        /// <param name="isDriver"></param>
        /// <param name="conceptId"></param>
        public void MakeDriver(Map map, bool isDriver, string conceptId)
        {
            map.Concepts.Where(x => x.Id == conceptId).First().IsDriver = isDriver;
        }


        /// <summary>
        /// Сделать концепт целевым 
        /// (целевым считается концепт, для которого необходимо оптимизировать матрицу весов текущей карты
        /// так, чтобы веса стали оптимальными)
        /// </summary>
        /// <param name="map"> НКК </param>
        /// <param name="conceptId"> ИД концепта НКК </param>
        /// <param name="isTarget"> сделать целевым? (да или нет) </param>
        /// <param name="targetValue"> значение целевого концепта (по умолчанию null) </param>
        public void MakeTarget(Map map, string conceptId, bool isTarget, double? targetValue = null)
        {
            if (isTarget)
            {
                map.Concepts.Where(x => x.Id == conceptId).First().IsTarget = true;
                map.Concepts.Where(x => x.Id == conceptId).First().TargetValue = targetValue;
            }
            else
            {
                map.Concepts.Where(x => x.Id == conceptId).First().IsTarget = false;
            }
        }

        /// <summary>
        /// Изменить численное значение для выбранного концепта
        /// </summary>
        /// <param name="map"> НКК </param>
        /// <param name="conceptId"> ИД концепта НКК </param>
        /// <param name="newValue"> значение установленное пользователем </param>
        public void ChangeConceptValue(Map map, string conceptId, double newValue)
        {
            map.Concepts.Where(x => x.Id == conceptId).First().Value = newValue;
        }

        public DataTable GetConceptNamesDataTable(Map map)
        {
            var result = new DataTable("ConceptNames");
            DataColumn column;
            DataRow row;

            //1
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Id";
            column.ReadOnly = true;
            column.AutoIncrement = false;
            column.Unique = false;
            result.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.Double");
            column.ColumnName = "Значение";
            column.AutoIncrement = false;
            column.ReadOnly = false;
            column.Unique = false;
            result.Columns.Add(column);

            //2
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Целевое_значение";
            column.AutoIncrement = false;
            column.ReadOnly = false;
            column.Unique = false;
            result.Columns.Add(column);

            //3
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Драйвер?";
            column.AutoIncrement = false;
            column.ReadOnly = false;
            column.Unique = false;
            result.Columns.Add(column);

            //4
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Название";
            column.AutoIncrement = false;
            column.ReadOnly = false;
            column.Unique = false;
            result.Columns.Add(column);





            foreach (var concept in map.Concepts)
            {
                try
                {
                    row = result.NewRow();
                    row["Id"] = concept.Id;
                    row["Значение"] = concept.Value;
                    row["Целевое_значение"] = concept.TargetValue != null ? concept.TargetValue.ToString() : "";
                    row["Драйвер?"] = concept.IsDriver ? "Да" : "";
                    row["Название"] = concept.Name;
                    result.Rows.Add(row);
                }
                catch { };
            }
            return result;
        }
    }
}
