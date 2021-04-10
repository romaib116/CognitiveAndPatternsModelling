using CognitiveMaps.MAT.Models;
using CognitiveMaps.MAT.Models.RawDataTypes;
using System;
using System.Collections.Generic;
using System.Data;

namespace CognitiveMaps.MAT.BL
{
    /// <summary>
    /// Бизнес логика для работы с BDU
    /// </summary>
    public class BduBL
    {
        /// <summary>
        /// Получить список объектов BDU
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public List<BduEntity> GetBduList(string filePath)
        {
            try
            {
                return ProcessExcelBdu(new BduExcel(filePath));
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Создаем таблицу для отображения
        /// </summary>
        /// <param name="bduEntities"></param>
        /// <returns></returns>
        public DataTable GetBduDataTable(List<BduEntity> bduEntities)
        {
            var result = new DataTable("Bdu");
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
            column = new DataColumn
            {
                DataType = Type.GetType("System.String"),
                ColumnName = "Идентификатор",
                ReadOnly = true,
                Unique = true
            };
            result.Columns.Add(column);

            //2
            column = new DataColumn
            {
                DataType = Type.GetType("System.String"),
                ColumnName = "Наименование_уязвимости",
                AutoIncrement = false,
                ReadOnly = false,
                Unique = false
            };
            result.Columns.Add(column);

            //4
            column = new DataColumn
            {
                DataType = Type.GetType("System.String"),
                ColumnName = "Дата_выявления",
                AutoIncrement = false,
                ReadOnly = false,
                Unique = false
            };
            result.Columns.Add(column);


            //5
            column = new DataColumn
            {
                DataType = Type.GetType("System.String"),
                ColumnName = "Статус_уязвимости",
                AutoIncrement = false,
                ReadOnly = false,
                Unique = false
            };
            result.Columns.Add(column);

            //6
            column = new DataColumn
            {
                DataType = Type.GetType("System.String"),
                ColumnName = "CWE",
                AutoIncrement = false,
                ReadOnly = false,
                Unique = false
            };
            result.Columns.Add(column);

            int iterator = 0;
            foreach (var bdu in bduEntities)
            {
                row = result.NewRow();
                row["id"] = iterator;
                row["Идентификатор"] = bdu.Id;
                row["Наименование_уязвимости"] = bdu.VulnerabilityName;
                row["Дата_выявления"] = bdu.DataDetection;
                row["Статус_уязвимости"] = bdu.StatusVulnerability;
                row["CWE"] = string.Join(", ", bdu.Cwe);
                result.Rows.Add(row);
                iterator++;
            }
            return result;
        }

        /// <summary>
        /// Метод получающий список объектов BDU из сущности экселя
        /// </summary>
        /// <param name="bduExcel"></param>
        /// <returns></returns>
        private List<BduEntity> ProcessExcelBdu(BduExcel bduExcel)
        {
            var result = new List<BduEntity>();

            for (int i = 0; i < bduExcel.CountRowsInTable; i++)
            {
                result.Add(new BduEntity
                {
                    Id = bduExcel.IdList[i],
                    VulnerabilityName = bduExcel.VulnerabilityNameList[i],
                    DescriptionVulnerability = bduExcel.DescriptionVulnerabilityList[i],
                    VendorSoftware = bduExcel.VendorSoftwareList[i],
                    NameSoftware = bduExcel.NameSoftwareList[i],
                    VersionSoftware = bduExcel.VersionSoftwareList[i],
                    TypeSoftware = bduExcel.TypeSoftwareList[i],
                    OperationSystem = bduExcel.OperationSystemList[i],
                    ClassVulnerability = bduExcel.ClassVulnerabilityList[i],
                    DataDetection = bduExcel.DataDetectionList[i],
                    CVSS2 = bduExcel.CVSS2List[i],
                    CVSS3 = bduExcel.CVSS3List[i],
                    HazardLevel = bduExcel.HazardLevelList[i],
                    Measures = bduExcel.MeasuresList[i],
                    StatusVulnerability = bduExcel.StatusVulnerabilityList[i],
                    AvailabilityExploit = bduExcel.AvailabilityExploitList[i],
                    RemedyInformation = bduExcel.RemedyInformationList[i],
                    SourceLink = ProcessLinks(bduExcel.SourceLinkList[i]),
                    IdsOtherVulnerabilitySystem = ProcessIds(bduExcel.IdsOtherVulnerabilitySystemsList[i]),
                    OtherInformation = bduExcel.OtherInformationList[i],
                    DescriptionErrorCWE = bduExcel.DescriptionErrorCWEList[i],
                    Cwe = ProcessIds(bduExcel.TypeCWEList[i])
                });
            }
            return result;
        }

        /// <summary>
        /// Вспомогательный метод для обработки ссылок
        /// </summary>
        /// <param name="links"></param>
        /// <returns></returns>
        private List<string> ProcessLinks(string links)
        {
            var result = new List<string>(
                links.
                Replace("\n", "").
                Replace("http", "").
                Replace("ftp", "").
                Replace("https", "").
                Split(new string[] { "://" }, StringSplitOptions.RemoveEmptyEntries));
            return result;
        }

        /// <summary>
        /// Вспомогательный метод для обработки ИДов (CWE, CVE итд)
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        private List<string> ProcessIds(string ids)
        {
            return new List<string>(ids.Split(new string[] { ", " }, StringSplitOptions.None));
        }

    }
}
