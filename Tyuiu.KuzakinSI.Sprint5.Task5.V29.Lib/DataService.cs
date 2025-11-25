using System;
using System.IO;
using System.Globalization;
using System.Linq;
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
                    // Пропускаем пустые строки
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    // Убираем лишние пробелы
                    line = line.Trim();

                    // Пытаемся распарсить число в разных форматах
                    double number;
                    
                    // Пробуем парсить с точкой (английский формат)
                    if (double.TryParse(line, NumberStyles.Any, CultureInfo.InvariantCulture, out number))
                    {
                        ProcessNumber(number, ref minTwoDigit, ref found);
                    }
                    // Пробуем парсить с запятой (русский формат)
                    else if (double.TryParse(line, NumberStyles.Any, CultureInfo.GetCultureInfo("ru-RU"), out number))
                    {
                        ProcessNumber(number, ref minTwoDigit, ref found);
                    }
                    // Если оба способа не сработали, пробуем заменить запятую на точку
                    else if (line.Contains(','))
                    {
                        string normalizedLine = line.Replace(',', '.');
                        if (double.TryParse(normalizedLine, NumberStyles.Any, CultureInfo.InvariantCulture, out number))
                        {
                            ProcessNumber(number, ref minTwoDigit, ref found);
                        }
                    }
                }
            }

            if (!found)
            {
                return 0;
            }

            return Math.Round(minTwoDigit, 3);
        }

        private void ProcessNumber(double number, ref double minTwoDigit, ref bool found)
        {
            // Проверяем, является ли число целым и двузначным
            if (IsInteger(number) && number >= 10 && number <= 99)
            {
                if (number < minTwoDigit)
                {
                    minTwoDigit = number;
                    found = true;
                }
            }
        }

        private bool IsInteger(double number)
        {
            return Math.Abs(number - Math.Round(number)) < 0.000001;
        }
    }
}