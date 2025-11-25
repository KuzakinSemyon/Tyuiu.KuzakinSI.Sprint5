using System;
using System.IO;
using Tyuiu.KuzakinSI.Sprint5.Task4.V21.Lib;

namespace Tyuiu.KuzakinSI.Sprint5.Task4.V21
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
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Кузякин Семён Игоревич | ПИНб-25-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл, в котором есть вещественное значение. Прочитать значение     *");
            Console.WriteLine("* из файла и подставить вместо X в формуле y = x^3 * cos(x) + 2x.        *");
            Console.WriteLine("* Вычислить значение по формуле (округлить до трёх знаков после запятой) *");
            Console.WriteLine("* и вернуть полученный результат на консоль.                             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            // Путь к файлу (создаем временный файл для демонстрации)
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask4V21.txt");
            
            // Создаем тестовый файл с значением
            File.WriteAllText(path, "2.5");

            Console.WriteLine($"Файл: {path}");
            Console.WriteLine($"Содержимое файла: {File.ReadAllText(path)}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.LoadFromDataFile(path);
            Console.WriteLine($"Результат вычисления: {result}");

            Console.ReadLine();
        }
    }
}