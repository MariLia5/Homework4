using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework4
{
    class Program
    {
       
        static void Main()
        {
            Console.WriteLine("Введите строку для анализа:");
            string input = Console.ReadLine();

            // Создаем фильтры через делегаты
            FilterDelegate digitFilter = Filter.FilterDigits;
            FilterDelegate punctFilter = Filter.FilterPunctuation;
            FilterDelegate russianFilter = Filter.FilterRussian;
            FilterDelegate latinFilter = Filter.FilterLatin;

            // Применяем фильтры
            string digits = digitFilter(input);
            string punctuation = punctFilter(input);
            string russian = russianFilter(input);
            string latin = latinFilter(input);

            // Запись в файл
            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                writer.WriteLine($"1(цифры): {digits}");
                writer.WriteLine($"2(знаки препинания): {punctuation}");
                writer.WriteLine($"3(русские символы): {russian}");
                writer.WriteLine($"4(латинские символы): {latin}");
            }


            // Чтение из файла и вывод на консоль
            Console.WriteLine("\nРезультат сохранён в output.txt:");
            using (StreamReader reader = new StreamReader("output.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}