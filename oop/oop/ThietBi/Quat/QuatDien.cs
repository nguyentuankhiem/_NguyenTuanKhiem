using System;
using System.Collections.Generic;
using System.Text;

namespace oop
{
    class QuatDien : TB
    {
        //public int dungLuong { get; set; } 
        public void taoQDien()
        {
            var tab = new StringBuilder();
            tab.Append(' ', 5);
            Console.Write($"\n{tab}{tab}{tab}{tab}Nhập mã: ");
            string ma = Console.ReadLine();
            while (String.IsNullOrEmpty(ma))
            {
                Console.Write($"\n{tab}{tab}{tab}{tab}Nhập mã: ");
                ma = Console.ReadLine();
            }
            Console.Write($"\n{tab}{tab}{tab}{tab}Tên sản phẩm: ");
            string ten = Console.ReadLine();
            Console.Write($"\n{tab}{tab}{tab}{tab}Nơi sản xuất: ");
            string noi = Console.ReadLine();
            Console.Write($"\n{tab}{tab}{tab}{tab}Dung lượng pin: ");
            int dl;
            while (true)
            {
                try
                {
                    dl = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.Write($"\n{tab}{tab}{tab}{tab}Dung lượng pin: ");
                }
            }

            Console.Write($"\n{tab}{tab}{tab}Số lượng bán ra: ");
            int sl;
            while (true)
            {
                try
                {
                    sl = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.Write($"\n{tab}{tab}{tab}Số lượng bán ra: ");
                }
            }

            // add vao fields
            this.maSP = ma;
            this.tenSP = ten;
            this.noiSX = noi;
            this.dungLuong = dl;
            this.soLuong = sl;
            this.giaBan = this.dungLuong * 500;

            QuatDien qdi = new QuatDien();
        }

        public override void getInfo()
        {
            var tab = new StringBuilder();
            tab.Append(' ', 5);
            //Console.WriteLine($"\n{tab}Danh sách các chi tiết hóa đơn:");
            Console.Write($"\n{tab}{tab}Máy quạt: ");
            Console.Write($"<Mã quạt: {this.maSP}>, ");
            Console.Write($"<Loại máy quạt: Quạt điện>, ");
            Console.Write($"<Tên quạt: {this.tenSP}>, ");
            Console.Write($"<Đơn giá: {this.giaBan}>, ");
            Console.Write($"<Dung lượng pin: {this.dungLuong}>, ");
            Console.WriteLine($"<Số lượng: {this.soLuong}>");
        }
    }
}
