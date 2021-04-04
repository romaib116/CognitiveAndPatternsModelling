using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CognitiveMaps.MAT.Models.Capec
{
    /// <summary>
    /// 
    /// </summary>
    public class ContentHistoryModification
    {
        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Организация
        /// </summary>
        public string Organization { get; set; }

        /// <summary>
        /// Дата
        /// </summary>
        public DateTime? Date { get; set; }

        /// <summary>
        /// Комментарий
        /// </summary>
        public string Comment { get; set; }
    }
}
