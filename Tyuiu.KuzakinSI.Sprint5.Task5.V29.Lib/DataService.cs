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
                int lineNumber = 0;

                while ((line = reader.ReadLine()) != null)
                {
                    lineNumber++;

                    // Пропускаем пустые строки
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    // Убираем лишние пробелы
                    line = line.Trim();

                    // ЗАМЕНЯЕМ ЗАПЯТУЮ НА ТОЧКУ ПЕРЕД ПАРСИНГОМ
                    string normalizedLine = line.Replace(',', '.');

                    // Пытаемся распарсить число
                    double number;
                    bool parsed = false;

                    // Пробуем парсить как целое число (если нет точки после замены)
                    if (!normalizedLine.Contains('.') && int.TryParse(normalizedLine, out int intNumber))
                    {
                        number = intNumber;
                        parsed = true;
                    }
                    // Пробуем парсить как double
                    else if (double.TryParse(normalizedLine, NumberStyles.Any, CultureInfo.InvariantCulture, out number))
                    {
                        parsed = true;
                    }

                    if (parsed)
                    {
                        // Отладочный вывод
                        Console.WriteLine($"Строка {lineNumber}: '{line}' -> '{normalizedLine}' -> {number} (целое: {IsInteger(number)}, двузначное: {number >= 10 && number <= 99})");

                        // Проверяем, является ли число целым и двузначным
                        if (IsInteger(number) && number >= 10 && number <= 99)
                        {
                            if (number < minTwoDigit)
                            {
                                minTwoDigit = number;
                                found = true;
                                Console.WriteLine($"Найдено двузначное число: {number}");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Строка {lineNumber}: '{line}' -> '{normalizedLine}' -> НЕ ПАРСИТСЯ");
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine("Двузначных целых чисел не найдено");
                return 0;
            }

            Console.WriteLine($"Минимальное двузначное число: {minTwoDigit}");
            return Math.Round(minTwoDigit, 3);
        }

        private bool IsInteger(double number)
        {
            return Math.Abs(number - Math.Round(number)) < 0.000001;
        }
    }
}