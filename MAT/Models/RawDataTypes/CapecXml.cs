using System;

namespace CognitiveMaps.MAT.Models.RawDataTypes.CapecXml
{
    
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://capec.mitre.org/capec-3", IncludeInSchema = false)]
    public enum ItemsChoiceType
    {
        /// <remarks/>
        Alternate_Terms,

        /// <remarks/>
        Consequences,

        /// <remarks/>
        Content_History,

        /// <remarks/>
        Description,

        /// <remarks/>
        Example_Instances,

        /// <remarks/>
        Execution_Flow,

        /// <remarks/>
        Indicators,

        /// <remarks/>
        Likelihood_Of_Attack,

        /// <remarks/>
        Mitigations,

        /// <remarks/>
        Notes,

        /// <remarks/>
        Prerequisites,

        /// <remarks/>
        References,

        /// <remarks/>
        Related_Attack_Patterns,

        /// <remarks/>
        Related_Weaknesses,

        /// <remarks/>
        Resources_Required,

        /// <remarks/>
        Skills_Required,

        /// <remarks/>
        Taxonomy_Mappings,

        /// <remarks/>
        Typical_Severity,
    }





    /// <summary>
    /// Классы описывающие структуру CapecXML
    /// </summary>



    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://capec.mitre.org/capec-3")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://capec.mitre.org/capec-3", IsNullable = false)]
    public partial class Attack_Pattern_Catalog
    {
        private Attack_Pattern_CatalogAttack_Pattern[] attack_PatternsField;

        private Attack_Pattern_CatalogCategory[] categoriesField;

