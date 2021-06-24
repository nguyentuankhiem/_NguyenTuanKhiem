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
            ưhile (true)
            {
                try 
                {
                    Console.Write("Enter a number of fibonacci array: ");
                    int input = int.Parse(Console.ReadLine());
                    var arr = ArrFin(input);
                    foreach (var item in arr)
                    {
                        Console.Write(item + " ");
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
