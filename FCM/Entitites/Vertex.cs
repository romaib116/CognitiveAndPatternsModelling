
namespace CognitiveMaps.FCM.Entities
{
    /// <summary>
    /// Класс вершины
    /// </summary>
    public class Vertex
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
        public int ID { get; private set; }

        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// Конструктор, при инициализации нужны сразу все 3 свойства
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        public Vertex(int id, string name, string description)
        {
            ID = id;
            Name = name;
            Description = description;
        }
    }
}
