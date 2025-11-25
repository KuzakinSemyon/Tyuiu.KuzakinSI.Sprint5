using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KuzakinSI.Sprint5.Task6.V7.Lib
{
    public class DataService : ISprint5Task6V7
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            
            // Чтение всего содержимого файла
            string data = File.ReadAllText(path);
            
            // Подсчет строчных латинских букв
            foreach (char c in data)
            {
                if (char.IsLower(c) && ((c >= 'a' && c <= 'z')))
                {
                    count++;
                }
            }
            
            return count;
        }
    }
}