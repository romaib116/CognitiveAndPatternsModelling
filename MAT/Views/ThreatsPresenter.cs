using CognitiveMaps.MAT.Models;
using System.IO;

namespace CognitiveMaps.Views
{
    public class ThreatsPresenter<TView>
    {
        public TView View { get; set; }

        private MatModel _businessLogic;
        /// <summary>
        /// Для работы с классом реализующим логику моделирования актуальных угроз
        /// </summary>
        private MatModel BusinessLogic
        {
            get
            {
                return _businessLogic ??= new MatModel();
            }
        }

        /// <summary>
        /// Получаем файл актуальных угроз
        /// </summary>
        public void GetActualThreats(Stream stream)
        {
            
        }

        /// <summary>
        /// Запускаем моделирование
        /// </summary>
        public void GetModel()
        {

        }
    }
}
