using CognitiveMaps.MAT.Models;
using CognitiveMaps.MAT.Models.RawDataTypes.CveJson;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;

namespace CognitiveMaps.MAT.BL
{
    /// <summary>
    /// Бизнес-логика для работы с CVE
    /// </summary>
    public class CveBL
    {

        /// <summary>
        /// Получить лист CVE из файла
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public List<CveEntity> GetCveList(string filePath)
        {
            try
            {
                return ConvertRawObjectsToEntities(ConvertJsonToRawObjects(filePath));
            }
            catch
            {
                throw;
            }
        }


        /// <summary>
        /// Десериализация JSON с CVE
        /// </summary>
        private CveJson ConvertJsonToRawObjects(string filePath)
        {
            string file = File.ReadAllText(filePath);
            var result = JsonConvert.DeserializeObject<CveJson>(file, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });
            return result;
        }


        /// <summary>
        /// Преобразование десериализованного JSON в набор объектов CVE с нужными полями
        /// </summary>
        private List<CveEntity> ConvertRawObjectsToEntities (CveJson cveJson)
        {
            List<CveEntity> cveList = new List<CveEntity>();
            
            foreach (var currentCVE in cveJson.CVEItems)
            {
                var cve = new CveEntity();
                cve.Cwe = new List<string>();
                cve.Id = currentCVE.Cve.CVEDataMeta.ID != null ? currentCVE.Cve.CVEDataMeta.ID : "";
                //У одного CVE бывает более 1 CWE
                if (currentCVE.Cve.Problemtype.ProblemtypeData.First().Description.Count > 1)
                {
                    foreach (var item in currentCVE.Cve.Problemtype.ProblemtypeData.First().Description)
                        cve.Cwe.Add(item.Value);
                }
                else
                    cve.Cwe.Add(currentCVE.Cve.Problemtype.ProblemtypeData.First().Description.Count == 1 ?
                        currentCVE.Cve.Problemtype.ProblemtypeData.First().Description.First().Value : " ");
                cve.Url = currentCVE.Cve.References.ReferenceData.Count != 0 ? currentCVE.Cve.References.ReferenceData.First().Url : " ";
                cve.Description = currentCVE.Cve.Description.DescriptionData.Count != 0 ? currentCVE.Cve.Description.DescriptionData.First().Value : " ";
                //CVSSv3 может отсутствовать
                if (currentCVE.Impact.BaseMetricV3 != null )
                {
                    cve.AttackVector = IfExist(currentCVE.Impact.BaseMetricV3.CvssV3.AttackVector);
                    cve.AttackComplexity = IfExist(currentCVE.Impact.BaseMetricV3.CvssV3.AttackComplexity);
                    cve.PrivilegesRequired = IfExist(currentCVE.Impact.BaseMetricV3.CvssV3.PrivilegesRequired);
                    cve.UserInteraction = IfExist(currentCVE.Impact.BaseMetricV3.CvssV3.UserInteraction);
                    cve.Scope = IfExist(currentCVE.Impact.BaseMetricV3.CvssV3.Scope);
                    cve.ConfidentialityImpact = IfExist(currentCVE.Impact.BaseMetricV3.CvssV3.ConfidentialityImpact);
                    cve.IntegrityImpact = IfExist(currentCVE.Impact.BaseMetricV3.CvssV3.IntegrityImpact);
                    cve.AvailabilityImpact = IfExist(currentCVE.Impact.BaseMetricV3.CvssV3.AvailabilityImpact);
                    cve.BaseScore = currentCVE.Impact.BaseMetricV3.CvssV3.BaseScore;
                    cve.BaseSeverity = IfExist(currentCVE.Impact.BaseMetricV3.CvssV3.BaseSeverity);
                    cve.ExploitabilityScore = currentCVE.Impact.BaseMetricV3.ExploitabilityScore;
                    cve.ImpactScore = currentCVE.Impact.BaseMetricV3.ImpactScore;
                }
                cve.PublishedDate = IfExist(currentCVE.PublishedDate);
                cve.LastModifiedDate = IfExist(currentCVE.LastModifiedDate);

                cveList.Add(cve);
            }
            return cveList;
        }


        /// <summary>
        /// Проверка на null 
        /// </summary>
        /// <param name="str"></param>
        /// <returns>  В любом случае возвращается что-то  </returns>
        private string IfExist(string str)
        {
            return str != null ? str : " ";
        }



        public DataTable GetCveDataTable (List<CveEntity> cveEntities)
        {
            var result = new DataTable("Cve");
            DataColumn column;
            DataRow row;

            //0
            column = new DataColumn();
            column.DataType = Type.GetType("System.Int32");
            column.ColumnName = "id";
            column.ReadOnly = true;
            column.Unique = true;
            result.Columns.Add(column);

            //1
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Идентификатор";
            column.ReadOnly = true;
            column.Unique = true;
            result.Columns.Add(column);

            //2
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Описание_уязвимости";
            column.AutoIncrement = false;
            column.ReadOnly = true;
            column.Unique = false;
            result.Columns.Add(column);

            //3
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Дата_выявления";
            column.AutoIncrement = false;
            column.ReadOnly = true;
            column.Unique = false;
            result.Columns.Add(column);


            //4
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Уязвимое_место";
            column.AutoIncrement = false;
            column.ReadOnly = true;
            column.Unique = false;
            result.Columns.Add(column);

            //5
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "CWE";
            column.AutoIncrement = false;
            column.ReadOnly = true;
            column.Unique = false;
            result.Columns.Add(column);

            int iterator = 0;
            foreach (var cve in cveEntities)
            {
                row = result.NewRow();
                row["id"] = iterator;
                row["Идентификатор"] = cve.Id;
                row["Описание_Уязвимости"] = cve.Description;
                row["Дата_Выявления"] = cve.PublishedDate;
                row["Уязвимое_Место"] = cve.AttackVector;
                row["CWE"] = String.Join(", ", cve.Cwe);
                result.Rows.Add(row);
                iterator++;
            }
            return result;
        }
    }
}
