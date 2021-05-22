using System;
using System.Collections.Generic;
using CognitiveMaps.MAT.Models.RawDataTypes.CweXml;
using CognitiveMaps.MAT.Models;
using System.Xml.Serialization;
using System.IO;
using System.Linq;

namespace CognitiveMaps.MAT.BL
{
    /// <summary>
    /// Бизнес-логика Cwe
    /// </summary>
    public class CweBL
    {

        /// <summary>
        /// Получить список Cwe
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public List<CweEntity> GetCweEntities(string filePath)
        {
            return ConvertRawObjectsToCwe(ConvertXmlToRawObjects(filePath));
        }

        /// <summary>
        /// Десериализация xml
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        private Weakness_Catalog ConvertXmlToRawObjects(string filePath)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Weakness_Catalog));
            Weakness_Catalog cweCatalog;
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                cweCatalog = (Weakness_Catalog)formatter.Deserialize(fs);
            }
            return cweCatalog;
        }

        /// <summary>
        /// Обработка набора сырых объектов после десериализации в список сущностей
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        private List<CweEntity> ConvertRawObjectsToCwe(Weakness_Catalog cweCatalog)
        {
            List<CweEntity> result = new List<CweEntity>();
            foreach (var pattern in cweCatalog.Weaknesses)
            {
                result.Add(new CweEntity
                {
                    Id = "CWE-" + Convert.ToString(pattern.ID),
                    Description = string.IsNullOrEmpty(pattern.Items[GetIndexByType(pattern, ItemsChoiceType2.Description)] as string) ?
                        string.Empty : pattern.Items[GetIndexByType(pattern, ItemsChoiceType2.Description)].ToString(),
                });
            }
            return result;
        }


        /// <summary>
        /// Получение индекса для текущего типа
        /// </summary>
        /// <param name="pattern"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        private int GetIndexByType(Weakness_CatalogWeakness pattern, ItemsChoiceType2 type)
        {
            var result = pattern.ItemsElementName.Select((item, index) => new { item, index })
                        .Where(ix => ix.item == type)
                        .Select(ix => ix.index).FirstOrDefault();
            return result;
        }

    }
}
