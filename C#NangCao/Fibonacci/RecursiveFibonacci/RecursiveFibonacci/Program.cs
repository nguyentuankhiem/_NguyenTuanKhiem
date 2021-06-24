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
            while (true)
            {
                try
                {
                    Console.Write("Enter a number of fibonacci array: ");
                    int input = int.Parse(Console.ReadLine());
                    for (int i = 0; i < input; i++)
                    {
                        Console.Write(RecFin(i) + " ");
                    }
                    break;

                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }
            }
            Console.ReadKey();
        }
    }
}
