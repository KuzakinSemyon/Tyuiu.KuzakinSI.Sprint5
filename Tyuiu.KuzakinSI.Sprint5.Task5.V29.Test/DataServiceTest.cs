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

            string path = Path.Combine(Path.GetTempPath(), "TestFile.txt");
            
            File.WriteAllText(path, "5 9 18 -0.48 18.17 12 11 -4.71 -5.7 18 -3.92 -4 -1.03 9 8.08 2.78 8.76 -9.75 -3 -4");

            double result = ds.LoadFromDataFile(path);
            double wait = 11; // Минимальное двузначное целое: 18, 12, 11

            Assert.AreEqual(wait, result);
            File.Delete(path);
        }
    }
}