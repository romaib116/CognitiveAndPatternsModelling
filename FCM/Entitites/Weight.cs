using System;

namespace CognitiveMaps.FCM.Entities
{
    /// <summary>
    /// Класс весов
    /// </summary>
    public class Weight
    {
        private double[,] _weightMatrix;
        /// <summary>
        /// Матрица весов
        /// </summary>
        public double[,] WeightMatrix { 
            get 
            {
                return _weightMatrix;
            } 
        }

        /// <summary>
        /// Инициализация матрицы весов
        /// </summary>
        private void InitializeWeightMatrix(int size)
        {
            _weightMatrix = new double[size, size];
        }

        /// <summary>
        /// Добавить вес между вершинами
        /// </summary>
        /// <param name="firstVertexID"> 1 вершина </param>
        /// <param name="secondVertexID"> 2 вершина </param>
        /// <param name="weight"> Вес </param>
        /// <param name="currentSize"> Текущее количество вершин </param>
        public void AddWeight(int firstVertexID, int secondVertexID, double weight, int currentSize)
        {
            //Если матрица весов ещё не инициализирована
            if (WeightMatrix == null)
            {
                InitializeWeightMatrix(currentSize);
            }
            //Если текущее количество вершин больше матрицы весов
            if (currentSize > Math.Sqrt(WeightMatrix.Length))
            {
                //Расширяем
                _weightMatrix = ResizeArray(currentSize);
            }
            //Присваиваем вес
            WeightMatrix[firstVertexID, secondVertexID] = weight;
        }


        /// <summary>
        /// При необходимости расширения матрицы
        /// </summary>
        /// <param name="newSize"> Новый размер </param>
        /// <returns></returns>
        private double[,] ResizeArray(int newSize)
        {
            double[,] newArray = new double[newSize, newSize];
            for (int i = 0; i < Math.Sqrt(WeightMatrix.Length); i++)
            {
                for (int j = 0; j < Math.Sqrt(WeightMatrix.Length); j++)
                {
                    newArray[i, j] = WeightMatrix[i, j];
                }
            }
            return newArray;
        }
    }
}
