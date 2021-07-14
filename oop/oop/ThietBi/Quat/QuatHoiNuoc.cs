using System;
using System.Collections.Generic;
using System.Text;

namespace oop
{
    class QuatHoiNuoc : TB
    {
        //public int dungTich { get; set; }
        public void taoQHN()
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
            Console.Write($"\n{tab}{tab}{tab}{tab}Dung tích nước: ");
            int dt;
            while (true)
            {
                try
                {
                    dt = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.Write($"\n{tab}{tab}{tab}{tab}Dung tích nước: ");
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
            this.dungTich = dt;
            this.soLuong = sl;
            this.giaBan = this.dungTich * 400;

            QuatHoiNuoc qhn = new QuatHoiNuoc();

        }

        public override void getInfo()
        {
            var tab = new StringBuilder();
            tab.Append(' ', 5);
            //Console.WriteLine($"\n{tab}Danh sách các chi tiết hóa đơn:");
            Console.Write($"\n{tab}{tab}Máy quạt: ");
            Console.Write($"<Mã quạt: {this.maSP}>, ");
            Console.Write($"<Loại máy quạt: Quạt hơi nước>, ");
            Console.Write($"<Tên quạt: {this.tenSP}>, ");
            Console.Write($"<Đơn giá: {this.giaBan}>, ");
            Console.Write($"<Dung tích nước: {this.dungTich}>, ");
            Console.WriteLine($"<Số lượng: {this.soLuong}>");

        }
    }
}
