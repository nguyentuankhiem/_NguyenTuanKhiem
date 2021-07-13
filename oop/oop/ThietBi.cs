using System;
using System.Collections.Generic;
using System.Text;

namespace oop
{
    class ThietBi
    {
        public string maSP { get; set; }
        public string tenSP { get; set; }
        public string noiSX { get; set; }
        public int dungTich { get; set; }
        public int dungLuong { get; set; }
        public bool inverter { get; set; }
        public bool khumui { get; set; }
        public bool khangkhuan { get; set; }
        public int soLuong { get; set; }
        public int giaBan { get; set; }

        public virtual void getInfo()
        {
            var tab = new StringBuilder();
            tab.Append(' ', 5);
            Console.WriteLine(this.maSP);
            Console.WriteLine(this.tenSP);
            Console.WriteLine(this.noiSX);
            Console.WriteLine(this.soLuong);
            Console.WriteLine(this.giaBan);
        }
    }
    class QuatDung : ThietBi
    {
        public void taoQDung()
        {
            var tab = new StringBuilder();
            tab.Append(' ', 5);
            Console.Write($"\n{tab}{tab}{tab}{tab}Nhập mã: ");
            string ma = Console.ReadLine();
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
            Console.Write($"Đơn giá: {this.giaBan}>, ");
            Console.Write($"<Số lượng: {this.soLuong}>");
        }
    }

    class QuatHoiNuoc : ThietBi
    {
        //public int dungTich { get; set; }
        public void taoQHN()
        {
            var tab = new StringBuilder();
            tab.Append(' ', 5);
            Console.Write($"\n{tab}{tab}{tab}{tab}Nhập mã: ");
            string ma = Console.ReadLine();
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
            Console.Write($"Đơn giá: {this.giaBan}>, ");
            Console.Write($"<Dung tích nước: {this.dungTich}>, ");
            Console.Write($"<Số lượng: {this.soLuong}>");

        }
    }

    class QuatDien : ThietBi
    {
        //public int dungLuong { get; set; } 
        public void taoQDien()
        {
            var tab = new StringBuilder();
            tab.Append(' ', 5);
            Console.Write($"\n{tab}{tab}{tab}{tab}Nhập mã: ");
            string ma = Console.ReadLine();
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
            Console.Write($"Đơn giá: {this.giaBan}>, ");
            Console.Write($"<Dung lượng pin: {this.dungLuong}>, ");
            Console.Write($"<Số lượng: {this.soLuong}>");
        }
    }

    class MayLanhMotChieu : ThietBi
    {
        //public bool inverter { get; set; }
        public void taoMLMC()
        {
            var tab = new StringBuilder();
            tab.Append(' ', 5);
            Console.Write($"\n{tab}{tab}{tab}{tab}Nhập mã: ");
            string ma = Console.ReadLine();
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
            Console.Write($"Đơn giá: {this.giaBan}>, ");
            Console.Write("<Công nghệ Inverter: ");
            Console.Write(this.inverter ? "Có>, " : "Không>, ");
            Console.Write($"<Số lượng: {this.soLuong}>");
        }

    }

    class MayLanhHaiChieu : ThietBi
    {
        //public bool inverter { get; set; }
        //public bool khumui { get; set; }
        //public bool khangkhuan { get; set; }

        public void taoMLHC()
        {
            var tab = new StringBuilder();
            tab.Append(' ', 5);
            Console.Write($"\n{tab}{tab}{tab}{tab}Nhập mã: ");
            string ma = Console.ReadLine();
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
            Console.Write($"\n{tab}{tab}{tab}{tab}Công nghệ khử mùi (1-có, 2-không): ");
            int km;
            while (true)
            {
                try
                {
                    km = int.Parse(Console.ReadLine());
                    if (km != 1 && km != 2)
                    {
                        Console.Write($"\n{tab}{tab}{tab}{tab}Công nghệ khử mùi (1-có, 2-không): ");
                        km = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception)
                {
                    Console.Write($"\n{tab}{tab}{tab}{tab}Công nghệ khử mùi (1-có, 2-không): ");
                }
            }
            Console.Write($"\n{tab}{tab}{tab}{tab}Công nghệ kháng khuẩn (1-có, 2-không): ");
            int kk;
            while (true)
            {
                try
                {
                    kk = int.Parse(Console.ReadLine());
                    if (kk != 1 && kk != 2)
                    {
                        Console.Write($"\n{tab}{tab}{tab}{tab}Công nghệ kháng khuẩn (1-có, 2-không): ");
                        kk = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception)
                {
                    Console.Write($"\n{tab}{tab}{tab}{tab}Công nghệ kháng khuẩn (1-có, 2-không): ");
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
            this.khumui = km == 1 ? true : false;
            this.khangkhuan = kk == 1 ? true : false;
            if (this.inverter)
            {
                if (this.khumui && this.khangkhuan)
                {
                    this.giaBan = 3500;
                }
                else if (this.khumui || this.khangkhuan)
                {
                    this.giaBan = 3000;
                }
                else
                {
                    this.giaBan = 2500;
                }
            }
            else
            {
                if (this.khumui && this.khangkhuan)
                {
                    this.giaBan = 3000;
                }
                else if (this.khumui || this.khangkhuan)
                {
                    this.giaBan = 2500;
                }
                else { this.giaBan = 2000; }
            }
        }

        public override void getInfo()
        {
            var tab = new StringBuilder();
            tab.Append(' ', 5);
            Console.Write($"\n{tab}{tab}Máy lạnh: ");
            Console.Write($"<Mã máy lạnh: {this.maSP}>, ");
            Console.Write($"<Loại máy lạnh: Máy lạnh hai chiều>, ");
            Console.Write($"<Tên máy lạnh: {this.tenSP}>, ");
            Console.Write($"Đơn giá: {this.giaBan}>, ");
            Console.Write("<Công nghệ Inverter: ");
            Console.Write(this.inverter ? "Có>, " : "Không>, ");
            Console.Write("<Công nghệ khử mùi: ");
            Console.Write(this.khumui ? "Có>, " : "Không>, ");
            Console.Write("<Công nghệ kháng khuẩn: ");
            Console.Write(this.khangkhuan ? "Có>, " : "Không>, ");
            Console.Write($"<Số lượng: {this.soLuong}>");
        }
    }
}
