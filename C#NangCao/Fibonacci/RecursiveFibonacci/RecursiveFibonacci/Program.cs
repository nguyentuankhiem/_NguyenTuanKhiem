using System;

namespace RecursiveFibonacci
{
    class Program
    {
        static int RecFin(int n)
        {
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
                return RecFin(n - 1) + RecFin(n - 2);
            }
        }
        static void Main(string[] args)
        {
            // cach 2
            Console.WriteLine("First 10 numbers of Recursive Fibonacci");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($" {RecFin(i)}");
            }
            Console.ReadKey();
        }
    }
}
