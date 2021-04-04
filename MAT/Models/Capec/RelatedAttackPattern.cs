using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CognitiveMaps.MAT.Models.Capec
{
    /// <summary>
    /// Связанные шаблоны атак
    /// </summary>
    public class RelatedAttackPattern
    {
        /// <summary>
        /// Ид капека
        /// </summary>
        public int CapecId { get; set; }

        /// <summary>
        /// Связь
        /// </summary>
        public string Nature { get; set; }
    }
}
