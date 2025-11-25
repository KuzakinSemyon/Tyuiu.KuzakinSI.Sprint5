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
            string data = File.ReadAllText(path, Encoding.GetEncoding(1251)); // Кодировка для русских символов

            // Замена русских слов на "слово"
            string pattern = @"\b[А-Яа-яЁё]+\b";
            string result = Regex.Replace(data, pattern, "слово");

            // Сохранение результата в файл
            File.WriteAllText(outputPath, result, Encoding.GetEncoding(1251));

            return outputPath;
        }
    }
}