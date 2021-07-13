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
            List<HoaDon> lhd = new List<HoaDon>();
            for (int i = 1; i <= slhd; i++)
            {
                Console.WriteLine($"\nNhập thông tin hóa đơn {i}:");
                HoaDon hd = new HoaDon();
                hd.taoHD();
                lhd.Add(hd);

            }
            Console.Clear();
            foreach (var item in lhd)
            {
                item.getInfo();
                Console.WriteLine();
                Console.WriteLine();
            }


            foreach (var itemToTxt in lhd)
            {
                itemToTxt.toTxtFile();
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
