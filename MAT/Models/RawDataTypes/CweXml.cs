using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CognitiveMaps.MAT.Models.RawDataTypes.CweXml
{
    /// <summary>
    /// Классы описывающие структуру CweXML
    /// </summary>

    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://cwe.mitre.org/cwe-6", IsNullable = false)]
    public partial class Weakness_Catalog
    {

        private Weakness_CatalogWeakness[] weaknessesField;

        private Weakness_CatalogCategory[] categoriesField;

        private Weakness_CatalogView[] viewsField;

        private Weakness_CatalogExternal_Reference[] external_ReferencesField;

        private string nameField;

        private decimal versionField;

        private System.DateTime dateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Weakness", IsNullable = false)]
        public Weakness_CatalogWeakness[] Weaknesses
        {
            get
            {
                return this.weaknessesField;
            }
            set
            {
                this.weaknessesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Category", IsNullable = false)]
        public Weakness_CatalogCategory[] Categories
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
        [System.Xml.Serialization.XmlArrayItemAttribute("View", IsNullable = false)]
        public Weakness_CatalogView[] Views
        {
            get
            {
                return this.viewsField;
            }
            set
            {
                this.viewsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("External_Reference", IsNullable = false)]
        public Weakness_CatalogExternal_Reference[] External_References
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogWeakness
    {

        private object[] itemsField;

        private ItemsChoiceType2[] itemsElementNameField;

        private ushort idField;

        private string nameField;

        private string abstractionField;

        private string structureField;

        private string statusField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Affected_Resources", typeof(Weakness_CatalogWeaknessAffected_Resources))]
        [System.Xml.Serialization.XmlElementAttribute("Alternate_Terms", typeof(Weakness_CatalogWeaknessAlternate_Terms))]
        [System.Xml.Serialization.XmlElementAttribute("Applicable_Platforms", typeof(Weakness_CatalogWeaknessApplicable_Platforms))]
        [System.Xml.Serialization.XmlElementAttribute("Background_Details", typeof(Weakness_CatalogWeaknessBackground_Details))]
        [System.Xml.Serialization.XmlElementAttribute("Common_Consequences", typeof(Weakness_CatalogWeaknessCommon_Consequences))]
        [System.Xml.Serialization.XmlElementAttribute("Content_History", typeof(Weakness_CatalogWeaknessContent_History))]
        [System.Xml.Serialization.XmlElementAttribute("Demonstrative_Examples", typeof(Weakness_CatalogWeaknessDemonstrative_Examples))]
        [System.Xml.Serialization.XmlElementAttribute("Description", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("Detection_Methods", typeof(Weakness_CatalogWeaknessDetection_Methods))]
        [System.Xml.Serialization.XmlElementAttribute("Extended_Description", typeof(Weakness_CatalogWeaknessExtended_Description))]
        [System.Xml.Serialization.XmlElementAttribute("Functional_Areas", typeof(Weakness_CatalogWeaknessFunctional_Areas))]
        [System.Xml.Serialization.XmlElementAttribute("Likelihood_Of_Exploit", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("Modes_Of_Introduction", typeof(Weakness_CatalogWeaknessModes_Of_Introduction))]
        [System.Xml.Serialization.XmlElementAttribute("Notes", typeof(Weakness_CatalogWeaknessNotes))]
        [System.Xml.Serialization.XmlElementAttribute("Observed_Examples", typeof(Weakness_CatalogWeaknessObserved_Examples))]
        [System.Xml.Serialization.XmlElementAttribute("Potential_Mitigations", typeof(Weakness_CatalogWeaknessPotential_Mitigations))]
        [System.Xml.Serialization.XmlElementAttribute("References", typeof(Weakness_CatalogWeaknessReferences))]
        [System.Xml.Serialization.XmlElementAttribute("Related_Attack_Patterns", typeof(Weakness_CatalogWeaknessRelated_Attack_Patterns))]
        [System.Xml.Serialization.XmlElementAttribute("Related_Weaknesses", typeof(Weakness_CatalogWeaknessRelated_Weaknesses))]
        [System.Xml.Serialization.XmlElementAttribute("Taxonomy_Mappings", typeof(Weakness_CatalogWeaknessTaxonomy_Mappings))]
        [System.Xml.Serialization.XmlElementAttribute("Weakness_Ordinalities", typeof(Weakness_CatalogWeaknessWeakness_Ordinalities))]
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
        public ItemsChoiceType2[] ItemsElementName
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
        public string Structure
        {
            get
            {
                return this.structureField;
            }
            set
            {
                this.structureField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogWeaknessAffected_Resources
    {

        private string[] affected_ResourceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Affected_Resource")]
        public string[] Affected_Resource
        {
            get
            {
                return this.affected_ResourceField;
            }
            set
            {
                this.affected_ResourceField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogWeaknessAlternate_Terms
    {

        private Weakness_CatalogWeaknessAlternate_TermsAlternate_Term[] alternate_TermField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Alternate_Term")]
        public Weakness_CatalogWeaknessAlternate_TermsAlternate_Term[] Alternate_Term
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogWeaknessAlternate_TermsAlternate_Term
    {

        private string termField;

        private Weakness_CatalogWeaknessAlternate_TermsAlternate_TermDescription descriptionField;

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

        /// <remarks/>
        public Weakness_CatalogWeaknessAlternate_TermsAlternate_TermDescription Description
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogWeaknessAlternate_TermsAlternate_TermDescription
    {

        private p[] pField;

        private string[] textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("p", Namespace = "http://www.w3.org/1999/xhtml")]
        public p[] p
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.w3.org/1999/xhtml", IsNullable = false)]
    public partial class p
    {

        private string bField;

        private string[] textField;

        private string styleField;

        /// <remarks/>
        public string b
        {
            get
            {
                return this.bField;
            }
            set
            {
                this.bField = value;
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogWeaknessApplicable_Platforms
    {

        private Weakness_CatalogWeaknessApplicable_PlatformsLanguage[] languageField;

        private Weakness_CatalogWeaknessApplicable_PlatformsOperating_System[] operating_SystemField;

        private Weakness_CatalogWeaknessApplicable_PlatformsArchitecture architectureField;

        private Weakness_CatalogWeaknessApplicable_PlatformsTechnology[] technologyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Language")]
        public Weakness_CatalogWeaknessApplicable_PlatformsLanguage[] Language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Operating_System")]
        public Weakness_CatalogWeaknessApplicable_PlatformsOperating_System[] Operating_System
        {
            get
            {
                return this.operating_SystemField;
            }
            set
            {
                this.operating_SystemField = value;
            }
        }

        /// <remarks/>
        public Weakness_CatalogWeaknessApplicable_PlatformsArchitecture Architecture
        {
            get
            {
                return this.architectureField;
            }
            set
            {
                this.architectureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Technology")]
        public Weakness_CatalogWeaknessApplicable_PlatformsTechnology[] Technology
        {
            get
            {
                return this.technologyField;
            }
            set
            {
                this.technologyField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogWeaknessApplicable_PlatformsLanguage
    {

        private string classField;

        private string prevalenceField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Class
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Prevalence
        {
            get
            {
                return this.prevalenceField;
            }
            set
            {
                this.prevalenceField = value;
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogWeaknessApplicable_PlatformsOperating_System
    {

        private string classField;

        private string prevalenceField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Class
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Prevalence
        {
            get
            {
                return this.prevalenceField;
            }
            set
            {
                this.prevalenceField = value;
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogWeaknessApplicable_PlatformsArchitecture
    {

        private string classField;

        private string prevalenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Class
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Prevalence
        {
            get
            {
                return this.prevalenceField;
            }
            set
            {
                this.prevalenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogWeaknessApplicable_PlatformsTechnology
    {

        private string classField;

        private string prevalenceField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Class
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Prevalence
        {
            get
            {
                return this.prevalenceField;
            }
            set
            {
                this.prevalenceField = value;
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogWeaknessBackground_Details
    {

        private Weakness_CatalogWeaknessBackground_DetailsBackground_Detail[] background_DetailField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Background_Detail")]
        public Weakness_CatalogWeaknessBackground_DetailsBackground_Detail[] Background_Detail
        {
            get
            {
                return this.background_DetailField;
            }
            set
            {
                this.background_DetailField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogWeaknessBackground_DetailsBackground_Detail
    {

        private object[] itemsField;

        private string[] textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("div", typeof(div), Namespace = "http://www.w3.org/1999/xhtml")]
        [System.Xml.Serialization.XmlElementAttribute("p", typeof(p), Namespace = "http://www.w3.org/1999/xhtml")]
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.w3.org/1999/xhtml", IsNullable = false)]
    public partial class div
    {

        private object[] itemsField;

        private ItemsChoiceType1[] itemsElementNameField;

        private string[] textField;

        private string styleField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("br", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("div", typeof(divDiv))]
        [System.Xml.Serialization.XmlElementAttribute("i", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("ol", typeof(divOL))]
        [System.Xml.Serialization.XmlElementAttribute("p", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("ul", typeof(divUL))]
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
        public ItemsChoiceType1[] ItemsElementName
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
    public partial class divDiv
    {

        private object[] itemsField;

        private ItemsChoiceType[] itemsElementNameField;

        private string[] textField;

        private string styleField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("b", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("br", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("div", typeof(divDivDiv))]
        [System.Xml.Serialization.XmlElementAttribute("i", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("ul", typeof(divDivUL))]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
    public partial class divDivDiv
    {

        private object[] itemsField;

        private string[] textField;

        private string styleField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("br", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("div", typeof(divDivDivDiv))]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
    public partial class divDivDivDiv
    {

        private object[] itemsField;

        private string[] textField;

        private string styleField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("br", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("div", typeof(divDivDivDivDiv))]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
    public partial class divDivDivDivDiv
    {

        private object[] itemsField;

        private string[] textField;

        private string styleField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("br", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("div", typeof(divDivDivDivDivDiv))]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
    public partial class divDivDivDivDivDiv
    {

        private object[] itemsField;

        private string[] textField;

        private string styleField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("br", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("div", typeof(divDivDivDivDivDivDiv))]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
    public partial class divDivDivDivDivDivDiv
    {

        private object[] itemsField;

        private string[] textField;

        private string styleField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("br", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("div", typeof(divDivDivDivDivDivDivDiv))]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
    public partial class divDivDivDivDivDivDivDiv
    {

        private object[] itemsField;

        private string[] textField;

        private string styleField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("br", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("div", typeof(divDivDivDivDivDivDivDivDiv))]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
    public partial class divDivDivDivDivDivDivDivDiv
    {

        private object[] itemsField;

        private string[] textField;

        private string styleField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("br", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("div", typeof(divDivDivDivDivDivDivDivDivDiv))]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
    public partial class divDivDivDivDivDivDivDivDivDiv
    {

        private divDivDivDivDivDivDivDivDivDivDiv divField;

        private string[] textField;

        private string styleField;

        /// <remarks/>
        public divDivDivDivDivDivDivDivDivDivDiv div
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
    public partial class divDivDivDivDivDivDivDivDivDivDiv
    {

        private object[] brField;

        private string[] textField;

        private string styleField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("br")]
        public object[] br
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
    public partial class divDivUL
    {

        private divDivULLI[] liField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("li")]
        public divDivULLI[] li
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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
    public partial class divDivULLI
    {

        private string divField;

        private string[] textField;

        /// <remarks/>
        public string div
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/1999/xhtml", IncludeInSchema = false)]
    public enum ItemsChoiceType
    {

        /// <remarks/>
        b,

        /// <remarks/>
        br,

        /// <remarks/>
        div,

        /// <remarks/>
        i,

        /// <remarks/>
        ul,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
    public partial class divOL
    {

        private divOLLI[] liField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("li")]
        public divOLLI[] li
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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
    public partial class divOLLI
    {

        private string[] olField;

        private string[] ulField;

        private string[] textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("li", IsNullable = false)]
        public string[] ol
        {
            get
            {
                return this.olField;
            }
            set
            {
                this.olField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("li", IsNullable = false)]
        public string[] ul
        {
            get
            {
                return this.ulField;
            }
            set
            {
                this.ulField = value;
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

        private divULLI[] liField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("li")]
        public divULLI[] li
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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
    public partial class divULLI
    {

        private string bField;

        private string[] textField;

        /// <remarks/>
        public string b
        {
            get
            {
                return this.bField;
            }
            set
            {
                this.bField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/1999/xhtml", IncludeInSchema = false)]
    public enum ItemsChoiceType1
    {

        /// <remarks/>
        br,

        /// <remarks/>
        div,

        /// <remarks/>
        i,

        /// <remarks/>
        ol,

        /// <remarks/>
        p,

        /// <remarks/>
        ul,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogWeaknessCommon_Consequences
    {

        private Weakness_CatalogWeaknessCommon_ConsequencesConsequence[] consequenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Consequence")]
        public Weakness_CatalogWeaknessCommon_ConsequencesConsequence[] Consequence
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogWeaknessCommon_ConsequencesConsequence
    {

        private string[] scopeField;

        private string[] impactField;

        private string likelihoodField;

        private string noteField;

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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogWeaknessContent_History
    {

        private Weakness_CatalogWeaknessContent_HistorySubmission submissionField;

        private Weakness_CatalogWeaknessContent_HistoryModification[] modificationField;

        private Weakness_CatalogWeaknessContent_HistoryContribution contributionField;

        private Weakness_CatalogWeaknessContent_HistoryPrevious_Entry_Name[] previous_Entry_NameField;

        /// <remarks/>
        public Weakness_CatalogWeaknessContent_HistorySubmission Submission
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Modification")]
        public Weakness_CatalogWeaknessContent_HistoryModification[] Modification
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
        public Weakness_CatalogWeaknessContent_HistoryContribution Contribution
        {
            get
            {
                return this.contributionField;
            }
            set
            {
                this.contributionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Previous_Entry_Name")]
        public Weakness_CatalogWeaknessContent_HistoryPrevious_Entry_Name[] Previous_Entry_Name
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogWeaknessContent_HistorySubmission
    {

        private string submission_NameField;

        private string submission_OrganizationField;

        private System.DateTime submission_DateField;

        private string submission_CommentField;

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
        public string Submission_Comment
        {
            get
            {
                return this.submission_CommentField;
            }
            set
            {
                this.submission_CommentField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogWeaknessContent_HistoryModification
    {

        private string modification_NameField;

        private string modification_OrganizationField;

        private System.DateTime modification_DateField;

        private string modification_ImportanceField;

        private string modification_CommentField;

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
        public string Modification_Importance
        {
            get
            {
                return this.modification_ImportanceField;
            }
            set
            {
                this.modification_ImportanceField = value;
            }
        }

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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogWeaknessContent_HistoryContribution
    {

        private string contribution_NameField;

        private string contribution_OrganizationField;

        private System.DateTime contribution_DateField;

        private string contribution_CommentField;

        private string typeField;

        /// <remarks/>
        public string Contribution_Name
        {
            get
            {
                return this.contribution_NameField;
            }
            set
            {
                this.contribution_NameField = value;
            }
        }

        /// <remarks/>
        public string Contribution_Organization
        {
            get
            {
                return this.contribution_OrganizationField;
            }
            set
            {
                this.contribution_OrganizationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime Contribution_Date
        {
            get
            {
                return this.contribution_DateField;
            }
            set
            {
                this.contribution_DateField = value;
            }
        }

        /// <remarks/>
        public string Contribution_Comment
        {
            get
            {
                return this.contribution_CommentField;
            }
            set
            {
                this.contribution_CommentField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogWeaknessContent_HistoryPrevious_Entry_Name
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogWeaknessDemonstrative_Examples
    {

        private Weakness_CatalogWeaknessDemonstrative_ExamplesDemonstrative_Example[] demonstrative_ExampleField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Demonstrative_Example")]
        public Weakness_CatalogWeaknessDemonstrative_ExamplesDemonstrative_Example[] Demonstrative_Example
        {
            get
            {
                return this.demonstrative_ExampleField;
            }
            set
            {
                this.demonstrative_ExampleField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogWeaknessDemonstrative_ExamplesDemonstrative_Example
    {

        private object[] itemsField;

        private string demonstrative_Example_IDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Body_Text", typeof(Weakness_CatalogWeaknessDemonstrative_ExamplesDemonstrative_ExampleBody_Text))]
        [System.Xml.Serialization.XmlElementAttribute("Example_Code", typeof(Weakness_CatalogWeaknessDemonstrative_ExamplesDemonstrative_ExampleExample_Code))]
        [System.Xml.Serialization.XmlElementAttribute("Intro_Text", typeof(Weakness_CatalogWeaknessDemonstrative_ExamplesDemonstrative_ExampleIntro_Text))]
        [System.Xml.Serialization.XmlElementAttribute("References", typeof(Weakness_CatalogWeaknessDemonstrative_ExamplesDemonstrative_ExampleReferences))]
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
        public string Demonstrative_Example_ID
        {
            get
            {
                return this.demonstrative_Example_IDField;
            }
            set
            {
                this.demonstrative_Example_IDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogWeaknessDemonstrative_ExamplesDemonstrative_ExampleBody_Text
    {

        private object[] itemsField;

        private string[] textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("div", typeof(div), Namespace = "http://www.w3.org/1999/xhtml")]
        [System.Xml.Serialization.XmlElementAttribute("ol", typeof(ol), Namespace = "http://www.w3.org/1999/xhtml")]
        [System.Xml.Serialization.XmlElementAttribute("p", typeof(p), Namespace = "http://www.w3.org/1999/xhtml")]
        [System.Xml.Serialization.XmlElementAttribute("table", typeof(table), Namespace = "http://www.w3.org/1999/xhtml")]
        [System.Xml.Serialization.XmlElementAttribute("ul", typeof(ul), Namespace = "http://www.w3.org/1999/xhtml")]
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.w3.org/1999/xhtml", IsNullable = false)]
    public partial class ol
    {

        private olLI[] liField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("li")]
        public olLI[] li
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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
    public partial class olLI
    {

        private string divField;

        private string[] textField;

        /// <remarks/>
        public string div
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
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.w3.org/1999/xhtml", IsNullable = false)]
    public partial class table
    {

        private tableTR[] tbodyField;

        private tableTR1[] trField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("tr", IsNullable = false)]
        public tableTR[] tbody
        {
            get
            {
                return this.tbodyField;
            }
            set
            {
                this.tbodyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tr")]
        public tableTR1[] tr
        {
            get
            {
                return this.trField;
            }
            set
            {
                this.trField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
    public partial class tableTR
    {

        private string[] tdField;

        private string[] thField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("td")]
        public string[] td
        {
            get
            {
                return this.tdField;
            }
            set
            {
                this.tdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("th")]
        public string[] th
        {
            get
            {
                return this.thField;
            }
            set
            {
                this.thField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
    public partial class tableTR1
    {

        private tableTRTD[] tdField;

        private string[] thField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("td")]
        public tableTRTD[] td
        {
            get
            {
                return this.tdField;
            }
            set
            {
                this.tdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("th")]
        public string[] th
        {
            get
            {
                return this.thField;
            }
            set
            {
                this.thField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
    public partial class tableTRTD
    {

        private object[] brField;

        private string[] textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("br")]
        public object[] br
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
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.w3.org/1999/xhtml", IsNullable = false)]
    public partial class ul
    {

        private ulLI[] liField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("li")]
        public ulLI[] li
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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
    public partial class ulLI
    {

        private string bField;

        private string divField;

        private string[] textField;

        /// <remarks/>
        public string b
        {
            get
            {
                return this.bField;
            }
            set
            {
                this.bField = value;
            }
        }

        /// <remarks/>
        public string div
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogWeaknessDemonstrative_ExamplesDemonstrative_ExampleExample_Code
    {

        private object[] itemsField;

        private string[] textField;

        private string natureField;

        private string languageField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("br", typeof(object), Namespace = "http://www.w3.org/1999/xhtml")]
        [System.Xml.Serialization.XmlElementAttribute("div", typeof(div), Namespace = "http://www.w3.org/1999/xhtml")]
        [System.Xml.Serialization.XmlElementAttribute("p", typeof(p), Namespace = "http://www.w3.org/1999/xhtml")]
        [System.Xml.Serialization.XmlElementAttribute("table", typeof(table), Namespace = "http://www.w3.org/1999/xhtml")]
        [System.Xml.Serialization.XmlElementAttribute("ul", typeof(ul), Namespace = "http://www.w3.org/1999/xhtml")]
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogWeaknessDemonstrative_ExamplesDemonstrative_ExampleIntro_Text
    {

        private object[] itemsField;

        private string[] textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("br", typeof(object), Namespace = "http://www.w3.org/1999/xhtml")]
        [System.Xml.Serialization.XmlElementAttribute("div", typeof(div), Namespace = "http://www.w3.org/1999/xhtml")]
        [System.Xml.Serialization.XmlElementAttribute("p", typeof(p), Namespace = "http://www.w3.org/1999/xhtml")]
        [System.Xml.Serialization.XmlElementAttribute("table", typeof(table), Namespace = "http://www.w3.org/1999/xhtml")]
        [System.Xml.Serialization.XmlElementAttribute("ul", typeof(ul), Namespace = "http://www.w3.org/1999/xhtml")]
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogWeaknessDemonstrative_ExamplesDemonstrative_ExampleReferences
    {

        private Weakness_CatalogWeaknessDemonstrative_ExamplesDemonstrative_ExampleReferencesReference referenceField;

        /// <remarks/>
        public Weakness_CatalogWeaknessDemonstrative_ExamplesDemonstrative_ExampleReferencesReference Reference
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogWeaknessDemonstrative_ExamplesDemonstrative_ExampleReferencesReference
    {

        private string external_Reference_IDField;

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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogWeaknessDetection_Methods
    {

        private Weakness_CatalogWeaknessDetection_MethodsDetection_Method[] detection_MethodField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Detection_Method")]
        public Weakness_CatalogWeaknessDetection_MethodsDetection_Method[] Detection_Method
        {
            get
            {
                return this.detection_MethodField;
            }
            set
            {
                this.detection_MethodField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogWeaknessDetection_MethodsDetection_Method
    {

        private string methodField;

        private Weakness_CatalogWeaknessDetection_MethodsDetection_MethodDescription descriptionField;

        private string effectivenessField;

        private string effectiveness_NotesField;

        private string detection_Method_IDField;

        /// <remarks/>
        public string Method
        {
            get
            {
                return this.methodField;
            }
            set
            {
                this.methodField = value;
            }
        }

        /// <remarks/>
        public Weakness_CatalogWeaknessDetection_MethodsDetection_MethodDescription Description
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
        public string Effectiveness
        {
            get
            {
                return this.effectivenessField;
            }
            set
            {
                this.effectivenessField = value;
            }
        }

        /// <remarks/>
        public string Effectiveness_Notes
        {
            get
            {
                return this.effectiveness_NotesField;
            }
            set
            {
                this.effectiveness_NotesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Detection_Method_ID
        {
            get
            {
                return this.detection_Method_IDField;
            }
            set
            {
                this.detection_Method_IDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogWeaknessDetection_MethodsDetection_MethodDescription
    {

        private ol olField;

        private p[] pField;

        private div divField;

        private string[] textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/1999/xhtml")]
        public ol ol
        {
            get
            {
                return this.olField;
            }
            set
            {
                this.olField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("p", Namespace = "http://www.w3.org/1999/xhtml")]
        public p[] p
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/1999/xhtml")]
        public div div
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogWeaknessExtended_Description
    {

        private object[] itemsField;

        private string[] textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("br", typeof(object), Namespace = "http://www.w3.org/1999/xhtml")]
        [System.Xml.Serialization.XmlElementAttribute("div", typeof(div), Namespace = "http://www.w3.org/1999/xhtml")]
        [System.Xml.Serialization.XmlElementAttribute("ol", typeof(ol), Namespace = "http://www.w3.org/1999/xhtml")]
        [System.Xml.Serialization.XmlElementAttribute("p", typeof(p), Namespace = "http://www.w3.org/1999/xhtml")]
        [System.Xml.Serialization.XmlElementAttribute("ul", typeof(ul), Namespace = "http://www.w3.org/1999/xhtml")]
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogWeaknessFunctional_Areas
    {

        private string[] functional_AreaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Functional_Area")]
        public string[] Functional_Area
        {
            get
            {
                return this.functional_AreaField;
            }
            set
            {
                this.functional_AreaField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogWeaknessModes_Of_Introduction
    {

        private Weakness_CatalogWeaknessModes_Of_IntroductionIntroduction[] introductionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Introduction")]
        public Weakness_CatalogWeaknessModes_Of_IntroductionIntroduction[] Introduction
        {
            get
            {
                return this.introductionField;
            }
            set
            {
                this.introductionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogWeaknessModes_Of_IntroductionIntroduction
    {

        private string phaseField;

        private Weakness_CatalogWeaknessModes_Of_IntroductionIntroductionNote noteField;

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
        public Weakness_CatalogWeaknessModes_Of_IntroductionIntroductionNote Note
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogWeaknessModes_Of_IntroductionIntroductionNote
    {

        private p[] pField;

        private div divField;

        private string[] textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("p", Namespace = "http://www.w3.org/1999/xhtml")]
        public p[] p
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/1999/xhtml")]
        public div div
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogWeaknessNotes
    {

        private Weakness_CatalogWeaknessNotesNote[] noteField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Note")]
        public Weakness_CatalogWeaknessNotesNote[] Note
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogWeaknessNotesNote
    {

        private object[] itemsField;

        private string[] textField;

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("div", typeof(div), Namespace = "http://www.w3.org/1999/xhtml")]
        [System.Xml.Serialization.XmlElementAttribute("ol", typeof(ol), Namespace = "http://www.w3.org/1999/xhtml")]
        [System.Xml.Serialization.XmlElementAttribute("p", typeof(p), Namespace = "http://www.w3.org/1999/xhtml")]
        [System.Xml.Serialization.XmlElementAttribute("ul", typeof(ul), Namespace = "http://www.w3.org/1999/xhtml")]
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogWeaknessObserved_Examples
    {

        private Weakness_CatalogWeaknessObserved_ExamplesObserved_Example[] observed_ExampleField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Observed_Example")]
        public Weakness_CatalogWeaknessObserved_ExamplesObserved_Example[] Observed_Example
        {
            get
            {
                return this.observed_ExampleField;
            }
            set
            {
                this.observed_ExampleField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogWeaknessObserved_ExamplesObserved_Example
    {

        private string referenceField;

        private string descriptionField;

        private string linkField;

        /// <remarks/>
        public string Reference
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

        /// <remarks/>
        public string Description
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
        public string Link
        {
            get
            {
                return this.linkField;
            }
            set
            {
                this.linkField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogWeaknessPotential_Mitigations
    {

        private Weakness_CatalogWeaknessPotential_MitigationsMitigation[] mitigationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Mitigation")]
        public Weakness_CatalogWeaknessPotential_MitigationsMitigation[] Mitigation
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogWeaknessPotential_MitigationsMitigation
    {

        private string[] phaseField;

        private string strategyField;

        private Weakness_CatalogWeaknessPotential_MitigationsMitigationDescription descriptionField;

        private string effectivenessField;

        private string effectiveness_NotesField;

        private string mitigation_IDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Phase")]
        public string[] Phase
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
        public string Strategy
        {
            get
            {
                return this.strategyField;
            }
            set
            {
                this.strategyField = value;
            }
        }

        /// <remarks/>
        public Weakness_CatalogWeaknessPotential_MitigationsMitigationDescription Description
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
        public string Effectiveness
        {
            get
            {
                return this.effectivenessField;
            }
            set
            {
                this.effectivenessField = value;
            }
        }

        /// <remarks/>
        public string Effectiveness_Notes
        {
            get
            {
                return this.effectiveness_NotesField;
            }
            set
            {
                this.effectiveness_NotesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Mitigation_ID
        {
            get
            {
                return this.mitigation_IDField;
            }
            set
            {
                this.mitigation_IDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogWeaknessPotential_MitigationsMitigationDescription
    {

        private object[] itemsField;

        private string[] textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("br", typeof(object), Namespace = "http://www.w3.org/1999/xhtml")]
        [System.Xml.Serialization.XmlElementAttribute("div", typeof(div), Namespace = "http://www.w3.org/1999/xhtml")]
        [System.Xml.Serialization.XmlElementAttribute("ol", typeof(ol), Namespace = "http://www.w3.org/1999/xhtml")]
        [System.Xml.Serialization.XmlElementAttribute("p", typeof(p), Namespace = "http://www.w3.org/1999/xhtml")]
        [System.Xml.Serialization.XmlElementAttribute("ul", typeof(ul), Namespace = "http://www.w3.org/1999/xhtml")]
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogWeaknessReferences
    {

        private Weakness_CatalogWeaknessReferencesReference[] referenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Reference")]
        public Weakness_CatalogWeaknessReferencesReference[] Reference
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogWeaknessReferencesReference
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogWeaknessRelated_Attack_Patterns
    {

        private Weakness_CatalogWeaknessRelated_Attack_PatternsRelated_Attack_Pattern[] related_Attack_PatternField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Related_Attack_Pattern")]
        public Weakness_CatalogWeaknessRelated_Attack_PatternsRelated_Attack_Pattern[] Related_Attack_Pattern
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogWeaknessRelated_Attack_PatternsRelated_Attack_Pattern
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogWeaknessRelated_Weaknesses
    {

        private Weakness_CatalogWeaknessRelated_WeaknessesRelated_Weakness[] related_WeaknessField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Related_Weakness")]
        public Weakness_CatalogWeaknessRelated_WeaknessesRelated_Weakness[] Related_Weakness
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogWeaknessRelated_WeaknessesRelated_Weakness
    {

        private string natureField;

        private ushort cWE_IDField;

        private ushort view_IDField;

        private string ordinalField;

        private ushort chain_IDField;

        private bool chain_IDFieldSpecified;

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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort View_ID
        {
            get
            {
                return this.view_IDField;
            }
            set
            {
                this.view_IDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Ordinal
        {
            get
            {
                return this.ordinalField;
            }
            set
            {
                this.ordinalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort Chain_ID
        {
            get
            {
                return this.chain_IDField;
            }
            set
            {
                this.chain_IDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Chain_IDSpecified
        {
            get
            {
                return this.chain_IDFieldSpecified;
            }
            set
            {
                this.chain_IDFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogWeaknessTaxonomy_Mappings
    {

        private Weakness_CatalogWeaknessTaxonomy_MappingsTaxonomy_Mapping[] taxonomy_MappingField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Taxonomy_Mapping")]
        public Weakness_CatalogWeaknessTaxonomy_MappingsTaxonomy_Mapping[] Taxonomy_Mapping
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogWeaknessTaxonomy_MappingsTaxonomy_Mapping
    {

        private string entry_IDField;

        private string entry_NameField;

        private string mapping_FitField;

        private string taxonomy_NameField;

        /// <remarks/>
        public string Entry_ID
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
        public string Mapping_Fit
        {
            get
            {
                return this.mapping_FitField;
            }
            set
            {
                this.mapping_FitField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogWeaknessWeakness_Ordinalities
    {

        private Weakness_CatalogWeaknessWeakness_OrdinalitiesWeakness_Ordinality[] weakness_OrdinalityField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Weakness_Ordinality")]
        public Weakness_CatalogWeaknessWeakness_OrdinalitiesWeakness_Ordinality[] Weakness_Ordinality
        {
            get
            {
                return this.weakness_OrdinalityField;
            }
            set
            {
                this.weakness_OrdinalityField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogWeaknessWeakness_OrdinalitiesWeakness_Ordinality
    {

        private string ordinalityField;

        private string descriptionField;

        /// <remarks/>
        public string Ordinality
        {
            get
            {
                return this.ordinalityField;
            }
            set
            {
                this.ordinalityField = value;
            }
        }

        /// <remarks/>
        public string Description
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://cwe.mitre.org/cwe-6", IncludeInSchema = false)]
    public enum ItemsChoiceType2
    {

        /// <remarks/>
        Affected_Resources,

        /// <remarks/>
        Alternate_Terms,

        /// <remarks/>
        Applicable_Platforms,

        /// <remarks/>
        Background_Details,

        /// <remarks/>
        Common_Consequences,

        /// <remarks/>
        Content_History,

        /// <remarks/>
        Demonstrative_Examples,

        /// <remarks/>
        Description,

        /// <remarks/>
        Detection_Methods,

        /// <remarks/>
        Extended_Description,

        /// <remarks/>
        Functional_Areas,

        /// <remarks/>
        Likelihood_Of_Exploit,

        /// <remarks/>
        Modes_Of_Introduction,

        /// <remarks/>
        Notes,

        /// <remarks/>
        Observed_Examples,

        /// <remarks/>
        Potential_Mitigations,

        /// <remarks/>
        References,

        /// <remarks/>
        Related_Attack_Patterns,

        /// <remarks/>
        Related_Weaknesses,

        /// <remarks/>
        Taxonomy_Mappings,

        /// <remarks/>
        Weakness_Ordinalities,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogCategory
    {

        private object[] itemsField;

        private ushort idField;

        private string nameField;

        private string statusField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Content_History", typeof(Weakness_CatalogCategoryContent_History))]
        [System.Xml.Serialization.XmlElementAttribute("Notes", typeof(Weakness_CatalogCategoryNotes))]
        [System.Xml.Serialization.XmlElementAttribute("References", typeof(Weakness_CatalogCategoryReferences))]
        [System.Xml.Serialization.XmlElementAttribute("Relationships", typeof(Weakness_CatalogCategoryRelationships))]
        [System.Xml.Serialization.XmlElementAttribute("Summary", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("Taxonomy_Mappings", typeof(Weakness_CatalogCategoryTaxonomy_Mappings))]
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogCategoryContent_History
    {

        private Weakness_CatalogCategoryContent_HistorySubmission submissionField;

        private Weakness_CatalogCategoryContent_HistoryModification[] modificationField;

        private Weakness_CatalogCategoryContent_HistoryPrevious_Entry_Name[] previous_Entry_NameField;

        /// <remarks/>
        public Weakness_CatalogCategoryContent_HistorySubmission Submission
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Modification")]
        public Weakness_CatalogCategoryContent_HistoryModification[] Modification
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
        public Weakness_CatalogCategoryContent_HistoryPrevious_Entry_Name[] Previous_Entry_Name
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogCategoryContent_HistorySubmission
    {

        private string submission_NameField;

        private string submission_OrganizationField;

        private System.DateTime submission_DateField;

        private string submission_CommentField;

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
        public string Submission_Comment
        {
            get
            {
                return this.submission_CommentField;
            }
            set
            {
                this.submission_CommentField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogCategoryContent_HistoryModification
    {

        private string modification_NameField;

        private string modification_OrganizationField;

        private System.DateTime modification_DateField;

        private string modification_CommentField;

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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogCategoryContent_HistoryPrevious_Entry_Name
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogCategoryNotes
    {

        private Weakness_CatalogCategoryNotesNote[] noteField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Note")]
        public Weakness_CatalogCategoryNotesNote[] Note
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogCategoryNotesNote
    {

        private p[] pField;

        private div divField;

        private string[] textField;

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("p", Namespace = "http://www.w3.org/1999/xhtml")]
        public p[] p
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/1999/xhtml")]
        public div div
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogCategoryReferences
    {

        private Weakness_CatalogCategoryReferencesReference[] referenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Reference")]
        public Weakness_CatalogCategoryReferencesReference[] Reference
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogCategoryReferencesReference
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogCategoryRelationships
    {

        private Weakness_CatalogCategoryRelationshipsHas_Member[] has_MemberField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Has_Member")]
        public Weakness_CatalogCategoryRelationshipsHas_Member[] Has_Member
        {
            get
            {
                return this.has_MemberField;
            }
            set
            {
                this.has_MemberField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogCategoryRelationshipsHas_Member
    {

        private ushort cWE_IDField;

        private ushort view_IDField;

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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort View_ID
        {
            get
            {
                return this.view_IDField;
            }
            set
            {
                this.view_IDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogCategoryTaxonomy_Mappings
    {

        private Weakness_CatalogCategoryTaxonomy_MappingsTaxonomy_Mapping[] taxonomy_MappingField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Taxonomy_Mapping")]
        public Weakness_CatalogCategoryTaxonomy_MappingsTaxonomy_Mapping[] Taxonomy_Mapping
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogCategoryTaxonomy_MappingsTaxonomy_Mapping
    {

        private string entry_IDField;

        private string entry_NameField;

        private string mapping_FitField;

        private string taxonomy_NameField;

        /// <remarks/>
        public string Entry_ID
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
        public string Mapping_Fit
        {
            get
            {
                return this.mapping_FitField;
            }
            set
            {
                this.mapping_FitField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogView
    {

        private string objectiveField;

        private Weakness_CatalogViewStakeholder[] audienceField;

        private string filterField;

        private Weakness_CatalogViewHas_Member[] membersField;

        private Weakness_CatalogViewReference[] referencesField;

        private Weakness_CatalogViewNote[] notesField;

        private Weakness_CatalogViewContent_History content_HistoryField;

        private ushort idField;

        private string nameField;

        private string typeField;

        private string statusField;

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
        [System.Xml.Serialization.XmlArrayItemAttribute("Stakeholder", IsNullable = false)]
        public Weakness_CatalogViewStakeholder[] Audience
        {
            get
            {
                return this.audienceField;
            }
            set
            {
                this.audienceField = value;
            }
        }

        /// <remarks/>
        public string Filter
        {
            get
            {
                return this.filterField;
            }
            set
            {
                this.filterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Has_Member", IsNullable = false)]
        public Weakness_CatalogViewHas_Member[] Members
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
        [System.Xml.Serialization.XmlArrayItemAttribute("Reference", IsNullable = false)]
        public Weakness_CatalogViewReference[] References
        {
            get
            {
                return this.referencesField;
            }
            set
            {
                this.referencesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Note", IsNullable = false)]
        public Weakness_CatalogViewNote[] Notes
        {
            get
            {
                return this.notesField;
            }
            set
            {
                this.notesField = value;
            }
        }

        /// <remarks/>
        public Weakness_CatalogViewContent_History Content_History
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogViewStakeholder
    {

        private string typeField;

        private string descriptionField;

        /// <remarks/>
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

        /// <remarks/>
        public string Description
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogViewHas_Member
    {

        private ushort cWE_IDField;

        private ushort view_IDField;

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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort View_ID
        {
            get
            {
                return this.view_IDField;
            }
            set
            {
                this.view_IDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogViewReference
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogViewNote
    {

        private p pField;

        private string[] textField;

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/1999/xhtml")]
        public p p
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogViewContent_History
    {

        private Weakness_CatalogViewContent_HistorySubmission submissionField;

        private Weakness_CatalogViewContent_HistoryModification[] modificationField;

        private Weakness_CatalogViewContent_HistoryContribution contributionField;

        private Weakness_CatalogViewContent_HistoryPrevious_Entry_Name[] previous_Entry_NameField;

        /// <remarks/>
        public Weakness_CatalogViewContent_HistorySubmission Submission
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Modification")]
        public Weakness_CatalogViewContent_HistoryModification[] Modification
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
        public Weakness_CatalogViewContent_HistoryContribution Contribution
        {
            get
            {
                return this.contributionField;
            }
            set
            {
                this.contributionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Previous_Entry_Name")]
        public Weakness_CatalogViewContent_HistoryPrevious_Entry_Name[] Previous_Entry_Name
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogViewContent_HistorySubmission
    {

        private string submission_NameField;

        private string submission_OrganizationField;

        private System.DateTime submission_DateField;

        private string submission_CommentField;

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
        public string Submission_Comment
        {
            get
            {
                return this.submission_CommentField;
            }
            set
            {
                this.submission_CommentField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogViewContent_HistoryModification
    {

        private string modification_NameField;

        private string modification_OrganizationField;

        private System.DateTime modification_DateField;

        private string modification_ImportanceField;

        private string modification_CommentField;

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
        public string Modification_Importance
        {
            get
            {
                return this.modification_ImportanceField;
            }
            set
            {
                this.modification_ImportanceField = value;
            }
        }

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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogViewContent_HistoryContribution
    {

        private string contribution_NameField;

        private System.DateTime contribution_DateField;

        private string contribution_CommentField;

        private string typeField;

        /// <remarks/>
        public string Contribution_Name
        {
            get
            {
                return this.contribution_NameField;
            }
            set
            {
                this.contribution_NameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime Contribution_Date
        {
            get
            {
                return this.contribution_DateField;
            }
            set
            {
                this.contribution_DateField = value;
            }
        }

        /// <remarks/>
        public string Contribution_Comment
        {
            get
            {
                return this.contribution_CommentField;
            }
            set
            {
                this.contribution_CommentField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogViewContent_HistoryPrevious_Entry_Name
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://cwe.mitre.org/cwe-6")]
    public partial class Weakness_CatalogExternal_Reference
    {

        private string[] authorField;

        private string titleField;

        private string editionField;

        private string publicationField;

        private ushort publication_YearField;

        private bool publication_YearFieldSpecified;

        private string publication_MonthField;

        private string publication_DayField;

        private string publisherField;

        private string uRLField;

        private System.DateTime uRL_DateField;

        private bool uRL_DateFieldSpecified;

        private string reference_IDField;

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
    }


}
