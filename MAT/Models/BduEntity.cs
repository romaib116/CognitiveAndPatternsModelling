using System.Collections.Generic;

namespace CognitiveMaps.MAT.Models
{
    /// <summary>
    /// Сущность BDU
    /// </summary>
    public class BduEntity : CommonVulnerability
    {
        /// <summary>
        /// Наименование уязвимости
        /// </summary>
        public string VulnerabilityName { get; set; }

        /// <summary>
        /// Описание уязвимости
        /// </summary>
        public string DescriptionVulnerability { get; set; }

        /// <summary>
        /// Вендор ПО
        /// </summary>
        public string VendorSoftware { get; set; }

        /// <summary>
        /// Название ПО
        /// </summary>
        public string NameSoftware { get; set; }

        /// <summary>
        /// Версия ПО
        /// </summary>
        public string VersionSoftware { get; set; }

        /// <summary>
        /// Тип ПО
        /// </summary>
        public string TypeSoftware { get; set; }

        /// <summary>
        /// Наименование ОС и тип аппаратной платформы
        /// </summary>
        public string OperationSystem { get; set; }

        /// <summary>
        /// Класс уязвимости
        /// </summary>
        public string ClassVulnerability { get; set; }

        /// <summary>
        /// Дата выявления
        /// </summary>
        public string DataDetection { get; set; }

        /// <summary>
        /// CVSS 2.0
        /// </summary>
        public string CVSS2 { get; set; }

        /// <summary>
        /// CVSS 3.0
        /// </summary>
        public string? CVSS3 { get; set; }

        /// <summary>
        /// Уровень опасности уязвимости
        /// </summary>
        public string HazardLevel { get; set; }

        /// <summary>
        /// Возможные меры по устранению
        /// </summary>
        public string Measures { get; set; }

        /// <summary>
        /// Статус уязвимости
        /// </summary>
        public string StatusVulnerability { get; set; }

        /// <summary>
        /// Наличие эксплойта
        /// </summary>
        public string AvailabilityExploit { get; set; }

        /// <summary>
        /// Информация об устранении
        /// </summary>
        public string RemedyInformation { get; set; }

        /// <summary>
        /// Ссылки на источники
        /// </summary>
        public List<string> SourceLink { get; set; }

        /// <summary>
        /// Идентификаторы других систем описаний уязвимости
        /// </summary>
        public List<string> IdsOtherVulnerabilitySystem { get; set; }

        /// <summary>
        /// Прочая информация
        /// </summary>
        public string OtherInformation { get; set; }

        /// <summary>
        /// Описание ошибки CWE
        /// </summary>
        public string DescriptionErrorCWE { get; set; }
    }
}
