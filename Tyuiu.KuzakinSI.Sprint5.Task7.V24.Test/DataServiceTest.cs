using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Text;
using Tyuiu.KuzakinSI.Sprint5.Task7.V24.Lib;

namespace Tyuiu.KuzakinSI.Sprint5.Task7.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadDataAndSave()
        {
            DataService ds = new DataService();

            // Создаем временный файл с тестовыми данными
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V24.txt");
            string testData = "Привет мир! Hello world! 123,45 тест слово";
            File.WriteAllText(path, testData, Encoding.GetEncoding(1251));

            string outputPath = ds.LoadDataAndSave(path);

            // Проверяем существование выходного файла
            Assert.IsTrue(File.Exists(outputPath));

            // Проверяем содержимое выходного файла
            string result = File.ReadAllText(outputPath, Encoding.GetEncoding(1251));
            string expected = "слово слово! Hello world! 123,45 слово слово";

            Assert.AreEqual(expected, result);

            // Удаляем временные файлы
            File.Delete(path);
            File.Delete(outputPath);
        }
    }
}