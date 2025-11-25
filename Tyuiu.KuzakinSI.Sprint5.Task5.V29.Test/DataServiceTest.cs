using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.KuzakinSI.Sprint5.Task5.V29.Lib;

namespace Tyuiu.KuzakinSI.Sprint5.Task5.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile_WithEleven()
        {
            DataService ds = new DataService();

            string path = Path.Combine(Path.GetTempPath(), "TestFileTask5V29_Eleven.txt");

            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("11");     // Должно быть найдено
                writer.WriteLine("15.5");
                writer.WriteLine("23");     // Должно быть найдено
                writer.WriteLine("8.7");
                writer.WriteLine("12");     // Должно быть найдено
            }

            double result = ds.LoadFromDataFile(path);
            double wait = 11; // Минимальное из 11, 23, 12

            Assert.AreEqual(wait, result);
            File.Delete(path);
        }

        [TestMethod]
        public void ValidLoadFromDataFile_ElevenWithComma()
        {
            DataService ds = new DataService();

            string path = Path.Combine(Path.GetTempPath(), "TestFileTask5V29_ElevenComma.txt");

            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("11,0");  // Должно быть найдено как 11.0 -> 11
                writer.WriteLine("15,5");  // -> 15.5
                writer.WriteLine("23,0");  // Должно быть найдено как 23.0 -> 23
            }

            double result = ds.LoadFromDataFile(path);
            double wait = 11; // Минимальное из 11 и 23

            Assert.AreEqual(wait, result);
            File.Delete(path);
        }

        [TestMethod]
        public void ValidLoadFromDataFile_ElevenWithDot()
        {
            DataService ds = new DataService();

            string path = Path.Combine(Path.GetTempPath(), "TestFileTask5V29_ElevenDot.txt");

            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("11.0");  // Должно быть найдено
                writer.WriteLine("15.5");
                writer.WriteLine("23.0");  // Должно быть найдено
            }

            double result = ds.LoadFromDataFile(path);
            double wait = 11;

            Assert.AreEqual(wait, result);
            File.Delete(path);
        }

        [TestMethod]
        public void ValidLoadFromDataFile_MixedFormats()
        {
            DataService ds = new DataService();

            string path = Path.Combine(Path.GetTempPath(), "TestFileTask5V29_Mixed.txt");

            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("18");     // Должно быть найдено
                writer.WriteLine("11,0");  // Должно быть найдено
                writer.WriteLine("25.0");  // Должно быть найдено
                writer.WriteLine("15.5");
                writer.WriteLine("8,7");
            }

            double result = ds.LoadFromDataFile(path);
            double wait = 11; // Минимальное из 18, 11, 25

            Assert.AreEqual(wait, result);
            File.Delete(path);
        }
    }
}