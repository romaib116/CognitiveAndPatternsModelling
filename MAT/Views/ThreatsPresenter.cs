using CognitiveMaps.MAT.BL;
using CognitiveMaps.MAT.Models;
using System.Collections.Generic;
using System.IO;

namespace CognitiveMaps.Views
{
    public class ThreatsPresenter<TView>
    {
        public TView View { get; set; }

        private MatBL _businessLogicForModeling;
        /// <summary>
        /// Для работы с классом реализующим логику моделирования актуальных угроз
        /// </summary>
        private MatBL BusinessLogicForModeling
        {
            get
            {
                return _businessLogicForModeling ??= new MatBL();
            }
        }


        private CveBL _businessLogicForCve;
        public CveBL BusinessLogicForCve
        {
            get
            {
                return _businessLogicForCve ??= new CveBL();
            }
        }

        /// <summary>
        /// Получаем файл актуальных угроз
        /// </summary>
        public List<CveEntity> GetCveList(string filePath)
        {
            return BusinessLogicForCve.GetCveList(filePath);
        }


    }
}
