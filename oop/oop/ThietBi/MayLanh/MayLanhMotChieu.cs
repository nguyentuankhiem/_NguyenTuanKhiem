using System;
using System.Collections.Generic;
using System.Text;

namespace oop
{
    class MayLanhMotChieu : TB
    {
        //public bool inverter { get; set; }
        public void taoMLMC()
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
            Console.Write($"\n{tab}{tab}{tab}{tab}Công nghệ inverter (1-có, 2-không): ");
            int inver;
            while (true)
            {
                try
                {
                    inver = int.Parse(Console.ReadLine());
                    if (inver != 1 && inver != 2)
                    {
                        Console.Write($"\n{tab}{tab}{tab}{tab}Công nghệ inverter (1-có, 2-không): ");
                        inver = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception)
                {
                    Console.Write($"\n{tab}{tab}{tab}{tab}Công nghệ inverter (1-có, 2-không): ");
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
            this.soLuong = sl;
            this.inverter = inver == 1 ? true : false;
            this.giaBan = this.inverter ? 1500 : 1000;
        }

        public override void getInfo()
        {
            var tab = new StringBuilder();
            tab.Append(' ', 5);
            Console.Write($"\n{tab}{tab}Máy lạnh: ");
            Console.Write($"<Mã máy lạnh: {this.maSP}>, ");
            Console.Write($"<Loại máy lạnh: Máy lạnh một chiều>, ");
            Console.Write($"<Tên máy lạnh: {this.tenSP}>, ");
            Console.Write($"<Đơn giá: {this.giaBan}>, ");
            Console.Write("<Công nghệ Inverter: ");
            Console.Write(this.inverter ? "Có>, " : "Không>, ");
            Console.WriteLine($"<Số lượng: {this.soLuong}>");
        }

    }
}
