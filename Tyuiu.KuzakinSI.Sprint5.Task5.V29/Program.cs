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
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл в котором есть набор значений. Найти минимальное целое число  *");
            Console.WriteLine("* в файле, которое является двузначным числом.                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = "/app/data/AssesmentData/C#/Sprint5Task5/InPutDataFileTask5V29.txt";
            
            Console.WriteLine($"Путь к файлу: {path}");
            Console.WriteLine("Содержимое файла:");

            if (File.Exists(path))
            {
                try
                {
                    string[] lines = File.ReadAllLines(path);
                    for (int i = 0; i < lines.Length; i++)
                    {
                        Console.WriteLine($"[{i}] {lines[i]} (длина: {lines[i].Length})");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Файл не существует!");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            try
            {
                double result = ds.LoadFromDataFile(path);
                
                if (result == 0)
                {
                    Console.WriteLine("В файле не найдено двузначных целых чисел");
                }
                else
                {
                    Console.WriteLine($"Минимальное двузначное целое число: {result}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.ReadLine();
        }
    }
}