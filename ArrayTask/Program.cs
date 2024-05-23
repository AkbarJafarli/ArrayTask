namespace ArrayTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 11, 12, 13, 14, 15, 16, 17, 18, 19, };
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    Console.Write(numbers[i]);
                    break;
                }
                Console.Write(numbers[i] + ",");

            }
        }
    }
}
