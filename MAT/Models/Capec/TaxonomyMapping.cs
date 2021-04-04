using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CognitiveMaps.MAT.Models.Capec
{
    /// <summary>
    /// Taxonomy_Mappings
    /// </summary>
    public class TaxonomyMapping
    {
        /// <summary>
        /// Ссылка на ---------
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Ид
        /// </summary>
        public string EntryId { get; set; }
        
        /// <summary>
        /// Название/описание 
        /// </summary>
        public string EntryName { get; set; }
    }
}
