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

            // Проверяем содержимое файла
            string fileContent = File.ReadAllText(path);
            string expected = "4,67\n0,43\n-8,26\n-9,87\n-3,98\n1\n0,02\n-1,87\n3,74\n16,43\n24,67";

            Assert.AreEqual(expected, fileContent);
        }
    }
}