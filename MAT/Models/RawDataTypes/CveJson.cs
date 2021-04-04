using Newtonsoft.Json;
using System.Collections.Generic;

/// <summary>
/// Набор классов описывающий сериализацию/Десериализацию JSON CVE
/// </summary>
namespace CognitiveMaps.MAT.Models.RawDataTypes.CveJson
{
    /// <summary>
    /// Классы описывающие структуру Json CVE
    /// </summary>
    public class CveJson
    {
        [JsonProperty("CVE_data_type")]
        public string CVEDataType { get; set; }

        [JsonProperty("CVE_data_format")]
        public string CVEDataFormat { get; set; }

        [JsonProperty("CVE_data_version")]
        public string CVEDataVersion { get; set; }

        [JsonProperty("CVE_data_numberOfCVEs")]
        public string CVEDataNumberOfCVEs { get; set; }

        [JsonProperty("CVE_data_timestamp")]
        public string CVEDataTimestamp { get; set; }

        [JsonProperty("CVE_Items")]
        public List<CVEItem> CVEItems { get; set; }
    }


    #region Вспомогательные
    public class CVEDataMeta
    {
        [JsonProperty("ID")]
        public string ID { get; set; }

        [JsonProperty("ASSIGNER")]
        public string ASSIGNER { get; set; }
    }

    public class Description
    {
        [JsonIgnore]
        public string Lang { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("description_data")]
        public List<DescriptionData> DescriptionData { get; set; }
    }

    public class ProblemtypeData
    {
        [JsonProperty("description")]
        public List<Description> Description { get; set; }
    }

    public class Problemtype
    {
        [JsonProperty("problemtype_data")]
        public List<ProblemtypeData> ProblemtypeData { get; set; }
    }

    public class ReferenceData
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonIgnore]
        public string Name { get; set; }

        [JsonIgnore]
        public string Refsource { get; set; }

        [JsonIgnore]
        public List<string> Tags { get; set; }
    }

    public class References
    {
        [JsonProperty("reference_data")]
        public List<ReferenceData> ReferenceData { get; set; }
    }

    public class DescriptionData
    {
        [JsonIgnore]
        public string Lang { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class Cve
    {
        [JsonProperty("data_type")]
        public string DataType { get; set; }

        [JsonProperty("data_format")]
        public string DataFormat { get; set; }

        [JsonProperty("data_version")]
        public string DataVersion { get; set; }

        [JsonProperty("CVE_data_meta")]
        public CVEDataMeta CVEDataMeta { get; set; }

        [JsonProperty("problemtype")]
        public Problemtype Problemtype { get; set; }

        [JsonProperty("references")]
        public References References { get; set; }

        [JsonProperty("description")]
        public Description Description { get; set; }
    }

    public class CpeMatch
    {
        [JsonProperty("vulnerable")]
        public bool Vulnerable { get; set; }

        [JsonProperty("cpe23Uri")]
        public string Cpe23Uri { get; set; }

        [JsonProperty("versionEndExcluding")]
        public string VersionEndExcluding { get; set; }
    }

    public class Child
    {
        [JsonProperty("operator")]
        public string Operator { get; set; }

        [JsonProperty("cpe_match")]
        public List<CpeMatch> CpeMatch { get; set; }
    }

    public class Node
    {
        [JsonProperty("operator")]
        public string Operator { get; set; }

        [JsonProperty("children")]
        public List<Child> Children { get; set; }

        [JsonProperty("cpe_match")]
        public List<CpeMatch> CpeMatch { get; set; }
    }

    public class Configurations
    {
        [JsonProperty("CVE_data_version")]
        public string CVEDataVersion { get; set; }

        [JsonProperty("nodes")]
        public List<Node> Nodes { get; set; }
    }

    public class CvssV3
    {
        [JsonIgnore]
        public string Version { get; set; }

        [JsonIgnore]
        public string VectorString { get; set; }

        [JsonProperty("attackVector")]
        public string AttackVector { get; set; }

        [JsonProperty("attackComplexity")]
        public string AttackComplexity { get; set; }

        [JsonProperty("privilegesRequired")]
        public string PrivilegesRequired { get; set; }

        [JsonProperty("userInteraction")]
        public string UserInteraction { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }

        [JsonProperty("confidentialityImpact")]
        public string ConfidentialityImpact { get; set; }

        [JsonProperty("integrityImpact")]
        public string IntegrityImpact { get; set; }

        [JsonProperty("availabilityImpact")]
        public string AvailabilityImpact { get; set; }

        [JsonProperty("baseScore")]
        public double BaseScore { get; set; }

        [JsonProperty("baseSeverity")]
        public string BaseSeverity { get; set; }
    }

    public class BaseMetricV3
    {
        [JsonProperty("cvssV3")]
        public CvssV3 CvssV3 { get; set; }

        [JsonProperty("exploitabilityScore")]
        public double ExploitabilityScore { get; set; }

        [JsonProperty("impactScore")]
        public double ImpactScore { get; set; }
    }

    public class CvssV2
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("vectorString")]
        public string VectorString { get; set; }

        [JsonProperty("accessVector")]
        public string AccessVector { get; set; }

        [JsonProperty("accessComplexity")]
        public string AccessComplexity { get; set; }

        [JsonProperty("authentication")]
        public string Authentication { get; set; }

        [JsonProperty("confidentialityImpact")]
        public string ConfidentialityImpact { get; set; }

        [JsonProperty("integrityImpact")]
        public string IntegrityImpact { get; set; }

        [JsonProperty("availabilityImpact")]
        public string AvailabilityImpact { get; set; }

        [JsonProperty("baseScore")]
        public double BaseScore { get; set; }
    }

    public class BaseMetricV2
    {
        [JsonProperty("cvssV2")]
        public CvssV2 CvssV2 { get; set; }

        [JsonProperty("severity")]
        public string Severity { get; set; }

        [JsonProperty("exploitabilityScore")]
        public double ExploitabilityScore { get; set; }

        [JsonProperty("impactScore")]
        public double ImpactScore { get; set; }

        [JsonProperty("acInsufInfo")]
        public bool AcInsufInfo { get; set; }

        [JsonProperty("obtainAllPrivilege")]
        public bool ObtainAllPrivilege { get; set; }

        [JsonProperty("obtainUserPrivilege")]
        public bool ObtainUserPrivilege { get; set; }

        [JsonProperty("obtainOtherPrivilege")]
        public bool ObtainOtherPrivilege { get; set; }

        [JsonProperty("userInteractionRequired")]
        public bool UserInteractionRequired { get; set; }
    }

    public class Impact
    {
        [JsonProperty("baseMetricV3")]
        public BaseMetricV3 BaseMetricV3 { get; set; }

        [JsonIgnore]
        public BaseMetricV2 BaseMetricV2 { get; set; }
    }

    public class CVEItem
    {
        [JsonProperty("cve")]
        public Cve Cve { get; set; }

        [JsonIgnore]
        public Configurations Configurations { get; set; }

        [JsonProperty("impact")]
        public Impact Impact { get; set; }

        [JsonProperty("publishedDate")]
        public string PublishedDate { get; set; }

        [JsonProperty("lastModifiedDate")]
        public string LastModifiedDate { get; set; }
    }
    #endregion


}
