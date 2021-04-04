using CognitiveMaps.MAT.Models;
using CognitiveMaps.MAT.Models.RawDataTypes.CapecXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CognitiveMaps.MAT.Models.Capec;
using System.Xml.Serialization;
using System.Data;

namespace CognitiveMaps.MAT.BL
{
    /// <summary>
    /// Логика для работы с Capec
    /// </summary>
    public class CapecBL
    {
        /// <summary>
        /// Получить список Capec
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public List<CapecEntity> GetCapecEntities(string filePath)
        {
            return ConvertRawObjectsToCapec(ConvertXmlToRawObjects(filePath));
        }

        /// <summary>
        /// Получить таблицу Capec для отображения в форме
        /// </summary>
        /// <param name="capecList"></param>
        /// <returns></returns>
        public DataTable GetCapecDataTable(List<CapecEntity> capecList)
        {
            var result = new DataTable("Capec");
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
            column.ColumnName = "Описание";
            column.AutoIncrement = false;
            column.ReadOnly = true;
            column.Unique = false;
            result.Columns.Add(column);

            //3
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Вероятность";
            column.AutoIncrement = false;
            column.ReadOnly = true;
            column.Unique = false;
            result.Columns.Add(column);


            //4
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Серьезность";
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
            foreach (var capec in capecList)
            {
                row = result.NewRow();
                row["id"] = iterator;
                row["Идентификатор"] = capec.Id;
                row["Описание"] = capec.Description;
                row["Вероятность"] = capec.LikelihoodAttack;
                row["Серьезность"] = capec.TypicalSeverity;
                row["CWE"] = string.Join("; ", capec.Cwe);
                result.Rows.Add(row);
                iterator++;
            }
            return result;
        }


