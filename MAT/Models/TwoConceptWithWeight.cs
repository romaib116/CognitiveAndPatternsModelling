namespace CognitiveMaps.MAT.Models
{
    /// <summary>
    /// Класс для работы с усечениями концептов по пороговому значению веса
    /// </summary>
    public class TwoConceptWithWeight
    {
        /// <summary>
        /// Из концепта
        /// </summary>
        public string FromConcept { get; set; }

        /// <summary>
        /// В концепт
        /// </summary>
        public string ToConcept { get; set; }
        
        /// <summary>
        /// Вес
        /// </summary>
        public double Weight { get; set; }
    }
}
