using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст");
            string text = Console.ReadLine().ToLower();
            string [] words = text.Split(new char[] { ' ' });
            Dictionary<String, double> result = new Dictionary<string, double>();

            for (int i = 0; i < words.Length; i++)
            {
                double res = 0;
                foreach (string word in words) {
                    int compare = String.Compare(words[i], word);
                    if (compare == 0) res++;
                }
           if (!result.ContainsKey(words[i])) result.Add(words[i], res / words.Length);
            }
            foreach (var dict in result)
            {
                Console.WriteLine($"Слово: {dict.Key}, частота использования {dict.Value}");
            }
            Console.WriteLine("Число слов в тексте: {0}", words.Length);
                Console.ReadKey();
        }
    }
    
}
