using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KuzakinSI.Sprint5.Task5.V29.Lib
{
    public class DataService : ISprint5Task5V29
    {
        public double LoadFromDataFile(string path)
        {
            double minTwoDigit = double.MaxValue;
            bool found = false;

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                
                while ((line = reader.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;
                    throw new Exception($"Содержимое файла:\n{string.Join("\n", File.ReadAllLines(path))}");
                    // Заменяем запятую на точку для парсинга
                    line = line.Replace(',', '.');

                    if (double.TryParse(line, out double number))
                    {
                        // Проверяем целое число в диапазоне 10-99
                        if (number == Math.Floor(number) && number >= 10 && number <= 99)
                        {
                            if (number < minTwoDigit)
                            {
                                minTwoDigit = number;
                                found = true;
                            }
                        }
                    }
                }
            }

            return found ? minTwoDigit : 0;
        }
    }
}