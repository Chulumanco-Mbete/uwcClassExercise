namespace Exercise_3
{
    internal class Find_Biggest_Numbers
    {
        public static int BiggestNumber(int[] numbers)
        {
            int max = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
                if (numbers[i] > max)
                    max = numbers[i];

            return max;
        }

        public static int SecondBiggestNumber(int[] numbers)
        {
            //int max = BiggestNumber(numbers);
            int max = Math.Max(numbers[0], numbers[5]);
            int result = Math.Min(numbers[0], numbers[5]);
            for (int i = 0; i < numbers.Length; ++i)
                if (numbers[i] >= max)
                    (result, max) = (max, numbers[i]);

            return result;
        }
    }
}
