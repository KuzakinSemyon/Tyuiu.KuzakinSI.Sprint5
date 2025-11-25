using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Globalization;
using Tyuiu.KuzakinSI.Sprint5.Task4.V21.Lib;

namespace Tyuiu.KuzakinSI.Sprint5.Task4.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();

            // Создаем временный файл с тестовым значением
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask4V21.txt");
            File.WriteAllText(path, "4.68");

            double result = ds.LoadFromDataFile(path);
            // Для x = 4.68: 4.68^3 * cos(4.68) + 2*4.68
            double wait = -85.902; // Примерное значение

            Assert.AreEqual(wait, result, 0.001);

            // Удаляем временный файл
            File.Delete(path);
        }
    }
}