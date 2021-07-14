using System;
using System.Collections.Generic;
using System.Text;

namespace oop
{

    class QuatDung : TB
    {
        public void taoQDung()
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
            this.soLuong = sl;
            this.giaBan = 500;

            QuatDung qdung = new QuatDung();
        }

        public override void getInfo()
        {
            var tab = new StringBuilder();
            tab.Append(' ', 5);
            //Console.WriteLine($"\n{tab}Danh sách các chi tiết hóa đơn:");
            Console.Write($"\n{tab}{tab}Máy quạt: ");
            Console.Write($"<Mã quạt: {this.maSP}>, ");
            Console.Write($"<Loại máy quạt: Quạt đứng>, ");
            Console.Write($"<Tên quạt: {this.tenSP}>, ");
            Console.Write($"<Đơn giá: {this.giaBan}>, ");
            Console.WriteLine($"<Số lượng: {this.soLuong}>");
        }
    }
}