        /// <summary>
        /// Десериализация xml
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        private Attack_Pattern_Catalog ConvertXmlToRawObjects(string filePath)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Attack_Pattern_Catalog));
            Attack_Pattern_Catalog capecCatalog;
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                capecCatalog = (Attack_Pattern_Catalog)formatter.Deserialize(fs);
            }
            return capecCatalog;
        }

        /// <summary>
        /// Обработка набора сырых объектов после десериализации в список сущностей
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        private List<CapecEntity> ConvertRawObjectsToCapec(Attack_Pattern_Catalog capecCatalog)
        {
            List<CapecEntity> result = new List<CapecEntity>();
            foreach (var pattern in capecCatalog.Attack_Patterns)
            {
                result.Add(new CapecEntity
                {
                    Id = Convert.ToString(pattern.ID),
                    Description = FillDescription(pattern),
                    LikelihoodAttack = pattern.Items[GetIndexByType(pattern, ItemsChoiceType.Likelihood_Of_Attack)].ToString(),
                    TypicalSeverity = pattern.Items[GetIndexByType(pattern, ItemsChoiceType.Typical_Severity)].ToString(),
                    RelatedAttackPatterns = FillRelatedAttackPatterns(pattern),
                    ExecutionFlow = FillExecutionFlow(pattern),
                    Prerequisites = FillPrerequisites(pattern),
                    SkillsRequireds = FillSkillsRequired(pattern),
                    Consequences = FillConsequences(pattern),
                    Mitigations = FillMigrations(pattern),
                    ExampleInstances = FillExampleInstances(pattern),
                    TaxonomyMappings = FillTaxonomyMappings(pattern),
                    Cwe = FillCwe(pattern),
                    ContentHistorys = FillContentHistory(pattern)
                }) ;
            }
            return result;
        }


        /// <summary>
        /// Получение индекса для текущего типа
        /// </summary>
        /// <param name="pattern"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        private int GetIndexByType(Attack_Pattern_CatalogAttack_Pattern pattern, ItemsChoiceType type)
        {
            var result = pattern.ItemsElementName.Select((item, index) => new { item, index })
                        .Where(ix => ix.item == type)
                        .Select(ix => ix.index).FirstOrDefault();
            return result;
        }


        /// <summary>
        /// Вспомогательный метод заполнения описания
        /// </summary>
        /// <param name="pattern"></param>
        /// <returns></returns>
        private string FillDescription(Attack_Pattern_CatalogAttack_Pattern pattern)
        {
            var description = (pattern.Items[GetIndexByType(pattern, ItemsChoiceType.Description)] as Attack_Pattern_CatalogAttack_PatternDescription);
            return description.Text == null ?
                   description.p == null ? string.Empty :
                   String.Join("; ", description.p) :
                   String.Join("; ", description.Text);
        }


        /// <summary>
        /// Вспомогательный метод заполнения связанных шаблонов атак
        /// </summary>
        /// <param name="pattern"></param>
        /// <returns></returns>
        private List<RelatedAttackPattern> FillRelatedAttackPatterns(Attack_Pattern_CatalogAttack_Pattern pattern)
        {
            var result = new List<RelatedAttackPattern>();
            var RelatedAttackPatterns = (pattern.Items[GetIndexByType(pattern, ItemsChoiceType.Related_Attack_Patterns)] as Attack_Pattern_CatalogAttack_PatternRelated_Attack_Patterns);
            if (RelatedAttackPatterns != null)
            {
                foreach (var attackPattern in RelatedAttackPatterns.Related_Attack_Pattern)
                {
                    result.Add(new RelatedAttackPattern
                    {
                        CapecId = attackPattern.CAPEC_ID,
                        Nature = string.IsNullOrWhiteSpace(attackPattern.Nature) ? string.Empty : attackPattern.Nature
                    });
                }
            }
            return result;
        }


        /// <summary>
        /// Вспомогательный метод заполнения процесса выполнения
        /// </summary>
        /// <param name="pattern"></param>
        /// <returns></returns>
        private ExecutionFlow FillExecutionFlow(Attack_Pattern_CatalogAttack_Pattern pattern)
        {
            var result = new ExecutionFlow();
            result.AttackSteps = new List<ExecutionFlowAttackStep>();
            var executionFlow = (pattern.Items[GetIndexByType(pattern, ItemsChoiceType.Execution_Flow)] as Attack_Pattern_CatalogAttack_PatternExecution_Flow);
            if (executionFlow != null)
            {
                foreach (var attackStep in executionFlow.Attack_Step)
                {
                    result.AttackSteps.Add(new ExecutionFlowAttackStep
                    {
                        StepId = attackStep.Step,
                        Phase = attackStep.Phase,
                        Description = attackStep.Description.Text == null ? string.Empty : string.Join("; ", attackStep.Description.Text),
                        Techniques = attackStep.Technique != null ? 
                            attackStep.Technique.Where(i => i.Text != null).Select(t => t.Text).Select(j => string.Join("", j)).ToList() :
                            new List<string>()
                    });
                }
            }
            return result;
        }


        /// <summary>
        /// Вспомогательный метод заполнения условий
        /// </summary>
        /// <param name="pattern"></param>
        /// <returns></returns>
        private List<string> FillPrerequisites(Attack_Pattern_CatalogAttack_Pattern pattern)
        {
            var result = new List<string>();
            var prerequisites = (pattern.Items[GetIndexByType(pattern, ItemsChoiceType.Prerequisites)] as Attack_Pattern_CatalogAttack_PatternPrerequisites);
            if (prerequisites != null)
            {
                foreach (var prerequisite in prerequisites.Prerequisite)
                {
                    result.Add(prerequisite);
                }
            }
            return result;
        }

        /// <summary>
        /// Вспомогательный метод заполнения необходимых навыков
        /// </summary>
        /// <param name="pattern"></param>
        /// <returns></returns>
        private List<SkillsRequired> FillSkillsRequired(Attack_Pattern_CatalogAttack_Pattern pattern)
        {
            var result = new List<SkillsRequired>();
            var skillRequired = (pattern.Items[GetIndexByType(pattern, ItemsChoiceType.Skills_Required)] as Attack_Pattern_CatalogAttack_PatternSkills_Required);
            if (skillRequired != null)
            {
                foreach (var skill in skillRequired.Skill)
                {
                    result.Add(new SkillsRequired
                    {
                        SkillLevel = skill.Level,
                        Description = skill.Value
                    });
                }
            }
            return result;
        }


        private List<Consequence> FillConsequences(Attack_Pattern_CatalogAttack_Pattern pattern)
        {
            var result = new List<Consequence>();
            var consequences = (pattern.Items[GetIndexByType(pattern, ItemsChoiceType.Consequences)] as Attack_Pattern_CatalogAttack_PatternConsequences);
            if (consequences != null)
            {
                foreach (var consequence in consequences.Consequence)
                {
                    result.Add(new Consequence
                    {
                        Impacts = new List<string>(consequence.Impact.Where(i => i != null)),
                        Scopes = new List<string>(consequence.Scope.Where(i => i != null))
                    });
                }
            }
            return result;
        }

        private string FillMigrations(Attack_Pattern_CatalogAttack_Pattern pattern)
        {
            string result = string.Empty;
            var migrations = (pattern.Items[GetIndexByType(pattern, ItemsChoiceType.Mitigations)] as Attack_Pattern_CatalogAttack_PatternMitigations);
            if (migrations != null)
            {
                foreach (var migration in migrations.Mitigation)
                {
                    result = migration.Items != null ? string.Join("; ", migration.Items) :
                             migration.Text != null ? string.Join("; ", migration.Text) :
                                 string.Empty;
                }
            }
            return result;
        }

        private List<string> FillExampleInstances(Attack_Pattern_CatalogAttack_Pattern pattern)
        {
            var result = new List<string>();
            var exampleInstances = (pattern.Items[GetIndexByType(pattern, ItemsChoiceType.Example_Instances)] as Attack_Pattern_CatalogAttack_PatternExample_Instances);
            if (exampleInstances != null)
            {
                foreach (var example in exampleInstances.Example)
                {
                    result = example.Items != null ? example.Items.Select(i => i.ToString()).ToList() :
                             example.Text != null ? example.Text.Select(i => i.ToString()).ToList() :
                             new List<string>();
                }
            }
            return result;
        }

        private List<TaxonomyMapping> FillTaxonomyMappings(Attack_Pattern_CatalogAttack_Pattern pattern)
        {
            var result = new List<TaxonomyMapping>();
            var taxonomyMappings = (pattern.Items[GetIndexByType(pattern, ItemsChoiceType.Taxonomy_Mappings)] as Attack_Pattern_CatalogAttack_PatternTaxonomy_Mappings);
            if (taxonomyMappings != null)
            {
                foreach (var taxMapping in taxonomyMappings.Taxonomy_Mapping)
                {
                    result.Add(new TaxonomyMapping
                    {
                        Name = taxMapping.Taxonomy_Name != null ? taxMapping.Taxonomy_Name : string.Empty,
                        EntryId = Convert.ToString(taxMapping.Entry_ID),
                        EntryName = taxMapping.Entry_Name != null ? taxMapping.Entry_Name : string.Empty
                    });
                }
            }
            return result;
        }

        private List<string> FillCwe(Attack_Pattern_CatalogAttack_Pattern pattern)
        {
            var result = new List<string>();
            var cwes = (pattern.Items[GetIndexByType(pattern, ItemsChoiceType.Related_Weaknesses)] as Attack_Pattern_CatalogAttack_PatternRelated_Weaknesses);
            if (cwes != null)
            {
                foreach (var cwe in cwes.Related_Weakness)
                {
                    result.Add("CWE-"+cwe.CWE_ID.ToString());
                }
            }
            return result;
        }

        private ContentHistory FillContentHistory(Attack_Pattern_CatalogAttack_Pattern pattern)
        {
            var result = new ContentHistory();
            result.Modifications = new List<ContentHistoryModification>();
            var contentHistory = (pattern.Items[GetIndexByType(pattern, ItemsChoiceType.Content_History)] as Attack_Pattern_CatalogAttack_PatternContent_History);
            if (contentHistory != null)
            {
                if (contentHistory.Modification != null)
                {
                    foreach (var modification in contentHistory.Modification)
                    {
                        result.Modifications.Add(new ContentHistoryModification
                        {
                            Name = modification.Modification_Name,
                            Organization = modification.Modification_Organization,
                            Date = modification.Modification_Date,
                            Comment = modification.Modification_Comment
                        });
                    }
                }

                if (contentHistory.Submission != null)
                {
                    result.Submission = new ContentHistorySubmission() 
                    {
                        Name = contentHistory.Submission.Submission_Name,
                        Date = contentHistory.Submission.Submission_Date,
                        Organization = contentHistory.Submission.Submission_Organization
                    };

                }
            }
            return result;
        }
    }
}
