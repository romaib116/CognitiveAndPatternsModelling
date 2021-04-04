using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CognitiveMaps.MAT.Models.Capec
{
    /// <summary>
    /// История
    /// </summary>
    public class ContentHistory
    {
        /// <summary>
        /// Представлено
        /// </summary>
        public ContentHistorySubmission Submission { get; set; }

        /// <summary>
        /// История модификаций
        /// </summary>
        public List<ContentHistoryModification> Modifications { get; set; }
    }
}
