using System;
using System.IO;
using Tyuiu.KuzakinSI.Sprint5.Task1.V6.Lib;

namespace Tyuiu.KuzakinSI.Sprint5.Task1.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Кузякин Семён Игоревич | ПИНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                       *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Кузякин Семён Игоревич | ПИНб-25-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция: F(x) = cos(x) + (4x)/2 - sin(x)*3x                       *");
            Console.WriteLine("* Произвести табулирование f(x) на диапазоне [-5; 5] с шагом 1.          *");
            Console.WriteLine("* Произвести проверку деления на ноль. При делении на ноль вернуть 0.    *");
            Console.WriteLine("* Результат сохранить в текстовый файл OutPutFileTask1.txt и вывести     *");
            Console.WriteLine("* на консоль в таблицу. Значения округлить до двух знаков после запятой. *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine($"Старт диапазона = {startValue}");
            Console.WriteLine($"Конец диапазона = {stopValue}");
            Console.WriteLine($"Шаг = 1");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            // Сохранение в файл
            string path = ds.SaveToFileTextData(startValue, stopValue);

            // Вывод содержимого файла на консоль
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine();
            Console.WriteLine($"Файл сохранен: {path}");

            Console.ReadLine();
        }
    }
}