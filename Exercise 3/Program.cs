namespace Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Find biggest and second biggest numbers
            int[] myNumbers = { 2, 1, 7, 4, 9, 5 };
            int biggest = Find_Biggest_Numbers.BiggestNumber(myNumbers);
            int Secondbiggest = Find_Biggest_Numbers.SecondBiggestNumber(myNumbers);
            Console.WriteLine("This is biggest number is " + biggest);
            Console.WriteLine("This is second biggest number is " + Secondbiggest);

            //Words exercises
            //string inputString = Console.ReadLine()/*"I hope you had a good weekend?"*/;
            //string capitalString = Words.CapitalizeFirstWords(inputString);
            //Console.WriteLine("Output: " + capitalString);
        }
    }
}