        private System.DateTime dateField;
        private Attack_Pattern_CatalogExternal_Reference[] external_ReferencesField;
        private string nameField;
        private decimal versionField;
        private Attack_Pattern_CatalogViews viewsField;
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Attack_Pattern", IsNullable = false)]
        public Attack_Pattern_CatalogAttack_Pattern[] Attack_Patterns
        {
            get => attack_PatternsField;
            set => attack_PatternsField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Category", IsNullable = false)]
        public Attack_Pattern_CatalogCategory[] Categories
        {
            get
            {
                return this.categoriesField;
            }
            set
            {
                this.categoriesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime Date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("External_Reference", IsNullable = false)]
        public Attack_Pattern_CatalogExternal_Reference[] External_References
        {
            get
            {
                return this.external_ReferencesField;
            }
            set
            {
                this.external_ReferencesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        public Attack_Pattern_CatalogViews Views
        {
            get
            {
                return this.viewsField;
            }
            set
            {
                this.viewsField = value;
            }
        } }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://capec.mitre.org/capec-3")]
    public partial class Attack_Pattern_CatalogAttack_Pattern
    {
        private string abstractionField;
        private ushort idField;
        private ItemsChoiceType[] itemsElementNameField;
        private object[] itemsField;
        private string nameField;
        private string statusField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Abstraction
        {
            get
            {
                return this.abstractionField;
            }
            set
            {
                this.abstractionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Alternate_Terms", typeof(Attack_Pattern_CatalogAttack_PatternAlternate_Terms))]
        [System.Xml.Serialization.XmlElementAttribute("Consequences", typeof(Attack_Pattern_CatalogAttack_PatternConsequences))]
        [System.Xml.Serialization.XmlElementAttribute("Content_History", typeof(Attack_Pattern_CatalogAttack_PatternContent_History))]
        [System.Xml.Serialization.XmlElementAttribute("Description", typeof(Attack_Pattern_CatalogAttack_PatternDescription))]
        [System.Xml.Serialization.XmlElementAttribute("Example_Instances", typeof(Attack_Pattern_CatalogAttack_PatternExample_Instances))]
        [System.Xml.Serialization.XmlElementAttribute("Execution_Flow", typeof(Attack_Pattern_CatalogAttack_PatternExecution_Flow))]
        [System.Xml.Serialization.XmlElementAttribute("Indicators", typeof(Attack_Pattern_CatalogAttack_PatternIndicators))]
        [System.Xml.Serialization.XmlElementAttribute("Likelihood_Of_Attack", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("Mitigations", typeof(Attack_Pattern_CatalogAttack_PatternMitigations))]
        [System.Xml.Serialization.XmlElementAttribute("Notes", typeof(Attack_Pattern_CatalogAttack_PatternNotes))]
        [System.Xml.Serialization.XmlElementAttribute("Prerequisites", typeof(Attack_Pattern_CatalogAttack_PatternPrerequisites))]
        [System.Xml.Serialization.XmlElementAttribute("References", typeof(Attack_Pattern_CatalogAttack_PatternReferences))]
        [System.Xml.Serialization.XmlElementAttribute("Related_Attack_Patterns", typeof(Attack_Pattern_CatalogAttack_PatternRelated_Attack_Patterns))]
        [System.Xml.Serialization.XmlElementAttribute("Related_Weaknesses", typeof(Attack_Pattern_CatalogAttack_PatternRelated_Weaknesses))]
        [System.Xml.Serialization.XmlElementAttribute("Resources_Required", typeof(Attack_Pattern_CatalogAttack_PatternResources_Required))]
        [System.Xml.Serialization.XmlElementAttribute("Skills_Required", typeof(Attack_Pattern_CatalogAttack_PatternSkills_Required))]
        [System.Xml.Serialization.XmlElementAttribute("Taxonomy_Mappings", typeof(Attack_Pattern_CatalogAttack_PatternTaxonomy_Mappings))]
        [System.Xml.Serialization.XmlElementAttribute("Typical_Severity", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://capec.mitre.org/capec-3")]
    public partial class Attack_Pattern_CatalogAttack_PatternAlternate_Terms
    {
        private Attack_Pattern_CatalogAttack_PatternAlternate_TermsAlternate_Term[] alternate_TermField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Alternate_Term")]
        public Attack_Pattern_CatalogAttack_PatternAlternate_TermsAlternate_Term[] Alternate_Term
        {
            get
            {
                return this.alternate_TermField;
            }
            set
            {
                this.alternate_TermField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://capec.mitre.org/capec-3")]
    public partial class Attack_Pattern_CatalogAttack_PatternAlternate_TermsAlternate_Term
    {
        private string termField;

        /// <remarks/>
        public string Term
        {
            get
            {
                return this.termField;
            }
            set
            {
                this.termField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://capec.mitre.org/capec-3")]
    public partial class Attack_Pattern_CatalogAttack_PatternConsequences
    {
        private Attack_Pattern_CatalogAttack_PatternConsequencesConsequence[] consequenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Consequence")]
        public Attack_Pattern_CatalogAttack_PatternConsequencesConsequence[] Consequence
        {
            get
            {
                return this.consequenceField;
            }
            set
            {
                this.consequenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://capec.mitre.org/capec-3")]
    public partial class Attack_Pattern_CatalogAttack_PatternConsequencesConsequence
    {
        private string[] impactField;
        private string likelihoodField;
        private string noteField;
        private string[] scopeField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Impact")]
        public string[] Impact
        {
            get
            {
                return this.impactField;
            }
            set
            {
                this.impactField = value;
            }
        }

        /// <remarks/>
        public string Likelihood
        {
            get
            {
                return this.likelihoodField;
            }
            set
            {
                this.likelihoodField = value;
            }
        }

        /// <remarks/>
        public string Note
        {
            get
            {
                return this.noteField;
            }
            set
            {
                this.noteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Scope")]
        public string[] Scope
        {
            get
            {
                return this.scopeField;
            }
            set
            {
                this.scopeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://capec.mitre.org/capec-3")]
    public partial class Attack_Pattern_CatalogAttack_PatternContent_History
    {
        private Attack_Pattern_CatalogAttack_PatternContent_HistoryModification[] modificationField;
        private Attack_Pattern_CatalogAttack_PatternContent_HistoryPrevious_Entry_Name[] previous_Entry_NameField;
        private Attack_Pattern_CatalogAttack_PatternContent_HistorySubmission submissionField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Modification")]
        public Attack_Pattern_CatalogAttack_PatternContent_HistoryModification[] Modification
        {
            get
            {
                return this.modificationField;
            }
            set
            {
                this.modificationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Previous_Entry_Name")]
        public Attack_Pattern_CatalogAttack_PatternContent_HistoryPrevious_Entry_Name[] Previous_Entry_Name
        {
            get
            {
                return this.previous_Entry_NameField;
            }
            set
            {
                this.previous_Entry_NameField = value;
            }
        }

        /// <remarks/>
        public Attack_Pattern_CatalogAttack_PatternContent_HistorySubmission Submission
        {
            get
            {
                return this.submissionField;
            }
            set
            {
                this.submissionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://capec.mitre.org/capec-3")]
    public partial class Attack_Pattern_CatalogAttack_PatternContent_HistoryModification
    {
        private string modification_CommentField;
        private System.DateTime modification_DateField;
        private string modification_NameField;

        private string modification_OrganizationField;
        /// <remarks/>
        public string Modification_Comment
        {
            get
            {
                return this.modification_CommentField;
            }
            set
            {
                this.modification_CommentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime Modification_Date
        {
            get
            {
                return this.modification_DateField;
            }
            set
            {
                this.modification_DateField = value;
            }
        }

        /// <remarks/>
        public string Modification_Name
        {
            get
            {
                return this.modification_NameField;
            }
            set
            {
                this.modification_NameField = value;
            }
        }

        /// <remarks/>
        public string Modification_Organization
        {
            get
            {
                return this.modification_OrganizationField;
            }
            set
            {
                this.modification_OrganizationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://capec.mitre.org/capec-3")]
    public partial class Attack_Pattern_CatalogAttack_PatternContent_HistoryPrevious_Entry_Name
    {
        private System.DateTime dateField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime Date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://capec.mitre.org/capec-3")]
    public partial class Attack_Pattern_CatalogAttack_PatternContent_HistorySubmission
    {
        private System.DateTime submission_DateField;
        private string submission_NameField;

        private string submission_OrganizationField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime Submission_Date
        {
            get
            {
                return this.submission_DateField;
            }
            set
            {
                this.submission_DateField = value;
            }
        }

        /// <remarks/>
        public string Submission_Name
        {
            get
            {
                return this.submission_NameField;
            }
            set
            {
                this.submission_NameField = value;
            }
        }

        /// <remarks/>
        public string Submission_Organization
        {
            get
            {
                return this.submission_OrganizationField;
            }
            set
            {
                this.submission_OrganizationField = value;
            }
        }
    }
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://capec.mitre.org/capec-3")]
    public partial class Attack_Pattern_CatalogAttack_PatternDescription
    {
        private string[] pField;

        private string[] textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("p", Namespace = "http://www.w3.org/1999/xhtml")]
        public string[] p
        {
            get
            {
                return this.pField;
            }
            set
            {
                this.pField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://capec.mitre.org/capec-3")]
    public partial class Attack_Pattern_CatalogAttack_PatternExample_Instances
    {
        private Attack_Pattern_CatalogAttack_PatternExample_InstancesExample[] exampleField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Example")]
        public Attack_Pattern_CatalogAttack_PatternExample_InstancesExample[] Example
        {
            get
            {
                return this.exampleField;
            }
            set
            {
                this.exampleField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://capec.mitre.org/capec-3")]
    public partial class Attack_Pattern_CatalogAttack_PatternExample_InstancesExample
    {
        private object[] itemsField;

        private string[] textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("div", typeof(div), Namespace = "http://www.w3.org/1999/xhtml")]
        [System.Xml.Serialization.XmlElementAttribute("p", typeof(string), Namespace = "http://www.w3.org/1999/xhtml")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://capec.mitre.org/capec-3")]
    public partial class Attack_Pattern_CatalogAttack_PatternExecution_Flow
    {
        private Attack_Pattern_CatalogAttack_PatternExecution_FlowAttack_Step[] attack_StepField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Attack_Step")]
        public Attack_Pattern_CatalogAttack_PatternExecution_FlowAttack_Step[] Attack_Step
        {
            get
            {
                return this.attack_StepField;
            }
            set
            {
                this.attack_StepField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://capec.mitre.org/capec-3")]
    public partial class Attack_Pattern_CatalogAttack_PatternExecution_FlowAttack_Step
    {
        private Attack_Pattern_CatalogAttack_PatternExecution_FlowAttack_StepDescription descriptionField;
        private string phaseField;
        private byte stepField;
        private Attack_Pattern_CatalogAttack_PatternExecution_FlowAttack_StepTechnique[] techniqueField;

        /// <remarks/>
        public Attack_Pattern_CatalogAttack_PatternExecution_FlowAttack_StepDescription Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public string Phase
        {
            get
            {
                return this.phaseField;
            }
            set
            {
                this.phaseField = value;
            }
        }

        /// <remarks/>
        public byte Step
        {
            get
            {
                return this.stepField;
            }
            set
            {
                this.stepField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Technique")]
        public Attack_Pattern_CatalogAttack_PatternExecution_FlowAttack_StepTechnique[] Technique
        {
            get
            {
                return this.techniqueField;
            }
            set
            {
                this.techniqueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://capec.mitre.org/capec-3")]
    public partial class Attack_Pattern_CatalogAttack_PatternExecution_FlowAttack_StepDescription
    {
        private object[] itemsField;

        private string[] textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("div", typeof(div), Namespace = "http://www.w3.org/1999/xhtml")]
        [System.Xml.Serialization.XmlElementAttribute("p", typeof(string), Namespace = "http://www.w3.org/1999/xhtml")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://capec.mitre.org/capec-3")]
    public partial class Attack_Pattern_CatalogAttack_PatternExecution_FlowAttack_StepTechnique
    {
        private object[] itemsField;

        private string[] textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("div", typeof(div), Namespace = "http://www.w3.org/1999/xhtml")]
        [System.Xml.Serialization.XmlElementAttribute("p", typeof(string), Namespace = "http://www.w3.org/1999/xhtml")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://capec.mitre.org/capec-3")]
    public partial class Attack_Pattern_CatalogAttack_PatternIndicators
    {
        private string[] indicatorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Indicator")]
        public string[] Indicator
        {
            get
            {
                return this.indicatorField;
            }
            set
            {
                this.indicatorField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://capec.mitre.org/capec-3")]
    public partial class Attack_Pattern_CatalogAttack_PatternMitigations
    {
        private Attack_Pattern_CatalogAttack_PatternMitigationsMitigation[] mitigationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Mitigation")]
        public Attack_Pattern_CatalogAttack_PatternMitigationsMitigation[] Mitigation
        {
            get
            {
                return this.mitigationField;
            }
            set
            {
                this.mitigationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://capec.mitre.org/capec-3")]
    public partial class Attack_Pattern_CatalogAttack_PatternMitigationsMitigation
    {
        private object[] itemsField;

        private string[] textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("div", typeof(div), Namespace = "http://www.w3.org/1999/xhtml")]
        [System.Xml.Serialization.XmlElementAttribute("p", typeof(string), Namespace = "http://www.w3.org/1999/xhtml")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://capec.mitre.org/capec-3")]
    public partial class Attack_Pattern_CatalogAttack_PatternNotes
    {
        private Attack_Pattern_CatalogAttack_PatternNotesNote[] noteField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Note")]
        public Attack_Pattern_CatalogAttack_PatternNotesNote[] Note
        {
            get
            {
                return this.noteField;
            }
            set
            {
                this.noteField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://capec.mitre.org/capec-3")]
    public partial class Attack_Pattern_CatalogAttack_PatternNotesNote
    {
        private string[] pField;

        private string[] textField;

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("p", Namespace = "http://www.w3.org/1999/xhtml")]
        public string[] p
        {
            get
            {
                return this.pField;
            }
            set
            {
                this.pField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://capec.mitre.org/capec-3")]
    public partial class Attack_Pattern_CatalogAttack_PatternPrerequisites
    {
        private string[] prerequisiteField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Prerequisite")]
        public string[] Prerequisite
        {
            get
            {
                return this.prerequisiteField;
            }
            set
            {
                this.prerequisiteField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://capec.mitre.org/capec-3")]
    public partial class Attack_Pattern_CatalogAttack_PatternReferences
    {
        private Attack_Pattern_CatalogAttack_PatternReferencesReference[] referenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Reference")]
        public Attack_Pattern_CatalogAttack_PatternReferencesReference[] Reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://capec.mitre.org/capec-3")]
    public partial class Attack_Pattern_CatalogAttack_PatternReferencesReference
    {
        private string external_Reference_IDField;

        private string sectionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string External_Reference_ID
        {
            get
            {
                return this.external_Reference_IDField;
            }
            set
            {
                this.external_Reference_IDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Section
        {
            get
            {
                return this.sectionField;
            }
            set
            {
                this.sectionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://capec.mitre.org/capec-3")]
    public partial class Attack_Pattern_CatalogAttack_PatternRelated_Attack_Patterns
    {
        private Attack_Pattern_CatalogAttack_PatternRelated_Attack_PatternsRelated_Attack_Pattern[] related_Attack_PatternField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Related_Attack_Pattern")]
        public Attack_Pattern_CatalogAttack_PatternRelated_Attack_PatternsRelated_Attack_Pattern[] Related_Attack_Pattern
        {
            get
            {
                return this.related_Attack_PatternField;
            }
            set
            {
                this.related_Attack_PatternField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://capec.mitre.org/capec-3")]
    public partial class Attack_Pattern_CatalogAttack_PatternRelated_Attack_PatternsRelated_Attack_Pattern
    {
        private ushort cAPEC_IDField;
        private Attack_Pattern_CatalogAttack_PatternRelated_Attack_PatternsRelated_Attack_PatternExclude_Related[] exclude_RelatedField;

        private string natureField;
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort CAPEC_ID
        {
            get
            {
                return this.cAPEC_IDField;
            }
            set
            {
                this.cAPEC_IDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Exclude_Related")]
        public Attack_Pattern_CatalogAttack_PatternRelated_Attack_PatternsRelated_Attack_PatternExclude_Related[] Exclude_Related
        {
            get
            {
                return this.exclude_RelatedField;
            }
            set
            {
                this.exclude_RelatedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Nature
        {
            get
            {
                return this.natureField;
            }
            set
            {
                this.natureField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://capec.mitre.org/capec-3")]
    public partial class Attack_Pattern_CatalogAttack_PatternRelated_Attack_PatternsRelated_Attack_PatternExclude_Related
    {
        private ushort exclude_IDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort Exclude_ID
        {
            get
            {
                return this.exclude_IDField;
            }
            set
            {
                this.exclude_IDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://capec.mitre.org/capec-3")]
    public partial class Attack_Pattern_CatalogAttack_PatternRelated_Weaknesses
    {
        private Attack_Pattern_CatalogAttack_PatternRelated_WeaknessesRelated_Weakness[] related_WeaknessField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Related_Weakness")]
        public Attack_Pattern_CatalogAttack_PatternRelated_WeaknessesRelated_Weakness[] Related_Weakness
        {
            get
            {
                return this.related_WeaknessField;
            }
            set
            {
                this.related_WeaknessField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://capec.mitre.org/capec-3")]
    public partial class Attack_Pattern_CatalogAttack_PatternRelated_WeaknessesRelated_Weakness
    {
        private ushort cWE_IDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort CWE_ID
        {
            get
            {
                return this.cWE_IDField;
            }
            set
            {
                this.cWE_IDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://capec.mitre.org/capec-3")]
    public partial class Attack_Pattern_CatalogAttack_PatternResources_Required
    {
        private Attack_Pattern_CatalogAttack_PatternResources_RequiredResource[] resourceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Resource")]
        public Attack_Pattern_CatalogAttack_PatternResources_RequiredResource[] Resource
        {
            get
            {
                return this.resourceField;
            }
            set
            {
                this.resourceField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://capec.mitre.org/capec-3")]
    public partial class Attack_Pattern_CatalogAttack_PatternResources_RequiredResource
    {
        private string[] pField;

        private string[] textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("p", Namespace = "http://www.w3.org/1999/xhtml")]
        public string[] p
        {
            get
            {
                return this.pField;
            }
            set
            {
                this.pField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://capec.mitre.org/capec-3")]
    public partial class Attack_Pattern_CatalogAttack_PatternSkills_Required
    {
        private Attack_Pattern_CatalogAttack_PatternSkills_RequiredSkill[] skillField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Skill")]
        public Attack_Pattern_CatalogAttack_PatternSkills_RequiredSkill[] Skill
        {
            get
            {
                return this.skillField;
            }
            set
            {
                this.skillField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://capec.mitre.org/capec-3")]
    public partial class Attack_Pattern_CatalogAttack_PatternSkills_RequiredSkill
    {
        private string levelField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Level
        {
            get
            {
                return this.levelField;
            }
            set
            {
                this.levelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://capec.mitre.org/capec-3")]
    public partial class Attack_Pattern_CatalogAttack_PatternTaxonomy_Mappings
    {
        private Attack_Pattern_CatalogAttack_PatternTaxonomy_MappingsTaxonomy_Mapping[] taxonomy_MappingField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Taxonomy_Mapping")]
        public Attack_Pattern_CatalogAttack_PatternTaxonomy_MappingsTaxonomy_Mapping[] Taxonomy_Mapping
        {
            get
            {
                return this.taxonomy_MappingField;
            }
            set
            {
                this.taxonomy_MappingField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://capec.mitre.org/capec-3")]
    public partial class Attack_Pattern_CatalogAttack_PatternTaxonomy_MappingsTaxonomy_Mapping
    {
        private decimal entry_IDField;

        private bool entry_IDFieldSpecified;

        private string entry_NameField;

        private string taxonomy_NameField;

        /// <remarks/>
        public decimal Entry_ID
        {
            get
            {
                return this.entry_IDField;
            }
            set
            {
                this.entry_IDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Entry_IDSpecified
        {
            get
            {
                return this.entry_IDFieldSpecified;
            }
            set
            {
                this.entry_IDFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string Entry_Name
        {
            get
            {
                return this.entry_NameField;
            }
            set
            {
                this.entry_NameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Taxonomy_Name
        {
            get
            {
                return this.taxonomy_NameField;
            }
            set
            {
                this.taxonomy_NameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://capec.mitre.org/capec-3")]
    public partial class Attack_Pattern_CatalogCategory
    {
        private Attack_Pattern_CatalogCategoryContent_History content_HistoryField;
        private ushort idField;
        private string nameField;
        private Attack_Pattern_CatalogCategoryHas_Member[] relationshipsField;
        private string statusField;
        private string summaryField;
        private Attack_Pattern_CatalogCategoryTaxonomy_Mappings taxonomy_MappingsField;
        /// <remarks/>
        public Attack_Pattern_CatalogCategoryContent_History Content_History
        {
            get
            {
                return this.content_HistoryField;
            }
            set
            {
                this.content_HistoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Has_Member", IsNullable = false)]
        public Attack_Pattern_CatalogCategoryHas_Member[] Relationships
        {
            get
            {
                return this.relationshipsField;
            }
            set
            {
                this.relationshipsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        public string Summary
        {
            get
            {
                return this.summaryField;
            }
            set
            {
                this.summaryField = value;
            }
        }
        /// <remarks/>
        public Attack_Pattern_CatalogCategoryTaxonomy_Mappings Taxonomy_Mappings
        {
            get
            {
                return this.taxonomy_MappingsField;
            }
            set
            {
                this.taxonomy_MappingsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://capec.mitre.org/capec-3")]
    public partial class Attack_Pattern_CatalogCategoryContent_History
    {
        private Attack_Pattern_CatalogCategoryContent_HistoryModification[] modificationField;
        private Attack_Pattern_CatalogCategoryContent_HistoryPrevious_Entry_Name previous_Entry_NameField;
        private Attack_Pattern_CatalogCategoryContent_HistorySubmission submissionField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Modification")]
        public Attack_Pattern_CatalogCategoryContent_HistoryModification[] Modification
        {
            get
            {
                return this.modificationField;
            }
            set
            {
                this.modificationField = value;
            }
        }

        /// <remarks/>
        public Attack_Pattern_CatalogCategoryContent_HistoryPrevious_Entry_Name Previous_Entry_Name
        {
            get
            {
                return this.previous_Entry_NameField;
            }
            set
            {
                this.previous_Entry_NameField = value;
            }
        }

        /// <remarks/>
        public Attack_Pattern_CatalogCategoryContent_HistorySubmission Submission
        {
            get
            {
                return this.submissionField;
            }
            set
            {
                this.submissionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://capec.mitre.org/capec-3")]
    public partial class Attack_Pattern_CatalogCategoryContent_HistoryModification
    {
        private string modification_CommentField;
        private System.DateTime modification_DateField;
        private string modification_NameField;

        private string modification_OrganizationField;
        /// <remarks/>
        public string Modification_Comment
        {
            get
            {
                return this.modification_CommentField;
            }
            set
            {
                this.modification_CommentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime Modification_Date
        {
            get
            {
                return this.modification_DateField;
            }
            set
            {
                this.modification_DateField = value;
            }
        }

        /// <remarks/>
        public string Modification_Name
        {
            get
            {
                return this.modification_NameField;
            }
            set
            {
                this.modification_NameField = value;
            }
        }

        /// <remarks/>
        public string Modification_Organization
        {
            get
            {
                return this.modification_OrganizationField;
            }
            set
            {
                this.modification_OrganizationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://capec.mitre.org/capec-3")]
    public partial class Attack_Pattern_CatalogCategoryContent_HistoryPrevious_Entry_Name
    {
        private System.DateTime dateField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime Date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://capec.mitre.org/capec-3")]
    public partial class Attack_Pattern_CatalogCategoryContent_HistorySubmission
    {
        private System.DateTime submission_DateField;
        private string submission_NameField;

        private string submission_OrganizationField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime Submission_Date
        {
            get
            {
                return this.submission_DateField;
            }
            set
            {
                this.submission_DateField = value;
            }
        }

        /// <remarks/>
        public string Submission_Name
        {
            get
            {
                return this.submission_NameField;
            }
            set
            {
                this.submission_NameField = value;
            }
        }

        /// <remarks/>
        public string Submission_Organization
        {
            get
            {
                return this.submission_OrganizationField;
            }
            set
            {
                this.submission_OrganizationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://capec.mitre.org/capec-3")]
    public partial class Attack_Pattern_CatalogCategoryHas_Member
    {
        private ushort cAPEC_IDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort CAPEC_ID
        {
            get
            {
                return this.cAPEC_IDField;
            }
            set
            {
                this.cAPEC_IDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://capec.mitre.org/capec-3")]
    public partial class Attack_Pattern_CatalogCategoryTaxonomy_Mappings
    {
        private Attack_Pattern_CatalogCategoryTaxonomy_MappingsTaxonomy_Mapping taxonomy_MappingField;

        /// <remarks/>
        public Attack_Pattern_CatalogCategoryTaxonomy_MappingsTaxonomy_Mapping Taxonomy_Mapping
        {
            get
            {
                return this.taxonomy_MappingField;
            }
            set
            {
                this.taxonomy_MappingField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://capec.mitre.org/capec-3")]
    public partial class Attack_Pattern_CatalogCategoryTaxonomy_MappingsTaxonomy_Mapping
    {
        private byte entry_IDField;

        private string entry_NameField;

        private string taxonomy_NameField;

        /// <remarks/>
        public byte Entry_ID
        {
            get
            {
                return this.entry_IDField;
            }
            set
            {
                this.entry_IDField = value;
            }
        }

        /// <remarks/>
        public string Entry_Name
        {
            get
            {
                return this.entry_NameField;
            }
            set
            {
                this.entry_NameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Taxonomy_Name
        {
            get
            {
                return this.taxonomy_NameField;
            }
            set
            {
                this.taxonomy_NameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://capec.mitre.org/capec-3")]
    public partial class Attack_Pattern_CatalogExternal_Reference
    {
        private string[] authorField;

        private string editionField;
        private string publication_DayField;
        private string publication_MonthField;
        private ushort publication_YearField;
        private bool publication_YearFieldSpecified;
        private string publicationField;
        private string publisherField;
        private string reference_IDField;
        private string titleField;
        private System.DateTime uRL_DateField;
        private bool uRL_DateFieldSpecified;
        private string uRLField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Author")]
        public string[] Author
        {
            get
            {
                return this.authorField;
            }
            set
            {
                this.authorField = value;
            }
        }

        /// <remarks/>
        public string Edition
        {
            get
            {
                return this.editionField;
            }
            set
            {
                this.editionField = value;
            }
        }

        /// <remarks/>
        public string Publication
        {
            get
            {
                return this.publicationField;
            }
            set
            {
                this.publicationField = value;
            }
        }

        /// <remarks/>
        public string Publication_Day
        {
            get
            {
                return this.publication_DayField;
            }
            set
            {
                this.publication_DayField = value;
            }
        }

        /// <remarks/>
        public string Publication_Month
        {
            get
            {
                return this.publication_MonthField;
            }
            set
            {
                this.publication_MonthField = value;
            }
        }

        /// <remarks/>
        public ushort Publication_Year
        {
            get
            {
                return this.publication_YearField;
            }
            set
            {
                this.publication_YearField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Publication_YearSpecified
        {
            get
            {
                return this.publication_YearFieldSpecified;
            }
            set
            {
                this.publication_YearFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string Publisher
        {
            get
            {
                return this.publisherField;
            }
            set
            {
                this.publisherField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Reference_ID
        {
            get
            {
                return this.reference_IDField;
            }
            set
            {
                this.reference_IDField = value;
            }
        }

        /// <remarks/>
        public string Title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }
        /// <remarks/>
        public string URL
        {
            get
            {
                return this.uRLField;
            }
            set
            {
                this.uRLField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime URL_Date
        {
            get
            {
                return this.uRL_DateField;
            }
            set
            {
                this.uRL_DateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool URL_DateSpecified
        {
            get
            {
                return this.uRL_DateFieldSpecified;
            }
            set
            {
                this.uRL_DateFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://capec.mitre.org/capec-3")]
    public partial class Attack_Pattern_CatalogViews
    {
        private Attack_Pattern_CatalogViewsView viewField;

        /// <remarks/>
        public Attack_Pattern_CatalogViewsView View
        {
            get
            {
                return this.viewField;
            }
            set
            {
                this.viewField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://capec.mitre.org/capec-3")]
    public partial class Attack_Pattern_CatalogViewsView
    {
        private Attack_Pattern_CatalogViewsViewContent_History content_HistoryField;
        private ushort idField;
        private Attack_Pattern_CatalogViewsViewHas_Member[] membersField;
        private string nameField;
        private string objectiveField;
        private string statusField;
        private string typeField;
        /// <remarks/>
        public Attack_Pattern_CatalogViewsViewContent_History Content_History
        {
            get
            {
                return this.content_HistoryField;
            }
            set
            {
                this.content_HistoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Has_Member", IsNullable = false)]
        public Attack_Pattern_CatalogViewsViewHas_Member[] Members
        {
            get
            {
                return this.membersField;
            }
            set
            {
                this.membersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string Objective
        {
            get
            {
                return this.objectiveField;
            }
            set
            {
                this.objectiveField = value;
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://capec.mitre.org/capec-3")]
    public partial class Attack_Pattern_CatalogViewsViewContent_History
    {
        private Attack_Pattern_CatalogViewsViewContent_HistoryModification[] modificationField;
        private Attack_Pattern_CatalogViewsViewContent_HistorySubmission submissionField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Modification")]
        public Attack_Pattern_CatalogViewsViewContent_HistoryModification[] Modification
        {
            get
            {
                return this.modificationField;
            }
            set
            {
                this.modificationField = value;
            }
        }

        /// <remarks/>
        public Attack_Pattern_CatalogViewsViewContent_HistorySubmission Submission
        {
            get
            {
                return this.submissionField;
            }
            set
            {
                this.submissionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://capec.mitre.org/capec-3")]
    public partial class Attack_Pattern_CatalogViewsViewContent_HistoryModification
    {
        private string modification_CommentField;
        private System.DateTime modification_DateField;
        private string modification_NameField;

        private string modification_OrganizationField;
        /// <remarks/>
        public string Modification_Comment
        {
            get
            {
                return this.modification_CommentField;
            }
            set
            {
                this.modification_CommentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime Modification_Date
        {
            get
            {
                return this.modification_DateField;
            }
            set
            {
                this.modification_DateField = value;
            }
        }

        /// <remarks/>
        public string Modification_Name
        {
            get
            {
                return this.modification_NameField;
            }
            set
            {
                this.modification_NameField = value;
            }
        }

        /// <remarks/>
        public string Modification_Organization
        {
            get
            {
                return this.modification_OrganizationField;
            }
            set
            {
                this.modification_OrganizationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://capec.mitre.org/capec-3")]
    public partial class Attack_Pattern_CatalogViewsViewContent_HistorySubmission
    {
        private System.DateTime submission_DateField;
        private string submission_NameField;

        private string submission_OrganizationField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime Submission_Date
        {
            get
            {
                return this.submission_DateField;
            }
            set
            {
                this.submission_DateField = value;
            }
        }

        /// <remarks/>
        public string Submission_Name
        {
            get
            {
                return this.submission_NameField;
            }
            set
            {
                this.submission_NameField = value;
            }
        }

        /// <remarks/>
        public string Submission_Organization
        {
            get
            {
                return this.submission_OrganizationField;
            }
            set
            {
                this.submission_OrganizationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://capec.mitre.org/capec-3")]
    public partial class Attack_Pattern_CatalogViewsViewHas_Member
    {
        private ushort cAPEC_IDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort CAPEC_ID
        {
            get
            {
                return this.cAPEC_IDField;
            }
            set
            {
                this.cAPEC_IDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.w3.org/1999/xhtml", IsNullable = false)]
    public partial class div
    {
        private string classField;
        private object[] itemsField;

        private string styleField;
        private string[] textField;
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @class
        {
            get
            {
                return this.classField;
            }
            set
            {
                this.classField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("br", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("div", typeof(divDiv))]
        [System.Xml.Serialization.XmlElementAttribute("ul", typeof(divUL))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string style
        {
            get
            {
                return this.styleField;
            }
            set
            {
                this.styleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
    public partial class divDiv
    {
        private object[] itemsField;

        private string styleField;
        private string[] textField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("br", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("div", typeof(divDivDiv))]
        [System.Xml.Serialization.XmlElementAttribute("i", typeof(string))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string style
        {
            get
            {
                return this.styleField;
            }
            set
            {
                this.styleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
    public partial class divDivDiv
    {
        private object brField;
        private divDivDivDiv divField;
        private string iField;

        private string styleField;
        private string[] textField;
        /// <remarks/>
        public object br
        {
            get
            {
                return this.brField;
            }
            set
            {
                this.brField = value;
            }
        }

        /// <remarks/>
        public divDivDivDiv div
        {
            get
            {
                return this.divField;
            }
            set
            {
                this.divField = value;
            }
        }
        /// <remarks/>
        public string i
        {
            get
            {
                return this.iField;
            }
            set
            {
                this.iField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string style
        {
            get
            {
                return this.styleField;
            }
            set
            {
                this.styleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
    public partial class divDivDivDiv
    {
        private object brField;

        private string iField;

        private string styleField;
        private string[] textField;
        /// <remarks/>
        public object br
        {
            get
            {
                return this.brField;
            }
            set
            {
                this.brField = value;
            }
        }

        /// <remarks/>
        public string i
        {
            get
            {
                return this.iField;
            }
            set
            {
                this.iField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string style
        {
            get
            {
                return this.styleField;
            }
            set
            {
                this.styleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
    public partial class divUL
    {
        private string[] liField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("li")]
        public string[] li
        {
            get
            {
                return this.liField;
            }
            set
            {
                this.liField = value;
            }
        }
    }
}