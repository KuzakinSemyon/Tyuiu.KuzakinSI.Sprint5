using System;
using System.IO;
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KuzakinSI.Sprint5.Task4.V21.Lib
{
    public class DataService : ISprint5Task4V21
    {
        public double LoadFromDataFile(string path)
        {
            // Чтение значения из файла
            string strValue = File.ReadAllText(path);
            
            // Используем InvariantCulture для корректного парсинга чисел с точкой
            double x = double.Parse(strValue, CultureInfo.InvariantCulture);

            // Вычисление значения по формуле: y = x^3 * cos(x) + 2x
            double y = Math.Pow(x, 3) * Math.Cos(x) + 2 * x;
            
            // Округление до трёх знаков после запятой
            return Math.Round(y, 3);
        }
    }
}