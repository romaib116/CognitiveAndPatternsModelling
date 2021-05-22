
namespace CognitiveMaps.FCM.Models
{
    /// <summary>
    /// Класс вершины
    /// </summary>
    public class Concept
    {
        private bool _isTarget;

        /// <summary>
        /// Уникальный идентификатор (в формате CN, где N - уникальное число)
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Название концепта
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Признак целевого концепта (у концепта есть желаемое состояние к которому он должен стремиться)
        /// </summary>
        public bool IsTarget 
        { 
            get 
            {
                return _isTarget;
            }
            set
            {
                if (value == false)
                    TargetValue = null;
                _isTarget = value;
            }
        }

        /// <summary>
        /// Желаемое значение целевого концепта
        /// </summary>
        public double? TargetValue { get; set; }

        /// <summary>
        /// Признак драйвера (неизменность текущего концепта)
        /// </summary>
        public bool IsDriver { get; set; }

        /// <summary>
        /// Значение концепта
        /// </summary>
        public double Value { get; set; }
    }
}
