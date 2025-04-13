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
            var result = new StringBuilder();
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                    result.Append(c);
            }
            return result.ToString();
        }

        public static string FilterPunctuation(string input) // Фильтр знаков пунктуации
        {
            var result = new StringBuilder();
            foreach (char c in input)
            {
                if (char.IsPunctuation(c))
                    result.Append(c);
            }
            return result.ToString();
        }

        public static string FilterRussian(string input) // Фильтр русских симловов
        {
            var result = new StringBuilder();
            foreach (char c in input)
            {
                if ((c >= 'А' && c <= 'Я') || (c >= 'а' && c <= 'я') || c == 'Ё' || c == 'ё')
                    result.Append(c);
            }
            return result.ToString();
        }

        public static string FilterLatin(string input) // Фильтр латинских симловов
        {
            var result = new StringBuilder();
            foreach (char c in input)
            {
                if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
                    result.Append(c);
            }
            return result.ToString();
        }
    }
}
