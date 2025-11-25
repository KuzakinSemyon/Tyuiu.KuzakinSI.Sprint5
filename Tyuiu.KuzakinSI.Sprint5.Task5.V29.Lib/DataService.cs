using System;
using System.IO;
using System.Globalization;
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

                    // Заменяем точку на запятую для корректного парсинга
                    string normalizedLine = line.Replace('.', ',');
                    
                    if (double.TryParse(normalizedLine, NumberStyles.Any, CultureInfo.GetCultureInfo("ru-RU"), out double number))
                    {
                        // Проверяем, что число целое и двузначное
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

            if (!found)
            {
                throw new Exception("В файле не найдено двузначных целых чисел");
            }

            return Math.Round(minTwoDigit, 3);
        }
    }
}