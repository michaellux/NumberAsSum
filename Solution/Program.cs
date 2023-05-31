namespace Solution.Library
{
    public static class Program
    {
        public static bool CanSum(int[] numbers, int targetSum)
        {
            if (targetSum == 0)
            {
                return true;
            }
            if (targetSum < 0)
            {
                return false;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                int remainder = targetSum - numbers[i];
                if (CanSum(numbers.Skip(i + 1).ToArray(), remainder))
                {
                    return true;
                }
            }
            return false;
        }

        static void Main(string[] args)
        {

        }
    }
}