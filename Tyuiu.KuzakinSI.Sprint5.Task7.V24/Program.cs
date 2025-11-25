using System;
using System.IO;
using System.Text;
using Tyuiu.KuzakinSI.Sprint5.Task7.V24.Lib;

namespace Tyuiu.KuzakinSI.Sprint5.Task7.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Кузякин Семён Игоревич | ПИНб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка текстовых файлов                                        *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Кузякин Семён Игоревич | ПИНб-25-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл, в котором есть набор символьных данных. Заменить все русские *");
            Console.WriteLine("* слова на слово 'слово'. Полученный результат сохранить в файл          *");
            Console.WriteLine("* OutPutDataFileTask7V24.txt.                                            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            // Создаем тестовый файл для демонстрации
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V24.txt");
            string testData = "Привет, World! This моя Первая программа.";
            File.WriteAllText(path, testData, Encoding.UTF8);

            Console.WriteLine($"Входной файл: {path}");
            Console.WriteLine("Исходные данные:");
            Console.WriteLine(File.ReadAllText(path, Encoding.UTF8));

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string outputPath = ds.LoadDataAndSave(path);

            Console.WriteLine($"Выходной файл: {outputPath}");
            Console.WriteLine("Результат обработки:");
            Console.WriteLine(File.ReadAllText(outputPath, Encoding.UTF8));

            Console.ReadLine();
        }
    }
}