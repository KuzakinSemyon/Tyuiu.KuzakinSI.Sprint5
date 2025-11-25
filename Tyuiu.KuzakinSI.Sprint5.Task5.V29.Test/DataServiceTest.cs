using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.KuzakinSI.Sprint5.Task5.V29.Lib;

namespace Tyuiu.KuzakinSI.Sprint5.Task5.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();

            // Создаем временный файл с тестовыми данными
            string path = Path.Combine(Path.GetTempPath(), "TestFileTask5V29.txt");
            
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("15.5");
                writer.WriteLine("23");
                writer.WriteLine("45.0");
                writer.WriteLine("12");
                writer.WriteLine("8.7");
                writer.WriteLine("99");
                writer.WriteLine("3.14");
            }

            double result = ds.LoadFromDataFile(path);
            double wait = 12; // Минимальное двузначное целое число

            Assert.AreEqual(wait, result);

            // Удаляем временный файл
            File.Delete(path);
        }
    }
}