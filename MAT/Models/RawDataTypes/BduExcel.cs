using ExcelDataReader;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace CognitiveMaps.MAT.Models.RawDataTypes
{
    public class BduExcel
    {
        private DataTable _table;
        private List<object> _headerTable;
        private const int StartDataIndex = 3;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="filePath">Путь к Excel файлу</param>
        public BduExcel(string filePath)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    DataSet result = reader.AsDataSet();
                    _table = result.Tables[0];
                    _headerTable = result.Tables[0].Rows[2].ItemArray.ToList<object>();
                }
            }

            CountRowsInTable = _table.Rows.Count - StartDataIndex;

            IdList = FillList(IndexForHeaderText("Идентификатор"));
            VulnerabilityNameList = FillList(IndexForHeaderText("Наименование уязвимости"));
            DescriptionVulnerabilityList = FillList(IndexForHeaderText("Описание уязвимости"));
            VendorSoftwareList = FillList(IndexForHeaderText("Вендор ПО"));
            NameSoftwareList = FillList(IndexForHeaderText("Название ПО"));
            VersionSoftwareList = FillList(IndexForHeaderText("Версия ПО"));
            TypeSoftwareList = FillList(IndexForHeaderText("Тип ПО"));
            OperationSystemList = FillList(IndexForHeaderText("Наименование ОС и тип аппаратной платформы"));
            ClassVulnerabilityList = FillList(IndexForHeaderText("Класс уязвимости"));
            DataDetectionList = FillList(IndexForHeaderText("Дата выявления"));
            CVSS2List = FillList(IndexForHeaderText("CVSS 2.0"));
            CVSS3List = FillList(IndexForHeaderText("CVSS 3.0"));
            HazardLevelList = FillList(IndexForHeaderText("Уровень опасности уязвимости"));
            MeasuresList = FillList(IndexForHeaderText("Возможные меры по устранению"));
            StatusVulnerabilityList = FillList(IndexForHeaderText("Статус уязвимости"));
            AvailabilityExploitList = FillList(IndexForHeaderText("Наличие эксплойта"));
            RemedyInformationList = FillList(IndexForHeaderText("Информация об устранении"));
            SourceLinkList = FillList(IndexForHeaderText("Ссылки на источники"));
            IdsOtherVulnerabilitySystemsList = FillList(IndexForHeaderText("Идентификаторы других систем описаний уязвимости"));
            OtherInformationList = FillList(IndexForHeaderText("Прочая информация"));
            DescriptionErrorCWEList = FillList(IndexForHeaderText("Описание ошибки CWE"));
            TypeCWEList = FillList(IndexForHeaderText("Тип ошибки CWE"));
        }


        /// <summary>
        /// Получить индекс по содержанию текста столбца
        /// </summary>
        /// <param name="headerText"></param>
        /// <returns></returns>
        private int IndexForHeaderText(string headerText)
        {
            return _headerTable.IndexOf(_headerTable.Find(x => x.ToString().Contains(headerText)));
        }

        /// <summary>
        /// Заполнить необходимый лист
        /// </summary>
        /// <param name="index">По индексу столбца</param>
        /// <returns></returns>
        private List<string> FillList(int index)
        {
            var result = new List<string>();
            for (int i = StartDataIndex; i < _table.Rows.Count; i++)
            {
                result.Add(_table.Rows[i].ItemArray[index].ToString());
            }
            return result;
        }

        public long CountRowsInTable { get; private set; }

        /// <summary>
        /// Лист ИДов БДУ
        /// </summary>
        public IList<string> IdList { get; private set; }


        /// <summary>
        /// Лист наименований уязвимостей
        /// </summary>
        public IList<string> VulnerabilityNameList { get; private set; }

        /// <summary>
        /// Лист описаний уязвимостей
        /// </summary>
        public IList<string> DescriptionVulnerabilityList { get; private set; }

        /// <summary>
        /// Лист Вендор ПО
        /// </summary>
        public IList<string> VendorSoftwareList { get; private set; }

        /// <summary>
        /// Лист Название ПО
        /// </summary>
        public IList<string> NameSoftwareList { get; private set; }

        /// <summary>
        /// Лист Версия ПО
        /// </summary>
        public IList<string> VersionSoftwareList { get; private set; }

        /// <summary>
        /// Лист Тип ПО
        /// </summary>
        public IList<string> TypeSoftwareList { get; private set; }

        /// <summary>
        /// Лист Наименование ОС и тип аппаратной платформы
        /// </summary>
        public IList<string> OperationSystemList { get; private set; }

        /// <summary>
        /// Лист Класс уязвимости
        /// </summary>
        public IList<string> ClassVulnerabilityList { get; private set; }

        /// <summary>
        /// Лист Дата выявления
        /// </summary>
        public IList<string> DataDetectionList { get; private set; }

        /// <summary>
        /// Лист CVSS 2.0
        /// </summary>
        public IList<string> CVSS2List { get; private set; }

        /// <summary>
        /// Лист CVSS 3.0
        /// </summary>
        public IList<string> CVSS3List { get; private set; }

        /// <summary>
        /// Лист Уровень опасности уязвимости
        /// </summary>
        public IList<string> HazardLevelList { get; private set; }

        /// <summary>
        /// Лист Возможные меры по устранению
        /// </summary>
        public IList<string> MeasuresList { get; private set; }

        /// <summary>
        /// Лист Статус уязвимости
        /// </summary>
        public IList<string> StatusVulnerabilityList { get; private set; }

        /// <summary>
        /// Наличие эксплойта
        /// </summary>
        public IList<string> AvailabilityExploitList { get; private set; }

        /// <summary>
        /// Лист Информация об устранении
        /// </summary>
        public IList<string> RemedyInformationList { get; private set; }

        /// <summary>
        /// Лист Ссылки на источники
        /// </summary>
        public IList<string> SourceLinkList { get; private set; }

        /// <summary>
        /// Лист Идентификаторы других систем описаний уязвимости
        /// </summary>
        public IList<string> IdsOtherVulnerabilitySystemsList { get; private set; }

        /// <summary>
        /// Лист Прочая информация
        /// </summary>
        public IList<string> OtherInformationList { get; private set; }

        /// <summary>
        /// Лист описание ошибки CWE
        /// </summary>
        public IList<string> DescriptionErrorCWEList { get; private set; }

        /// <summary>
        /// Лист типа ошибки CWE
        /// </summary>
        public IList<string> TypeCWEList { get; private set; }
    }
}
