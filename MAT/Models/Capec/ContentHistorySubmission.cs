using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CognitiveMaps.MAT.Models.Capec
{
    public class ContentHistorySubmission
    {
        /// <summary>
        /// Название команды
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Название организации
        /// </summary>
        public string Organization { get; set; }

        /// <summary>
        /// Дата
        /// </summary>
        public DateTime? Date { get; set; }
    }
}
