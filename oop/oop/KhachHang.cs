using System;
using System.Collections.Generic;
using System.Text;

namespace oop
{
    class KhachHang
    {
        public string maKH { get; set; }
        public string tenKH { get; set; }
        public string SDT { get; set; }
        public string diaChi { get; set; }


        public void taoKH()
        {
            var tab = new StringBuilder();
            tab.Append(' ', 10);
            Console.Write($"\n{tab}Ma KH: ");
            string ma = Console.ReadLine();
            Console.Write($"\n{tab}Ten KH: ");
            string ten = Console.ReadLine();
            Console.Write($"\n{tab}SDT: ");
            string sdt = Console.ReadLine();
            Console.Write($"\n{tab}Dia chi: ");
            string diachi = Console.ReadLine();

            this.maKH = ma;
            this.tenKH = ten;
            this.SDT = sdt;
            this.diaChi = diachi;

            KhachHang kh = new KhachHang();
        }

        public void getInfo()
        {
            var tab = new StringBuilder();
            tab.Append(' ', 5);
            Console.Write($"Mã KH: {maKH}, ");
            Console.Write($"Tên KH: {tenKH}, ");
            Console.Write($"SDT: {SDT}, ");
            Console.WriteLine($"Địa chỉ: {diaChi}.");

        }

    }
}
