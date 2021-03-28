using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CognitiveMaps.MAT.Models;

namespace CognitiveMaps.MAT.Views
{
    public partial class DetailView : Form
    {

        private DetailPresenter _presenter;
        private CveEntity CveEntity;
        private BduEntity BduEntity;

        /// <summary>
        /// Презентер
        /// </summary>
        public DetailPresenter Presenter
        {
            get { return _presenter ??= new DetailPresenter(this); }
        }

        /// <summary>
        /// Конструктор для Cve
        /// </summary>
        /// <param name="cveEntity"></param>
        public DetailView(CveEntity cveEntity)
        {
            InitializeComponent();
            CveEntity = cveEntity;
        }

        /// <summary>
        /// Конструтор для Bdu
        /// </summary>
        /// <param name="bduEntity"></param>
        public DetailView(BduEntity bduEntity)
        {
            InitializeComponent();
            BduEntity = bduEntity;
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //Если загрузили CVE, то показываем про него
            if (CveEntity != null)
            {
                groupBoxDetail.Text = CveEntity.Id;
                textBoxDetail.TabStop = false;
                textBoxDetail.Text = string.Format(
                    "Cwe: {0}" +
                    Environment.NewLine +
                    "Описание: {1}" +
                    Environment.NewLine +
                    "Вектор атаки: {2}" +
                    Environment.NewLine +
                    "Сложность проведения: {3}" +
                    Environment.NewLine +
                    "Необходимы привелегии: {4}" +
                    Environment.NewLine +
                    "Взаимодействие с пользователем: {5}" +
                    Environment.NewLine +
                    "Объем: {6}" +
                    Environment.NewLine +
                    "Влияние на конфиденциальность: {7}" +
                    Environment.NewLine +
                    "Влияние на целостность: {8}" +
                    Environment.NewLine +
                    "Влияние на доступность: {9}" +
                    Environment.NewLine +
                    "Дата публикации: {10}",

                    string.Join(", ", CveEntity.Cwe),
                    CveEntity.Description,
                    CveEntity.AttackVector,
                    CveEntity.AttackComplexity,
                    CveEntity.PrivilegesRequired,
                    CveEntity.UserInteraction,
                    CveEntity.Scope,
                    CveEntity.ConfidentialityImpact,
                    CveEntity.IntegrityImpact,
                    CveEntity.AvailabilityImpact,
                    CveEntity.PublishedDate
                    );
            }

            if (BduEntity != null)
            {
                groupBoxDetail.Text = BduEntity.Id;
                textBoxDetail.TabStop = false;
                textBoxDetail.Text = string.Format(
                    "Cwe: {0}" +
                    Environment.NewLine +
                    "Описание: {1}" +
                    Environment.NewLine +
                    "Класс уязвимости: {2}" +
                    Environment.NewLine +
                    "Наличие эксплоита: {3}" +
                    Environment.NewLine +
                    "Статус уязвимости: {4}" +
                    Environment.NewLine +
                    "Информация об устранении: {5}" +
                    Environment.NewLine +
                    "Возможные меры по устранению: {6}" +
                    Environment.NewLine +
                    "Уровень опасности: {7}" +
                    Environment.NewLine +
                    "Cvss2: {8}" +
                    Environment.NewLine +
                    "Cvss3: {9}" +
                    Environment.NewLine +
                    "Дата вявления: {10}",

                    string.Join(", ", BduEntity.Cwe),
                    BduEntity.DescriptionVulnerability,
                    BduEntity.ClassVulnerability,
                    BduEntity.AvailabilityExploit,
                    BduEntity.StatusVulnerability,
                    BduEntity.RemedyInformation,
                    BduEntity.Measures,
                    BduEntity.HazardLevel,
                    BduEntity.CVSS2,
                    BduEntity.CVSS3,
                    BduEntity.DataDetection
                    );
            }

        }

    }
}
