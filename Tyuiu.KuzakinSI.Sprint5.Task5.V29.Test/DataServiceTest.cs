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
            
            File.WriteAllText(path, @"10
3,4
15
11
5,6
25");

            double result = ds.LoadFromDataFile(path);
            double wait = 10; // Минимальное двузначное целое: 10, 11, 15, 25

            Assert.AreEqual(wait, result);
            File.Delete(path);
        }
    }
}