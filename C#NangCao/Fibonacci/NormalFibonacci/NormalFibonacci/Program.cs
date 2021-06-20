using System;

namespace NormalFibonacci
{
    class Program
    {
        static int NorFin(int n)
        {
            int f0 = 1;
            int f1 = 1;
            int fn = 1;

            if (n < 0)
            {
                return -1;
            }
            else if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                for (int i = 2; i < n; i++)
                {
                    f0 = f1;
                    f1 = fn;
                    fn = f0 + f1;
                }
            }
            return fn;
        }
        static void Main(string[] args)
        {
            // cach 1
            Console.WriteLine("First 10 numbers of Normal Fibonacci: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($" {NorFin(i)}");
            }
            Console.ReadKey();
        }
    }
}
