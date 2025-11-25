using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KuzakinSI.Sprint5.Task0.V15.Lib
{
    public class DataService : ISprint5Task0V15
    {
        public string SaveToFileTextData(int x)
        {
            // Вычисление значения функции
            double result = (double)x / (Math.Pow(x, 3) + 2);
            result = Math.Round(result, 3);

            // Создание пути к файлу
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");

            // Запись результата в файл
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine(result);
            }

            return path;
        }
    }
}