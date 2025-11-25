using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.KuzakinSI.Sprint5.Task1.V6.Lib;

namespace Tyuiu.KuzakinSI.Sprint5.Task1.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();
            
            int startValue = -5;
            int stopValue = 5;
            string path = ds.SaveToFileTextData(startValue, stopValue);

            // Проверяем существование файла
            Assert.IsTrue(File.Exists(path));

            // Проверяем, что файл не пустой
            string fileContent = File.ReadAllText(path);
            Assert.IsTrue(fileContent.Length > 0);
        }
    }
}