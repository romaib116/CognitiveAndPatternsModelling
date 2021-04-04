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

            //5
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
        public List<ProcessedCweCapec> GetProcessedCweCapecs (List<CommonVulnerability> userList, List<CapecEntity> capecList)
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
        private List<CapecEntity> FindRelationsCweCapec (string currentCwe, List<CapecEntity> capecList)
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



        /*
        public void CreateGraph()
        {
            AdjacencyGraph<string, Edge<string>> graph = new AdjacencyGraph<string, Edge<string>>(true);

            graph.AddVertex("A");
            graph.AddVertex("B");
            graph.AddVertex("C");
            graph.AddVertex("D");
            
            graph.AddEdge(new Edge<string>("A", "D"));
            graph.AddEdge(new Edge<string>("B", "D"));
            graph.AddEdge(new Edge<string>("C", "D"));
            graph.AddEdge(new Edge<string>("D", "D"));
            Visualizer.Visualize(graph, "somefile");
            //pictureBox1.ImageLocation = @"c:\temp\somefile.jpg";
        }
        */
    }
}
