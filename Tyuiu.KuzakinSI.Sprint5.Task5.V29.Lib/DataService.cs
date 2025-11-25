using System;
using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KuzakinSI.Sprint5.Task5.V29.Lib
{
    public class DataService : ISprint5Task5V29
    {
        public double LoadFromDataFile(string path)
        {
            // Читаем всю строку из файла
            string content = File.ReadAllText(path);
            
            // Разбиваем по пробелам на числа
            string[] numberStrings = content.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            
            double minTwoDigit = double.MaxValue;
            bool found = false;

            foreach (string numStr in numberStrings)
            {
                // Заменяем точку на запятую для парсинга
                string normalized = numStr.Replace('.', ',');
                
                if (double.TryParse(normalized, out double number))
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

            return found ? minTwoDigit : 0;
        }
    }
}