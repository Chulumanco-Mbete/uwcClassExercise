namespace Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string reversedString = Reverse(Console.ReadLine());
            Console.WriteLine("Output: " + reversedString);
        }

        static string Reverse(string text)
        {
            string reverse = String.Empty;
            for (int i = text.Length - 1; i > -1; i--)
            {
                reverse += text[i];
            }
            return reverse;
        }
    }
}
