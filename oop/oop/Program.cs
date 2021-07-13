using System;
using System.Collections.Generic;

namespace oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.Write("Số lượng hóa đơn muốn nhập: ");
            int slhd;
            while (true)
            {
                try
                {
                    slhd = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.Write("\nSố lượng hóa đơn muốn nhập: ");
                }
            }
            // tao hoa don
            List<HoaDon> lhd = new List<HoaDon>();
            for (int i = 1; i <= slhd; i++)
            {
                Console.WriteLine($"\nNhập thông tin hóa đơn {i}:");
                HoaDon hd = new HoaDon();
                hd.taoHD();
                lhd.Add(hd);

            }
            Console.Clear();
            // in hoa don ra console
            lhd[0].getInfo();
            Console.WriteLine();
            Console.WriteLine("'=>' để sang hóa đơn tiếp theo");
            Console.WriteLine("'<=' để trở về hóa đơn trước");
            Console.WriteLine("'Enter' để kết thúc");
            int o = 1;
            while (o < lhd.Count)
            {
                var arrow = Console.ReadKey();
                Console.Clear();
                if (arrow.Key == ConsoleKey.RightArrow)
                {
                    lhd[o].getInfo();
                    Console.WriteLine();
                    
                    
                }
                if (arrow.Key == ConsoleKey.LeftArrow)
                {
                    lhd[o - 1].getInfo();
                    Console.WriteLine();
                }
                if (arrow.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine("Chuan bi ghi du lieu sang file txt");
                    break;
                }
                Console.WriteLine("'=>' để sang hóa đơn tiếp theo");
                Console.WriteLine("'<=' để trở về hóa đơn trước");
                Console.WriteLine("'Enter' để kết thúc");
            }

            // ghi du lieu vao file txt, em dung Append chu khong phai OpenOrCreate
            foreach (var itemToTxt in lhd)
            {
                itemToTxt.toTxtFile();
                Console.WriteLine();
                Console.WriteLine();
                
            }
            //Console.ReadLine();

        }

        
    }
}
