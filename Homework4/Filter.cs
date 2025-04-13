using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    delegate string FilterDelegate(string input);

    internal class Filter
    {
        public static string FilterDigits(string input) // Фильтр чисел 
        {
            string result = "";
            foreach (char c in input)
                if (char.IsDigit(c))
                    result += c;
            return result;
        }

        public static string FilterPunctuation(string input) // Фильтр знаков пунктуации
        {
            string result = "";
            foreach (char c in input)
                if (char.IsPunctuation(c))
                    result += c;
            return result;
        }

        public static string FilterRussian(string input) // Фильтр русских символов
        {
            string result = "";
            foreach (char c in input)
                if ((c >= 'А' && c <= 'Я') || (c >= 'а' && c <= 'я') || c == 'Ё' || c == 'ё')
                    result += c;
            return result;
        }

        public static string FilterLatin(string input) // Фильтр латинских символов
        {
            string result = "";
            foreach (char c in input)
                if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
                    result += c;
            return result;
        }
    }
}
