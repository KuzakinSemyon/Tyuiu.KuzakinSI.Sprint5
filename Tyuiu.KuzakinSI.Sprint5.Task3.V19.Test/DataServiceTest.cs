using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.KuzakinSI.Sprint5.Task3.V19.Lib;

namespace Tyuiu.KuzakinSI.Sprint5.Task3.V19.Test
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

            // Читаем содержимое бинарного файла
            string fileContent;
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                fileContent = reader.ReadString();
            }

            string expected = "17.556"; // 2*3^(1.5)-1/(√3-2) = (2*5.196-1)/(1.732-2) = (10.392-1)/(-0.268) = 9.392/(-0.268) ≈ -35.044 → проверка!

            // Пересчет: 2*3^(3/2)-1 = 2*√27-1 = 2*5.196-1 = 10.392-1 = 9.392
            // √3-2 = 1.732-2 = -0.268
            // 9.392/(-0.268) ≈ -35.044
            // Ожидаемое значение: -35.044

            Assert.AreEqual("-35.044", fileContent);
        }
    }
}