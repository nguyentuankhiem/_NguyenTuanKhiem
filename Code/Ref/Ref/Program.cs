using System;

namespace Ref
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            Console.WriteLine($"gia tri ban dau: {num}");
            // su dung phuong thuc
            TangSo(ref num); // luu y khi goi phuong thuc thi parameter cung phai co ref
            Console.WriteLine($"gia tri sau khi dung phuong thuc: {num}");
            Console.ReadLine();
        }

        // method
        static void TangSo(ref int num)
        {
            num++;
            // parameter se duoc su dung truc tiep chu khong tao ra mot ban copy
            
        }
    }
}
