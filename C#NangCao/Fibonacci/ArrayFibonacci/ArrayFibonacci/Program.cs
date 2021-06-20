using System;

namespace ArrayFibonacci
{
    class Program
    {
        static int[] ArrFin(int n)
        {
            int[] arr = new int[n];
            arr[0] = 0;
            arr[1] = 1;
            for (int i = 2; i < n; i++)
            {
                arr[i] = arr[i - 2] + arr[i - 1];
            }
            string msg = string.Join(" ", arr);
            return arr;
        }
        static void Main(string[] args)
        {
            // cach 3
            Console.WriteLine("First 10 numbers of Array Fibonacci");
            var ex = ArrFin(10);
            foreach (var item in ex)
            {
                Console.Write(" " + item);
            }
            Console.ReadKey();
        }
    }
}
