using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KuzakinSI.Sprint5.Task3.V19.Lib
{
    public class DataService : ISprint5Task3V19
    {
        public string SaveToFileTextData(int x)
        {
            // Вычисление значения функции
            double numerator = 2 * Math.Pow(x, (double)x / 2) - 1;
            double denominator = Math.Sqrt(x) - 2;
            
            // Проверка деления на ноль
            if (Math.Abs(denominator) < 0.0001)
            {
                throw new DivideByZeroException("Знаменатель равен нулю");
            }
            
            double result = numerator / denominator;
            result = Math.Round(result, 3);

            // Создание пути к файлу
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            // Запись результата в бинарный файл
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
            {
                writer.Write(result.ToString());
            }

            return path;
        }
    }
}