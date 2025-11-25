using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
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
            File.WriteAllText(path, "2.5");

            double result = ds.LoadFromDataFile(path);
            // Для x = 2.5: 2.5^3 * cos(2.5) + 2*2.5 = 15.625 * (-0.8011436) + 5 ≈ -12.517 + 5 = -7.517
            double wait = -7.517;

            Assert.AreEqual(wait, result);

            // Удаляем временный файл
            File.Delete(path);
        }
    }
}