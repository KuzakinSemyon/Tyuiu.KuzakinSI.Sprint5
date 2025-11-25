using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.KuzakinSI.Sprint5.Task6.V7.Lib;

namespace Tyuiu.KuzakinSI.Sprint5.Task6.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();

            // Создаем временный файл с тестовыми данными
            string path = Path.GetTempFileName();
            
            // Записываем тестовые данные в файл
            string testData = "Hello world! abc 123 xyz";
            File.WriteAllText(path, testData);

            int result = ds.LoadFromDataFile(path);
            int wait = 15; // h,e,l,l,o,w,o,r,l,d,a,b,c,x,y,z

            Assert.AreEqual(wait, result);

            // Удаляем временный файл
            File.Delete(path);
        }
    }
}