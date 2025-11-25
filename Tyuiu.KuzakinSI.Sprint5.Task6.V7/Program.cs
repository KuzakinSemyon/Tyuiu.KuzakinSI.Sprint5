using System;
using System.IO;
using Tyuiu.KuzakinSI.Sprint5.Task6.V7.Lib;

namespace Tyuiu.KuzakinSI.Sprint5.Task6.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Кузякин Семён Игоревич | ПИНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Кузякин Семён Игоревич | ПИНб-25-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл, в котором есть набор символьных данных. Найти количество      *");
            Console.WriteLine("* строчных латинских букв в заданной строке.                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            // Создаем тестовый файл с данными
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask6V7.txt");
            
            // Тестовые данные для демонстрации
            string testData = "Hello World! abc 123 xyz Test Data 456";
            File.WriteAllText(path, testData);

            Console.WriteLine($"Данные из файла: {testData}");
            Console.WriteLine($"Файл находится: {path}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.LoadFromDataFile(path);
            Console.WriteLine($"Количество строчных латинских букв = {result}");

            Console.ReadLine();
        }
    }
}