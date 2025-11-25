using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KuzakinSI.Sprint5.Task2.V19.Lib
{
    public class DataService : ISprint5Task2V19
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            
            // Создаем копию массива и заменяем нечетные элементы на 0
            int[,] resultMatrix = (int[,])matrix.Clone();
            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (resultMatrix[i, j] % 2 != 0)
                    {
                        resultMatrix[i, j] = 0;
                    }
                }
            }

            // Создание пути к файлу
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");

            // Запись результата в CSV файл
            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int i = 0; i < rows; i++)
                {
                    string line = "";
                    for (int j = 0; j < cols; j++)
                    {
                        line += resultMatrix[i, j];
                        if (j < cols - 1)
                        {
                            line += ";";
                        }
                    }
                    writer.WriteLine(line);
                }
            }

            return path;
        }
    }
}