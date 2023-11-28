using System.Text.RegularExpressions;

namespace Exercise_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine()/*"Hello World"*/;
            Console.WriteLine("Orginal string: " + text);
            Console.WriteLine("After removing all the vowels from the said string: " + test(text));
        }

        static string test(string text)
        {
                return new Regex(@"[aeiouAEIOU]").Replace(text, "");
        }
    }
}
