namespace CognitiveMaps.FCM.Interfaces
{
    /// <summary>
    /// Интерфейс реализации карты
    /// </summary>
    public interface IMap
    {
        /// <summary>
        /// [Необходимо реализовать для каждого вида нечетких карт]
        /// </summary>
        abstract void ImpactModel();

        /// <summary>
        /// Добавление вершины
        /// </summary>
        /// <param name="name">Название</param>
        /// <param name="description">Описание</param>
        void AddVertex(string name, string description);

        /// <summary>
        /// Добавить вес между двумя вершинами
        /// </summary>
        /// <param name="firstVertexID"></param>
        /// <param name="secondVertexID"></param>
        /// <param name="weight"></param>
        void AddWeight(int firstVertexID, int secondVertexID, double weight);

        /// <summary>
        /// Сжимающая функция
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        double Sigmoid(double x);

    }
}
