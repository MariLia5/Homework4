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

            // Записываем в файл
            File.WriteAllText("output.txt",
                $"1(цифры): {digits}\n" +
                $"2(знаки препинания): {punctuation}\n" +
                $"3(русские символы): {russian}\n" +
                $"4(латинские символы): {latin}");

            Console.WriteLine("Результат сохранён в output.txt");
            Console.WriteLine(File.ReadAllText("output.txt"));
        }
    }
}
