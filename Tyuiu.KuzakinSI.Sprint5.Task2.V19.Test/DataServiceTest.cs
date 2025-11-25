using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.KuzakinSI.Sprint5.Task2.V19.Lib;

namespace Tyuiu.KuzakinSI.Sprint5.Task2.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();
            
            int[,] matrix = {
                {9, 2, 5},
                {8, 8, 2},
                {7, 4, 8}
            };
            
            string path = ds.SaveToFileTextData(matrix);

            // Проверяем существование файла
            Assert.IsTrue(File.Exists(path));

            // Читаем содержимое файла
            string[] fileContent = File.ReadAllLines(path);
            
            string[] expectedLines = {
                "0;2;0",
                "8;8;2", 
                "0;4;8"
            };

            CollectionAssert.AreEqual(expectedLines, fileContent);
        }
    }
}