using CognitiveMaps.Helpers;
using CognitiveMaps.MAT.Models;
using QuickGraph;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;

namespace CognitiveMaps.MAT.BL
{

    /// <summary>
    /// Логика работы с уязвимостями выбранными пользователем
    /// </summary>
    public class MatBL
    {
        public string ReportFileName 
        {
            get
            {
                return "ReportGraph";
            }
        }

        public string ReportFilePath
        {
            get
            {
                return string.Format(@"C:\temp\{0}.jpg", ReportFileName);
            }
        }

        public DataTable GetVulnsDataTable(List<CommonVulnerability> vulnList)
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
            column.Unique = false;
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
                catch { };
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
            column.ColumnName = "CAPEC";
            column.AutoIncrement = false;
            column.ReadOnly = false;
            column.Unique = false;
            result.Columns.Add(column);

            foreach (var cweCapec in cweCapecsList)
            {
                row = result.NewRow();
                row["CWE"] = cweCapec.Cwe;
                row["CAPEC"] = String.Join(", ", cweCapec.CapecList.Select(i => i.Id));
                result.Rows.Add(row);
            }
            return result;
        }


        /// <summary>
        /// Получаем связи между пользовательскими CWE и CAPEC
        /// </summary>
        /// <param name="userList"> Пользовательски список уязвимостей </param>
        /// <param name="capecList"> Лист CAPEC </param>
        /// <returns></returns>
        public List<ProcessedCweCapec> GetProcessedCweCapecs(List<CommonVulnerability> vulnList, List<CapecEntity> capecList)
        {
            var result = new List<ProcessedCweCapec>();
            //Проверка на передачу пустых списков (мало ли)
            if (vulnList != null && capecList != null)
            {
                //Перебираем по каждой пользовательской уязвимости
                foreach (var vuln in vulnList)
                {
                    //Заходим в каждый CWE, для того чтобы от него построить связь до Capec'ов
                    foreach (var currentCwe in vuln.Cwe)
                    {
                        //Проверка на существование текущего Cwe
                        //А также если в нашем результирующем списке еще нет текущего cwe
                        if (!string.IsNullOrWhiteSpace(currentCwe) && !currentCwe.Contains("NVD") &&
                            !result.Select(i => i.Cwe).Contains(currentCwe))
                        {
                            //Находим связи от CWE к CAPEC
                            var capecs = FindRelationsCweCapec(currentCwe, capecList);
                            //Если она есть
                            if (capecs.Count != 0)
                            {
                                ///* Начинаем отсеивать слабосвязанные CAPEC
                                // * Слабые - имеющие одну связь и то дочернюю
                                // * (иначе список связей от текущего CWE может быть велик)
                                // */
                                //var oldCapecs = new List<CapecEntity>(capecs);
                                //foreach (var capec in oldCapecs)
                                //{
                                //    if (capec.RelatedAttackPatterns != null && capec.RelatedAttackPatterns.Count != 0)
                                //        if (capec.RelatedAttackPatterns.Count == 1 && capec.RelatedAttackPatterns.Any(x => x.Nature.Contains("ChildOf")))
                                //            capecs.Remove(capec);
                                //}
                                //Если после проведенных процедур ещё остались CAPEC
                                if (capecs.Count != 0)
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
                        result.Add(capec);
                }
            }
            //OWASP не имеет ИДов, избавляемся от них
            if (result.Count != 0)
            {
                var oldResult = new List<CapecEntity>(result);
                foreach (var capec in oldResult)
                {
                    var oldTax = new List<Models.Capec.TaxonomyMapping>(capec.TaxonomyMappings);
                    foreach (var tax in oldTax)
                    {
                        if (tax.Name.Contains("OWASP"))
                            capec.TaxonomyMappings.Remove(tax);
                    }
                    if (capec.TaxonomyMappings.Count == 0)
                        result.Remove(capec);
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
                result +=tax.Name + " Id " + tax.EntryId + ", ";
            }
            if (result.Length != 0)
                if (result[result.Length - 2] == ',' && result[result.Length-1] == ' ')
                    result = result.Remove(result.Length - 2);
            return result;
        }

        /// <summary>
        /// Метод обновления (создания) графа
        /// </summary>
        /// <param name="graph"></param>
        /// <param name="userList"></param>
        /// <param name="processedCweCapecs"></param>
        /// <param name="capecTaxList"></param>
        /// <returns></returns>
        public AdjacencyGraph<string, Edge<string>> RefreshGraph(AdjacencyGraph<string, Edge<string>> graph, List<CommonVulnerability> userList, List<ProcessedCweCapec> processedCweCapecs, List<CapecEntity> capecTaxList = null)
        {
            //Если передается пустой граф, то создаем его по обработанным спискам
            if (graph == null)
                graph = CreateGraph(userList, processedCweCapecs, capecTaxList);
            Visualizer.Visualize(graph, ReportFileName);
            System.Threading.Thread.Sleep(500);
            return graph;
        }


        /// <summary>
        /// Создать граф (если в родительский метод передан пустой граф)
        /// </summary>
        /// <param name="userList"></param>
        /// <param name="processedCweCapecs"></param>
        /// <param name="capecTaxList"></param>
        /// <returns> Возвращает граф </returns>
        private AdjacencyGraph<string , Edge<string>> CreateGraph(List<CommonVulnerability> userList, List<ProcessedCweCapec> processedCweCapecs, List<CapecEntity> capecTaxList = null)
        {
            AdjacencyGraph<string, Edge<string>> graph = new AdjacencyGraph<string, Edge<string>>(true);

            //Создаем вершины Bdu, Cve
            CreateVetrices(graph, userList.Select(i => i.Id).ToList());

            //Создаем CWE
            foreach (var cwe in userList.Select(i => i.Cwe))
                CreateVetrices(graph, cwe);

            //Создаем Capec только те, у которых есть связи с CWE
            foreach (var capecs in processedCweCapecs.Select(i => i.CapecList))
                foreach (var capec in capecs)
                    CreateVetrices(graph, new List<string>() { capec.Id });

            //Создаем связи от Capec
            if (capecTaxList != null)
                foreach (var capec in capecTaxList)
                    foreach (var tax in capec.TaxonomyMappings)
                        CreateVetrices(graph, new List<string>() { string.Format(tax.Name + " Id " + tax.EntryId) });


            //Начинаем соединять вершины


            //CVE/BDU - CWE

            foreach (var cveBduCwe in userList)
                CreateEdges(graph, cveBduCwe.Id, cveBduCwe.Cwe);

            //CWE - CAPEC
            foreach (var cweCapecs in processedCweCapecs)
                foreach (var capec in cweCapecs.CapecList)
                    CreateEdges(graph, cweCapecs.Cwe, new List<string>() { capec.Id});

            //CAPEC - Others
            if (capecTaxList != null)
                foreach (var capec in capecTaxList)
                    CreateEdges(graph, capec.Id, capec.TaxonomyMappings.Select(i => i.Name + " Id " + i.EntryId).ToList());

            //Чистка неиспользуемых вершин CVE/BDU
            foreach (var vertexOut in graph.Vertices.Where(x => x.Contains("CVE") || x.Contains("BDU")))
            {
                var haveEdge = false;
                foreach (var vertexIn in graph.Vertices)
                {
                    if (graph.ContainsEdge(vertexOut, vertexIn))
                    {
                        haveEdge = true;
                        break;
                    }    
                }
                if (!haveEdge)
                    graph.RemoveVertex(vertexOut);
            }

            return graph;
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
                if (!graph.Vertices.Contains(vertex) && !string.IsNullOrWhiteSpace(vertex) && !vertex.Contains("NVD"))
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
                //Если есть откуда и куда строить
                if (graph.ContainsVertex(vertexFrom) && graph.ContainsVertex(vertexTo))
                    graph.AddEdge(new Edge<string>(vertexFrom, vertexTo));
            }
        }

        public List<TwoConceptWithWeight> GetConceptsWithWeight (List<CweEntity> cweList, List<ProcessedCweCapec> cweCapecsList)
        {
            var result = new List<TwoConceptWithWeight>();
            //Путь к файлу изначальному (cwe-123;descr;capec-123;descrip)
            var filePathConceptsWithDescriptions = string.Format(@"C:/temp/temp.txt");
            //Путь к файлу с весами (cwe-123;capec-123;0.6)
            var filePathConceptsWithWeights = string.Format(@"C:/temp/weights.txt");
            //Создаем/Очищаем оба файла
            File.WriteAllText(filePathConceptsWithDescriptions, string.Empty);
            File.WriteAllText(filePathConceptsWithWeights, string.Empty);

            foreach (var cweCapecs in cweCapecsList)
            {

                foreach (var capec in cweCapecs.CapecList)
                {
                    // Инициализация строки в которую будет идти запись концептов и их описаний
                    var line = string.Empty;
                    //Формирование строки
                    line += cweCapecs.Cwe + ";";
                    line += cweList.Where(x => x.Id == cweCapecs.Cwe).First().Description + ";";
                    line += capec.Id + ";";
                    line += capec.Description;

                    //Строка сформирована, начинаем запись текущей строки в файл
                    using (StreamWriter sw = new StreamWriter(filePathConceptsWithDescriptions, true, System.Text.Encoding.UTF8))
                        sw.WriteLine(line);
                }
            }
            //Текстовый файл сформирован

            //[Здесь должен быть вызов внешней подпрограммы находящей связи]

            System.Threading.Thread.Sleep(5000);
            //Чтение сформированного файла с весами
            using (StreamReader sr = new StreamReader(filePathConceptsWithWeights, System.Text.Encoding.UTF8))
            {
                string line;
                //Пока есть откуда читать
                while ((line = sr.ReadLine()) != null)
                {
                    // Разбиваем читаемую строку в массив, где [0] - откуда, [1] - куда, [2] - вес (double)
                    var rawLine = line.Split(';');
                    // Записываем в объектную модель
                    result.Add(new TwoConceptWithWeight
                    {
                        FromConcept = rawLine[0],
                        ToConcept = rawLine[1],
                        Weight = Convert.ToDouble(rawLine[2])
                    });
                }
            }

            return result;
        }

        public DataTable GetConceptsWithWeightDataTable (List<TwoConceptWithWeight> conceptsWithWeight)
        {
            var result = new DataTable("Weights");
            DataColumn column;
            DataRow row;

            //1
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "From";
            column.ReadOnly = true;
            column.Unique = false;
            column.AutoIncrement = false;
            result.Columns.Add(column);

            //2
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "To";
            column.AutoIncrement = false;
            column.ReadOnly = false;
            column.Unique = false;
            result.Columns.Add(column);

            //3
            column = new DataColumn();
            column.DataType = Type.GetType("System.Double");
            column.ColumnName = "Weight";
            column.AutoIncrement = false;
            column.ReadOnly = false;
            column.Unique = false;
            result.Columns.Add(column);

            foreach (var conceptWithWeight in conceptsWithWeight)
            {
                row = result.NewRow();
                row["From"] = conceptWithWeight.FromConcept;
                row["To"] = conceptWithWeight.ToConcept;
                row["Weight"] = conceptWithWeight.Weight;

                result.Rows.Add(row);
            }
            return result;
        }
    }
}
