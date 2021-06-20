using System;

namespace Out
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            Console.WriteLine($"gia tri ban dau: {num}");
            // su dung phuong thuc
            TangSo(out num); // gia tri ban dau khi chua co out la 5
            Console.WriteLine($"gia tri sau khi dung phuong thuc: {num}"); // gia tri sau khi dung phuong thuc la 2
            Console.ReadLine();
        }

        // method
        static void TangSo(out int num)
        {
            num = 1;
            num++;
            // khi su dung phuong thuc co chua out thi ta khong can phai khai bao gia tri ban dau
            // tham chieu bang out giong nhu mot noi chua ket qua tra ve

        }
    }
}
