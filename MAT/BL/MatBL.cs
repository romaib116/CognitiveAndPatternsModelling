using CognitiveMaps.MAT.Interfaces;
using QuickGraph;
using QuickGraph.Graphviz;
using CognitiveMaps.Helpers;
using System.IO;
using CognitiveMaps.MAT.Models;
using Newtonsoft.Json;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CognitiveMaps.MAT.BL
{

    /// <summary>
    /// Логика работы с уязвимостями выбранными пользователем
    /// </summary>
    public class MatBL
    {
        public DataTable GetUserDataTable(List<CommonVulnerability> vulnList)
        {
            var result = new DataTable("UserVulns");
            DataColumn column;
            DataRow row;

            //1
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Идентификатор";
            column.ReadOnly = true;
            column.AutoIncrement = false;
            column.Unique = true;
            result.Columns.Add(column);

            //5
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "CWE";
            column.AutoIncrement = false;
            column.ReadOnly = false;
            column.Unique = false;
            result.Columns.Add(column);

            foreach (var vuln in vulnList)
            {
                try
                {
                    row = result.NewRow();
                    row["Идентификатор"] = vuln.Id;
                    row["CWE"] = String.Join(", ", vuln.Cwe);
                    result.Rows.Add(row);
                }
                catch
                {
                    throw new DuplicateNameException("Нельзя создавать дубликаты");
                }
            }
            return result;
        }

        public DataTable GetCweCapecDataTable(List<ProcessedCweCapec> cweCapecsList)
        {
            var result = new DataTable("CweCapec");
            DataColumn column;
            DataRow row;

            //1
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Cwe";
            column.ReadOnly = true;
            column.Unique = false;
            column.AutoIncrement = false;
            result.Columns.Add(column);

            //2
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Capec";
            column.AutoIncrement = false;
            column.ReadOnly = false;
            column.Unique = false;
            result.Columns.Add(column);

            foreach (var cweCapec in cweCapecsList)
            {
                row = result.NewRow();
                row["CWE"] = cweCapec.Cwe;
                row["Capec"] = String.Join(", ", cweCapec.CapecList.Select(i => i.Id));
                result.Rows.Add(row);
            }
            return result;
        }


        /// <summary>
        /// Получаем связи между пользовательскими CWE и Capec
        /// </summary>
        /// <param name="userList"> Пользовательски список уязвимостей </param>
        /// <param name="capecList"> Лист Capec </param>
        /// <returns></returns>
        public List<ProcessedCweCapec> GetProcessedCweCapecs(List<CommonVulnerability> userList, List<CapecEntity> capecList)
        {
            var result = new List<ProcessedCweCapec>();
            //Проверка на передачу пустых списков (мало ли)
            if (userList != null && capecList != null)
            {
                //Перебираем по каждой пользовательской уязвимости
                foreach (var vuln in userList)
                {
                    //Заходим в каждый CWE, для того чтобы от него построить связь до Capec'ов
                    foreach (var currentCwe in vuln.Cwe)
                    {
                        //Проверка на существование текущего Cwe
                        //А также если в нашем результирующем списке еще нет текущего cwe
                        if (!string.IsNullOrWhiteSpace(currentCwe) && !currentCwe.Equals("NVD-CWE-Other") &&
                            !result.Select(i => i.Cwe).Contains(currentCwe))
                        {
                            //Находим связь
                            var capecs = FindRelationsCweCapec(currentCwe, capecList);
                            //Если она есть
                            if (capecs.Count != 0)
                            {
                                result.Add(new ProcessedCweCapec
                                {
                                    Cwe = currentCwe,
                                    CapecList = capecs
                                });
                            }
                        }
                    }
                }
            }
            return result;
        }


        /// <summary>
        /// Найти связь между текущим CWE и выходящими из него Capec
        /// </summary>
        /// <param name="currentCwe"> CWE </param>
        /// <param name="capecList"> Лист Capec, по которому ищем </param>
        /// <returns></returns>
        private List<CapecEntity> FindRelationsCweCapec(string currentCwe, List<CapecEntity> capecList)
        {
            var result = new List<CapecEntity>();
            foreach (var capec in capecList)
            {
                if (capec.Cwe.Contains(currentCwe))
                {
                    result.Add(capec);
                }
            }
            return result;
        }


        /// <summary>
        /// Обработать Capec и получить только те, у которых есть TaxonomyMappings
        /// </summary>
        /// <param name="capecList"></param>
        /// <returns></returns>
        public List<CapecEntity> GetProcessedCapecTaxonomies(List<ProcessedCweCapec> cweCapecs)
        {
            var result = new List<CapecEntity>();
            foreach (var capec in cweCapecs.SelectMany(i => i.CapecList))
            {
                if (!result.Select(i => i.Id).Contains(capec.Id))
                {
                    //Если у Capec есть привязанные исходящие от него сущности
                    if (capec.TaxonomyMappings != null && capec.TaxonomyMappings.Count != 0)
                    {
                        result.Add(capec);
                    }
                }
            }
            return result;
        }


        public DataTable GetCapecTaxonomiesDataTable(List<CapecEntity> capecList)
        {
            var result = new DataTable("CapecTaxonomies");
            DataColumn column;
            DataRow row;

            //1
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "CapecId";
            column.ReadOnly = true;
            column.Unique = false;
            column.AutoIncrement = false;
            result.Columns.Add(column);

            //2
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Taxonomies";
            column.AutoIncrement = false;
            column.ReadOnly = false;
            column.Unique = false;
            result.Columns.Add(column);

            foreach (var capec in capecList)
            {
                row = result.NewRow();
                row["CapecId"] = capec.Id;
                row["Taxonomies"] = GetTaxonomies(capec);
                result.Rows.Add(row);
            }
            return result;
        }

        private string GetTaxonomies(CapecEntity capec)
        {
            string result = string.Empty;
            foreach (var tax in capec.TaxonomyMappings)
            {
                result += tax.Name + " Id " + tax.EntryId+", ";
            }
            if (result[result.Length - 2] == ',' && result[result.Length-1] == ' ')
                result = result.Remove(result.Length - 2);
            return result;
        }

        
        public void CreateGraph(List<CommonVulnerability> userList, List<ProcessedCweCapec> processedCweCapecs, List<CapecEntity> capecTaxList = null)
        {
            AdjacencyGraph<string, Edge<string>> graph = new AdjacencyGraph<string, Edge<string>>(true);
            //Создаем вершины Bdu, Cve
            CreateVetrices(graph, userList.Select(i => i.Id).ToList());
            //Создаем CWE
            foreach (var cwe in userList.Select(i => i.Cwe))
                CreateVetrices(graph, cwe);
            //Создаем Capec только те, у которых есть связи с CWE
            foreach (var capec in processedCweCapecs.Select(i => i.CapecList))
                CreateVetrices(graph, capec.Select(i => i.Id).ToList());
            //Создаем связи от Capec
            if (capecTaxList != null)
                foreach (var tax in capecTaxList.Select(i => i.TaxonomyMappings))
                    CreateVetrices(graph, tax.Select(i => i.Name +" Id " + i.EntryId).ToList());


            //Начинаем соединять вершины
            //CVE/BDU - CWE
            foreach (var cveBduCwe in userList)
                CreateEdges(graph, cveBduCwe.Id, cveBduCwe.Cwe);
            //Cwe - Capec
            foreach (var cweCapecs in processedCweCapecs)
                CreateEdges(graph, cweCapecs.Cwe, cweCapecs.CapecList.Select(i => i.Id).ToList());
            if (capecTaxList != null)
                //Capec - другие систремы
                foreach (var capecTax in capecTaxList)
                    CreateEdges(graph, capecTax.Id, capecTax.TaxonomyMappings.Select(i => i.Name + " Id " + i.EntryId).ToList());



            Visualizer.Visualize(graph, "somefile");
            //pictureBox1.ImageLocation = @"c:\temp\somefile.jpg";
        }
        

        /// <summary>
        /// Создать вершины графа
        /// </summary>
        /// <param name="graph"></param>
        /// <param name="vertices"></param>
        private void CreateVetrices (AdjacencyGraph<string, Edge<string>> graph, List<string> vertices)
        {
            foreach (var vertex in vertices)
            {
                if (!graph.Vertices.Contains(vertex))
                    graph.AddVertex(vertex);
            }
        }

        /// <summary>
        /// Соединение вершин
        /// </summary>
        /// <param name="graph"> граф </param>
        /// <param name="verticesFrom"> ИЗ каких вершин соединение </param>
        /// <param name="verticesTo"> В какие вершины соединяем </param>
        private void CreateEdges(AdjacencyGraph<string, Edge<string>> graph, string vertexFrom, List<string> verticesTo)
        {
            foreach (var vertexTo in verticesTo)
            {
                graph.AddEdge(new Edge<string>(vertexFrom, vertexTo));
            }
        }
    }
}
