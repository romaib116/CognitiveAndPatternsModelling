using System.Collections.Generic;

namespace CognitiveMaps.MAT.Models
{
    /// <summary>
    /// Сущность Cwe - CAPECs
    /// </summary>
    public class ProcessedCweCapec
    {
        public string Cwe { get; set; }
        public List<CapecEntity> CapecList { get; set; }
    }
}
