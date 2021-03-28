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

namespace CognitiveMaps.MAT.BL
{

    /// <summary>
    /// Логика работы с уязвимостями выбранными пользователем
    /// </summary>
    public class MatBL 
    {
        public DataTable GetBduDataTable(List<CommonVulnerability> vulnList)
        {
            var result = new DataTable("UserVulns");
            DataColumn column;
            DataRow row;

            //1
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Идентификатор";
            column.ReadOnly = true;
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
                    throw new DuplicateNameException("Нельзя добавлять 2 раза подряд одно и тоже");
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
