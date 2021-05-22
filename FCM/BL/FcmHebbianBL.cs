using CognitiveMaps.FCM.Models;
using System;
using System.Linq;

namespace CognitiveMaps.FCM.BL
{

    /// <summary>
    /// Алгоритм обучения НКК по правилу Хэбба
    /// </summary>
    public class FcmHebbianBL : MapBL
    {
        /// <summary>
        /// Обучение карты по алгоритму Хэбба
        /// </summary>
        /// <param name="map"> карта имеющая концепты, матрицу весов </param>
        /// <param name="maxIterations"> максимальное количество итераций </param>
        /// <param name="speed"> скорость обучения </param>
        /// <param name="accuracy"> допустимая погрешность между желаемым значением коцепта и текущим </param>
        /// <returns> возвращает обученную карту по заданным условиям 
        /// (выполнено условие останова либо достигнуто максимальное количество итераций) </returns>
        public void TrainFcm(Map map, int maxIterations, double speed, double accuracy)
        {
            //Инициализация размера матрицы весов 
            var sizeWeightMatrix = (int)Math.Sqrt(map.WeightMatrix.Length);

            //Запускаем цикл по заданному максимальному количеству итераций
            for (int iteration = 0; iteration < maxIterations; iteration++)
            {
                /* Новое состояние концептов
                 * вычисляется как сигмоида от (умножение вектора на матрицу весов + вектор)
                 */
                var newConcepts = MultiplyMatrixByVector(map.WeightMatrix, map.Concepts);
                for (int i = 0; i < newConcepts.Count; i++)
                {
                    newConcepts[i].Value += map.Concepts[i].Value;
                    newConcepts[i].Value = Sigmoid(newConcepts[i].Value);
                }                  


                //Построение корректирующей матрицы весовых коэффициентов
                var deltaWeights = new double[sizeWeightMatrix, sizeWeightMatrix];

                //Алгоритм Хэбба
                for (int i = 0; i < sizeWeightMatrix; i++)
                {
                    for (int j = 0; j < sizeWeightMatrix; j++)
                    {
                        if (i == j)
                            continue;
                        deltaWeights[j, i] =
                               map.Concepts[j].Value * (map.Concepts[i].Value - map.Concepts[j].Value * map.WeightMatrix[j, i]);
                    }
                }

                //Масштабируем матрицу, домножая на коэффициент скорости обучения
                for (int i = 0; i < sizeWeightMatrix; i++)
                    for (int j = 0; j < sizeWeightMatrix; j++)
                        deltaWeights[i, j] = speed * deltaWeights[i, j];

                //корректируем только те веса, которые изначально были не нулевыми,
                //чтобы предотвратить появление новых весов
                for (int i = 0; i < sizeWeightMatrix; i++)
                    for (int j = 0; j < sizeWeightMatrix; j++)
                        if (map.WeightMatrix[i, j] != 0)
                            map.WeightMatrix[i, j] = deltaWeights[i, j] + map.WeightMatrix[i, j];

                //Присваиваем новые значения концептов исходным для дальнейших итераций
                for (int i = 0; i < map.Concepts.Count; i++)
                    //Концепты драйверы должны остаться неизменными
                    if (!map.Concepts[i].IsDriver)
                        map.Concepts[i].Value = newConcepts[i].Value;

                //Условие останова
                //Отбраем целевые концепты
                var targetConcepts = map.Concepts.Where(x => x.IsTarget);
                //Если разница всех целевых концептов с их "идеальным" значением меньше погрешности
                //ИЛИ сумма значений целевых концептов превысила заданный порог (например - 0,75)
                if (targetConcepts.All(x => Math.Abs(Convert.ToDouble(x.TargetValue - x.Value)) < accuracy) ||
                    targetConcepts.Sum(x => x.Value) > 0.75)
                    break;
            }

        }
    }
}
