using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;
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

            // Читаем содержимое файла как байты и конвертируем в base64
            byte[] fileBytes = File.ReadAllBytes(path);
            string fileContentBase64 = Convert.ToBase64String(fileBytes);

            // Ожидаемое значение в base64
            string expectedBase64 = "MzMzMzOzGUA=";

            Assert.AreEqual(expectedBase64, fileContentBase64);
        }
    }
}