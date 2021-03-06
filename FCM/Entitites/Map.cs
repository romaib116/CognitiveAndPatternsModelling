using System;
using System.Collections.Generic;
using System.Linq;
using CognitiveMaps.FCM.Interfaces;

namespace CognitiveMaps.FCM.Entities
{
    /// <summary>
    /// Абстрактный класс с типовой реализацией карты
    /// </summary>
    public abstract class Map : IMap
    {
        #region Поля класса
        private List<Vertex> _vertices;
        private Weight _weights;

        /// <summary>
        /// Инициализация списка объектов для работы с вершинами
        /// </summary>
        protected List<Vertex> Vertices {
            get 
            { 
                return _vertices ??= new List<Vertex>(); 
            }
        }

        /// <summary>
        /// Инициализация класса работы с весами
        /// </summary>
        protected Weight Weights {
            get
            {
                return _weights ??= new Weight();
            }
        }
        #endregion

        /// <summary>
        /// [Необходимо реализовать для каждого вида нечетких карт]
        /// </summary>
        abstract public void ImpactModel();

        /// <summary>
        /// Добавить вершину
        /// </summary>
        /// <param name="name"> Название </param>
        /// <param name="description"> Описание </param>
        public void AddVertex(string name, string description)
        {
            //Пополняем список вершин
            Vertices.Add(new Vertex(Vertices.Count, name, description));
        }

        /// <summary>
        /// Добавить вес между двумя вершинами
        /// </summary>
        /// <param name="firstVertexID"> Первая вершина </param>
        /// <param name="secondVertexID"> Вторая вершина</param>
        /// <param name="weight"> Вес </param>
        public void AddWeight(int firstVertexID, int secondVertexID, double weight)
        {
            try
            {
                //Если существуют, добавляем вес в матрицу весов
                if (IsExistVertex(firstVertexID) && IsExistVertex(secondVertexID))
                    Weights.AddWeight(firstVertexID, secondVertexID, weight, Vertices.Count);
                //Исключения
                else if (!IsExistVertex(firstVertexID) && IsExistVertex(secondVertexID))
                    throw new Exception($"Вес {weight} не добавлен! Вершины с номером {firstVertexID} не существует");
                else if (IsExistVertex(firstVertexID) && !IsExistVertex(secondVertexID))
                    throw new Exception($"Вес {weight} не добавлен! Вершины с номером {secondVertexID} не существует");
                else
                    throw new Exception($"Вес {weight} не добавлен! Вершин с номерами {firstVertexID}, {secondVertexID} не существует");
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Сжимающая функция
        /// В нашем случае - сигмоидальная
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double Sigmoid(double x)
        {
            return 1 / (1 + Math.Exp(-x));
        }


        /// <summary>
        /// Проверка на существование переданной вершины
        /// </summary>
        /// <param name="vertex"> Вершина </param>
        /// <returns></returns>
        private bool IsExistVertex(int vertex)
        {
            return Vertices.Where(v => v.ID == vertex).Any();
        }
    }
}
