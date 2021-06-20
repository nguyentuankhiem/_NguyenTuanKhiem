using System;

namespace Calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------BASIC CALCULATION-----------");
            Console.WriteLine("1) Plus");
            Console.WriteLine("2) Substraction");
            Console.WriteLine("3) Multiplication");
            Console.WriteLine("4) Division");
            Console.Write("Enter a number (1-4): ");
            int input = int.Parse(Console.ReadLine());

            // check answer
            while (input > 4)
            {
                Console.Write("Try again, enter a number (1-4): ");
                input = int.Parse(Console.ReadLine());
            }
            // number to calculate
            Console.Write("Enter first value: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second value: ");
            int b = int.Parse(Console.ReadLine());
            double total;

            // switch
            switch (input)
            {
                default:
                case 1:
                    total = a + b;
                    Console.WriteLine($"{a} + {b} = {total}");
                    break;
                case 2:
                    total = a - b;
                    Console.WriteLine($"{a} - {b} = {total}");
                    break;
                case 3:
                    total = a * b;
                    Console.WriteLine($"{a} x {b} = {total}");
                    break;
                case 4:
                    total = (double) a / b;
                    Console.WriteLine($"{a} / {b} = {Math.Round(total, 2)}");
                    break;
            }

            Console.ReadLine();

        }
    }
}
