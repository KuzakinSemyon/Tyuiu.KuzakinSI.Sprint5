using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.KuzakinSI.Sprint5.Task5.V29.Lib;

namespace Tyuiu.KuzakinSI.Sprint5.Task5.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile_WithDot()
        {
            DataService ds = new DataService();

            string path = Path.Combine(Path.GetTempPath(), "TestFileTask5V29_Dot.txt");
            
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("15.5");
                writer.WriteLine("23.0");  // двузначное целое
                writer.WriteLine("45.7");
                writer.WriteLine("12");    // двузначное целое
                writer.WriteLine("8.7");
                writer.WriteLine("99.00"); // двузначное целое
                writer.WriteLine("3.14");
            }

            double result = ds.LoadFromDataFile(path);
            double wait = 12; // Минимальное двузначное целое число

            Assert.AreEqual(wait, result);
            File.Delete(path);
        }

        [TestMethod]
        public void ValidLoadFromDataFile_WithComma()
        {
            DataService ds = new DataService();

            string path = Path.Combine(Path.GetTempPath(), "TestFileTask5V29_Comma.txt");
            
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("15,5");
                writer.WriteLine("23,0");  // двузначное целое
                writer.WriteLine("45,7");
                writer.WriteLine("12");    // двузначное целое
                writer.WriteLine("8,7");
                writer.WriteLine("99,00"); // двузначное целое
                writer.WriteLine("3,14");
            }

            double result = ds.LoadFromDataFile(path);
            double wait = 12; // Минимальное двузначное целое число

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
                writer.WriteLine("15.5");
                writer.WriteLine("23,0");  // двузначное целое с запятой
                writer.WriteLine("45.7");
                writer.WriteLine("18");    // двузначное целое без разделителя
                writer.WriteLine("8,7");
                writer.WriteLine("99.00"); // двузначное целое с точкой
                writer.WriteLine("3,14");
            }

            double result = ds.LoadFromDataFile(path);
            double wait = 18; // Минимальное двузначное целое число

            Assert.AreEqual(wait, result);
            File.Delete(path);
        }

        [TestMethod]
        public void ValidLoadFromDataFile_NoTwoDigitNumbers()
        {
            DataService ds = new DataService();

            string path = Path.Combine(Path.GetTempPath(), "TestFileTask5V29_NoTwoDigit.txt");
            
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("1.5");
                writer.WriteLine("2.3");
                writer.WriteLine("4.5");
                writer.WriteLine("8.7");
                writer.WriteLine("3.14");
                writer.WriteLine("100");
                writer.WriteLine("9");
            }

            double result = ds.LoadFromDataFile(path);
            double wait = 0;

            Assert.AreEqual(wait, result);
            File.Delete(path);
        }
    }
}