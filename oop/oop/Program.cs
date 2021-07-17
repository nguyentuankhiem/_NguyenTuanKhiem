using oop.Bill;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace testOOP_lan3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            BillClass[] bill = new BillClass[100];
            Console.Write("Số lượng hóa đơn: ");
            int billNum;
            while (true)
            {
                try
                {
                    billNum = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.Write("Số lượng hóa đơn: ");
                }
            }

            for (int i = 0; i < billNum; i++)
            {
                Console.WriteLine($"\nHóa đơn thứ {i + 1}: ");
                bill[i] = new BillClass();
                bill[i].CreateBill();
                Console.Clear();
                Console.WriteLine(bill[i].getInfo());

            }


            FileStream fs = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"/danh_sach_hoa_don.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            for (int i = 0; i < billNum; i++)
            {
                sw.WriteLine(bill[i].getInfo());
            }
            sw.Flush();
            Console.Write("Enter để lưu hóa đơn vào file txt: ");
            var input = Console.ReadKey();
            while (true)
            {
                if (input.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine("'danh_sach_hoa_don.txt' đã được lưu vào Desktop");
                    break;
                }
            }



            
        }
    }
}
