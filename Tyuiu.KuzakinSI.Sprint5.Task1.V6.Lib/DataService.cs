using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KuzakinSI.Sprint5.Task1.V6.Lib
{
    public class DataService : ISprint5Task1V6
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int x = startValue; x <= stopValue; x++)
                {
                    double denominator = 2;
                    double value;

                    // Проверка деления на ноль
                    if (Math.Abs(denominator) < 0.0001)
                    {
                        value = 0;
                    }
                    else
                    {
                        value = Math.Cos(x) + (4 * x) / denominator - Math.Sin(x) * 3 * x;
                        value = Math.Round(value, 2);
                    }

                    // Заменяем точку на запятую для русской локали
                    string valueStr = value.ToString().Replace('.', ',');
                    
                    // Записываем значение, кроме последней строки добавляем \n
                    if (x < stopValue)
                    {
                        writer.WriteLine(valueStr);
                    }
                    else
                    {
                        writer.Write(valueStr);
                    }
                }
            }

            return path;
        }
    }
}