namespace CognitiveMaps.MAT.Models
{
    /// <summary>
    /// Сущность CVE
    /// </summary>
    public class CveEntity : CommonVulnerability
    {
        /// <summary>
        /// Ссылка на описание уязвимости
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }

        #region Описание уязвимости по метрике CVSSV3

        /// <summary>
        /// На какой сегмент атака влияет
        /// </summary>
        public string AttackVector { get; set; }

        /// <summary>
        /// Сложность атаки
        /// </summary>
        public string AttackComplexity { get; set; }

        /// <summary>
        /// Какие нужны привелегии для атаки
        /// </summary>
        public string PrivilegesRequired { get; set; }

        /// <summary>
        /// Взаимодействие с юзером
        /// </summary>
        public string UserInteraction { get; set; }

        /// <summary>
        /// Влияет ли уязвимость в одном уязвимом компоненте на ресурсы в компонентах, выходящих за пределы его области безопасности
        /// </summary>
        public string Scope { get; set; }

        /// <summary>
        /// Показатель измеряет влияние на конфиденциальность
        /// </summary>
        public string ConfidentialityImpact { get; set; }

        /// <summary>
        /// Показатель измеряет влияние на целостность
        /// </summary>
        public string IntegrityImpact { get; set; }

        /// <summary>
        ///  показатель измеряет влияние на доступность
        /// </summary>
        public string AvailabilityImpact { get; set; }

        /// <summary>
        /// Формула базовой оценки зависит от подформул для промежуточной оценки воздействия (ISS)
        /// </summary>
        public double BaseScore { get; set; }

        /// <summary>
        /// Качественная шкала оценки степени серьезности
        /// </summary>
        public string BaseSeverity { get; set; }

        /// <summary>
        /// Оценка пригодности к использованию
        /// </summary>
        public double ExploitabilityScore { get; set; }

        /// <summary>
        /// Оценка воздействия
        /// </summary>
        public double ImpactScore { get; set; }

        #endregion

        /// <summary>
        /// Дата публикации
        /// </summary>
        public string PublishedDate { get; set; }

        /// <summary>
        /// Дата последнего изменения
        /// </summary>
        public string LastModifiedDate { get; set; }
    }
}
