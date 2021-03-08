using CognitiveMaps.MAT.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CognitiveMaps.MAT.BL
{
    public class CveBL
    {

        /// <summary>
        /// Получить лист CVE из файла
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public List<CveEntity> GetCveList(string filePath)
        {
            return ConvertDeserializeToList(DeserializeCveJson(filePath));
        }


        /// <summary>
        /// Десериализация JSON с CVE
        /// </summary>
        private CveJson DeserializeCveJson(string filePath)
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
        private List<CveEntity> ConvertDeserializeToList (CveJson cveJson)
        {
            List<CveEntity> cveList = new List<CveEntity>();
            
            foreach (var currentCVE in cveJson.CVEItems)
            {
                var cve = new CveEntity();

                cve.Id = currentCVE.Cve.CVEDataMeta.ID != null ? currentCVE.Cve.CVEDataMeta.ID : "";
                //У одного CVE бывает более 1 CWE
                if (currentCVE.Cve.Problemtype.ProblemtypeData.First().Description.Count > 1)
                {
                    foreach (var item in currentCVE.Cve.Problemtype.ProblemtypeData.First().Description)
                        cve.CWE += item.Value + ",";
                    //Удалим лишнюю ','
                    cve.CWE = cve.CWE.Remove(cve.CWE.Length - 1);
                }
                else
                    cve.CWE = currentCVE.Cve.Problemtype.ProblemtypeData.First().Description.Count == 1 ?
                        currentCVE.Cve.Problemtype.ProblemtypeData.First().Description.First().Value : " ";
                cve.Url = currentCVE.Cve.References.ReferenceData.Count != 0 ? currentCVE.Cve.References.ReferenceData.First().Url : " ";
                cve.Decription = currentCVE.Cve.Description.DescriptionData.Count != 0 ? currentCVE.Cve.Description.DescriptionData.First().Value : " ";
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
    }
}
