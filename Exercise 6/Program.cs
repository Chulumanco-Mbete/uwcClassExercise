namespace Exercise_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -1, 2, 4, 6, 9 };
            Console.WriteLine("Original Array elements:");
            foreach (var item in nums)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine(test(nums));
        }

        static string test(int[] nums)
        {
            var pos = nums.Where(n => n > 0);
            var neg = nums.Where(n => n < 0);
            return "\nPositive numbers: " + pos.Count() + "\nNegative numbers: " + neg.Count();
        }
    }
}
