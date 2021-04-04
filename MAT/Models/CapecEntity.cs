using CognitiveMaps.MAT.Models.Capec;
using System.Collections.Generic;

namespace CognitiveMaps.MAT.Models
{
    /// <summary>
    /// Сущность описывающая Capec
    /// </summary>
    public class CapecEntity : CommonVulnerability
    {
        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Вероятность атаки
        /// </summary>
        public string LikelihoodAttack { get; set; }

        /// <summary>
        /// Серьезность атаки
        /// </summary>
        public string TypicalSeverity { get; set; }

        /// <summary>
        /// Связанные шаблоны атак
        /// </summary>
        public List<RelatedAttackPattern> RelatedAttackPatterns { get; set; }

        /// <summary>
        /// Пошаговый процесс выполнения
        /// </summary>
        public ExecutionFlow ExecutionFlow { get; set; }

        /// <summary>
        /// Предпосылки
        /// </summary>
        public List<string> Prerequisites { get; set; }

        /// <summary>
        /// Необходимый уровень навыков
        /// </summary>
        public List<SkillsRequired> SkillsRequireds { get; set; }

        /// <summary>
        /// Последствия
        /// </summary>
        public List<Consequence> Consequences { get; set; }

        /// <summary>
        /// Смягчающие
        /// </summary>
        public string Mitigations { get; set; }

        /// <summary>
        /// Примеры кейсов
        /// </summary>
        public List<string> ExampleInstances { get; set; }

        /// <summary>
        /// ??? Taxonomy_Mappings
        /// </summary>
        public List<TaxonomyMapping> TaxonomyMappings { get; set; }

        /// <summary>
        /// История появления
        /// </summary>
        public ContentHistory ContentHistorys { get; set; }
    }
}
