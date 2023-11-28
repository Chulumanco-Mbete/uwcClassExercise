namespace Exercise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 4, 9, 12 };
            Console.WriteLine("Original array: [{0}]", string.Join(", ", nums));
            Console.WriteLine("Does this array contain an odd number? (true/false): " + even_odd(nums));
        }

        public static bool even_odd(int[] nums)
        {
            foreach (var n in nums)
            {
                if (n % 2 != 0)
                    return true;
            }
            return false;
        }
    }
}
