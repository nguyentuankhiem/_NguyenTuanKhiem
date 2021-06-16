using System;

namespace ThamTri
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            Console.WriteLine($"gia tri ban dau: {num}");
            // su dung phuong thuc
            TangSo(num);
            Console.WriteLine($"gia tri sau khi dung phuong thuc: {num}");
            Console.ReadLine();
        }

        // method
        static void TangSo(int num)
        {
            num++;
            // parameter se duoc ra mot ban copy va khi ket thuc phuong thuc 
            // gia tri copy do se bien mat, gia tri goc khong thay doi

        }
    }
}
