using System;

namespace ArraySubsetForSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), bTemp => Convert.ToInt32(bTemp));

            int sum = Convert.ToInt32(Console.ReadLine());

            ArraySubset.FindRequiredSumSubArray(array, sum);

            Console.ReadKey();
        }
    }
}
