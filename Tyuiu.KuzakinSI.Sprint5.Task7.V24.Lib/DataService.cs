using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KuzakinSI.Sprint5.Task7.V24.Lib
{
    public class DataService : ISprint5Task7V24
    {
        public string LoadDataAndSave(string path)
        {
            string outputPath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V24.txt");

            // Чтение данных из файла
            string data = File.ReadAllText(path, Encoding.UTF8);

            // Замена русских слов на "слово"
            // Паттерн для поиска последовательностей русских букв
            string pattern = @"[А-Яа-яЁё]+";
            string result = Regex.Replace(data, pattern, "слово");

            // Сохранение результата в файл
            File.WriteAllText(outputPath, result, Encoding.UTF8);

            return outputPath;
        }
    }
}