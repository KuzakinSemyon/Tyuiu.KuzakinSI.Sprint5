using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KuzakinSI.Sprint5.Task4.V21.Lib
{
    public class DataService : ISprint5Task4V21
    {
        public double LoadFromDataFile(string path)
        {
            // Чтение значения из файла
            string strValue = File.ReadAllText(path);
            double x = Convert.ToDouble(strValue);

            // Вычисление значения по формуле: y = x^3 * cos(x) + 2x
            double y = Math.Pow(x, 3) * Math.Cos(x) + 2 * x;
            
            // Округление до трёх знаков после запятой
            return Math.Round(y, 3);
        }
    }
}