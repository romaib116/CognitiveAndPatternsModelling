using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CognitiveMaps.MAT.Models.Capec
{
    public class ExecutionFlowAttackStep
    {
        /// <summary>
        /// Номер шага
        /// </summary>
        public int StepId { get; set; }

        /// <summary>
        /// Название фазы
        /// </summary>
        public string Phase { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Способы реализации
        /// </summary>
        public List<string> Techniques { get; set; }
    }
}
