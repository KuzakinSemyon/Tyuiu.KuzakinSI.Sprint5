using System;
using System.IO;
using Tyuiu.KuzakinSI.Sprint5.Task0.V15.Lib;

namespace Tyuiu.KuzakinSI.Sprint5.Task0.V15
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
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Кузякин Семён Игоревич | ПИНб-25-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение: s(x) = x/(x^3 + 2). Вычислить значение при x = 3,      *");
            Console.WriteLine("* результат сохранить в текстовый файл OutPutFileTask0.txt и вывести     *");
            Console.WriteLine("* на консоль. Округлить до трёх знаков после запятой.                    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 3;
            Console.WriteLine($"x = {x}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            // Вычисление и сохранение в файл
            string path = ds.SaveToFileTextData(x);

            // Чтение результата из файла для вывода на консоль
            string result = File.ReadAllText(path).Trim();
            
            Console.WriteLine($"Результат: {result}");
            Console.WriteLine($"Файл сохранен: {path}");

            Console.ReadLine();
        }
    }
}