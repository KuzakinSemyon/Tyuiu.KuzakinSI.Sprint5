using System;
using System.IO;
using Tyuiu.KuzakinSI.Sprint5.Task5.V29.Lib;

namespace Tyuiu.KuzakinSI.Sprint5.Task5.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Кузякин Семён Игоревич | ПИНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                         *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Кузякин Семён Игоревич | ПИНб-25-1                            *");
            Console.WriteLine("***************************************************************************");

            string path = "/app/data/AssesmentData/C#/Sprint5Task5/InPutDataFileTask5V29.txt";
            
            Console.WriteLine($"Путь к файлу: {path}");

            if (!File.Exists(path))
            {
                Console.WriteLine("Файл не существует!");
                return;
            }

            string content = File.ReadAllText(path);
            Console.WriteLine($"Содержимое файла: {content}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.LoadFromDataFile(path);
            
            if (result == 0)
            {
                Console.WriteLine("В файле не найдено двузначных целых чисел");
            }
            else
            {
                Console.WriteLine($"Минимальное двузначное целое число: {result}");
            }

            Console.ReadLine();
        }
    }
}