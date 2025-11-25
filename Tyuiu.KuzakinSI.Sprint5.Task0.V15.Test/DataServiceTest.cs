using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.KuzakinSI.Sprint5.Task0.V15.Lib;

namespace Tyuiu.KuzakinSI.Sprint5.Task0.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();
            
            int x = 3;
            string path = ds.SaveToFileTextData(x);

            // Проверяем существование файла
            Assert.IsTrue(File.Exists(path));

            // Читаем содержимое файла
            string fileContent = File.ReadAllText(path).Trim();
            string expected = "0.103"; // 3/(3^3+2) = 3/(27+2) = 3/29 ≈ 0.103448 → 0.103

            Assert.AreEqual(expected, fileContent);
        }
    }
}