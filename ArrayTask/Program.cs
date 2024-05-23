namespace ArrayTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = { 11, 12, 13, 14, 15, 16, 17, 18, 19, };
            //for (int i = numbers.Length - 1; i >= 0; i--)
            //{
            //    if (i == 0)
            //    {
            //        Console.Write(numbers[i]);
            //        break;
            //    }
            //    Console.Write(numbers[i] + ",");



            //}

            //======================================================
            //======================================================


            //int[] numbers1 = { 1, 2, 3 };
            //int[] numbers2 = { 9, 10, 11, 12, 13, 14, 15, 16, 1, 2, 3 };
            //bool isExist = false;
            //for (int i = 0; i < numbers1.Length; i++)
            //{
            //    for (int j = 0; j < numbers2.Length; j++)
            //    {
            //        if (numbers1[i] == numbers2[j])
            //        {
            //            isExist = true;
            //            break;
            //        }
            //        else
            //        {
            //            isExist = false;
            //        }

            //    }

            //}
            //if (isExist)
            //{
            //    Console.WriteLine("Movcuddur");
            //}
            //else
            //{
            //    Console.WriteLine("Movcud deyil");
            //}

            //======================================================
            //======================================================


            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
            bool isDublicate = false;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    isDublicate = true;
                    break;
                }
            }
            if (isDublicate)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }



        }
    }
}
