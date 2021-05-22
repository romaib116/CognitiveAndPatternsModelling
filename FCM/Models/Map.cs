using System.Collections.Generic;

namespace CognitiveMaps.FCM.Models
{
    public class Map
    {
        private List<Concept> _concepts;
        private double[,] _weightMatrix;

        /// <summary>
        /// Инициализация вектора объектов для работы с концептами
        /// </summary>
        public List<Concept> Concepts
        {
            get
            {
                return _concepts ??= new List<Concept>();
            }
            set
            {
                _concepts = value;
            }
        }

        /// <summary>
        /// Матрица весов
        /// </summary>
        public double[,] WeightMatrix
        {
            get
            {
                return _weightMatrix ??= new double[1, 1];
            }
            set
            {
                _weightMatrix = value;
            }
        }
    }
}
