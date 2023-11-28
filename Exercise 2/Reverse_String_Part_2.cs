namespace Exercise_2
{ 
    internal class Reverse_String_Part_2
    {
        static void Main(string[] args)
        {
            bool forwardBackwardResult = IsSameForwardsAndBackwards(Console.ReadLine());
        }

        static bool IsSameForwardsAndBackwards(string FrontBackText)
        {
            string reverse = String.Empty;
            for (int i = FrontBackText.Length - 1; i > -1; i--)
            {
                reverse += FrontBackText[i];
            }

            if (FrontBackText == reverse)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            return false;
        }
    }
}