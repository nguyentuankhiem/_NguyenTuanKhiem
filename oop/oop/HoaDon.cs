using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace oop
{
    class HoaDon
    {
        public string maHD { get; set; }
        public KhachHang KH { get; set; }

        public List<ThietBi> chitietHD { get; set; }
        public DateTime ngayLapHD { get; set; }
        public int giaHD { get; set; }



        /* public HoaDon(string ma, KhachHang kh, string ngay, int gia)
        {
            this.maHD = ma;
            this.KH = kh;
            this.ngayLapHD = ngay;
            this.giaHD = gia;

        } */

        //public List<HoaDon> lhd { get; set; }

        public void taoHD()
        {
            var tab = new StringBuilder();
            tab.Append(' ', 5);
            Console.Write($"\n{tab}Mã hóa đơn: ");
            string mahd = Console.ReadLine();
            while (String.IsNullOrEmpty(mahd))
            {
                Console.Write($"\n{tab}Mã hóa đơn: ");
                mahd = Console.ReadLine();
            }
            Console.WriteLine($"\n{tab}Thông tin khách hàng: ");
            KhachHang kh = new KhachHang();
            kh.taoKH();
            Console.WriteLine($"\n{tab}Nhập danh sách các chi tiết hóa đơn: ");
            Console.Write($"\n{tab}{tab}Số lượng chi tiết trong danh sách các chi tiết hóa đơn: ");
            int slct;
            while (true)
            {
                try
                {
                    slct = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.Write($"\n{tab}{tab}Số lượng chi tiết trong danh sách các chi tiết hóa đơn: ");
                }
            }
            this.chitietHD = new List<ThietBi>();
            for (int i = 1; i <= slct; i++)
            {

                Console.WriteLine($"\n{tab}{tab}Nhập chi tiết hóa đơn thứ: {i}");
                Console.Write($"\n{tab}{tab}{tab}Chọn loại thiết bị (1-máy quạt, 2-máy lạnh): ");
                int thietbi;
                while (true)
                {
                    try
                    {
                        thietbi = int.Parse(Console.ReadLine());
                        if (thietbi != 1 && thietbi != 2)
                        {
                            Console.Write($"\n{tab}{tab}{tab}Chọn loại thiết bị (1-máy quạt, 2-máy lạnh): ");
                            thietbi = int.Parse(Console.ReadLine());
                        }
                        else { break; }
                    }
                    catch (Exception)
                    {
                        Console.Write($"\n{tab}{tab}{tab}Chọn loại thiết bị (1-máy quạt, 2-máy lạnh): ");
                    }
                }
                if (thietbi == 1)
                {
                    Console.Write($"\n{tab}{tab}{tab}{tab}Chọn loại máy quạt(1-máy quạt đứng, 2-máy quạt hơi nước, 3-máy quạt điện): ");
                    int loaiq;
                    while (true)
                    {
                        try
                        {
                            loaiq = int.Parse(Console.ReadLine());
                            if (loaiq != 1 && loaiq != 2 && loaiq != 3)
                            {
                                Console.Write($"\n{tab}{tab}{tab}{tab}Chọn loại máy quạt(1-máy quạt đứng, 2-máy quạt hơi nước, 3-máy quạt điện): ");
                                loaiq = int.Parse(Console.ReadLine());
                            }
                            else
                            {
                                break;
                            }
                        }
                        catch (Exception)
                        {
                            Console.Write($"\n{tab}{tab}{tab}{tab}Chọn loại máy quạt(1-máy quạt đứng, 2-máy quạt hơi nước, 3-máy quạt điện): ");
                        }
                    }
                    if (loaiq == 1)
                    {
                        QuatDung qdung = new QuatDung();
                        qdung.taoQDung();
                        this.giaHD = qdung.giaBan * qdung.soLuong;
                        this.chitietHD.Add(qdung);
                    }
                    else if (loaiq == 2)
                    {
                        QuatHoiNuoc qhn = new QuatHoiNuoc();
                        qhn.taoQHN();
                        this.giaHD += qhn.giaBan * qhn.soLuong;
                        this.chitietHD.Add(qhn);
                    }
                    else
                    {
                        QuatDien qdien = new QuatDien();
                        qdien.taoQDien();
                        this.giaHD += qdien.giaBan * qdien.soLuong;
                        this.chitietHD.Add(qdien);
                    }
                }
                else
                {
                    Console.Write($"\n{tab}{tab}{tab}{tab}Chọn loại máy lạnh (1-một chiều, 2-hai chiều): ");
                    int loaiml;
                    while (true)
                    {
                        try
                        {
                            loaiml = int.Parse(Console.ReadLine());
                            if (loaiml != 1 && loaiml != 2)
                            {
                                Console.Write($"\n{tab}{tab}{tab}{tab}Chọn loại máy lạnh (1-một chiều, 2-hai chiều): ");
                                loaiml = int.Parse(Console.ReadLine());
                            }
                            else { break; }
                        }
                        catch (Exception)
                        {
                            Console.Write($"\n{tab}{tab}{tab}{tab}Chọn loại máy lạnh (1-một chiều, 2-hai chiều): ");
                        }
                    }
                    if (loaiml == 1)
                    {
                        MayLanhMotChieu mlmc = new MayLanhMotChieu();
                        mlmc.taoMLMC();
                        giaHD += mlmc.giaBan * mlmc.soLuong;
                        this.chitietHD.Add(mlmc);
                    }
                    else
                    {
                        MayLanhHaiChieu mlhc = new MayLanhHaiChieu();
                        mlhc.taoMLHC();
                        giaHD += mlhc.giaBan * mlhc.soLuong;
                        this.chitietHD.Add(mlhc);
                    }
                }

            }
            this.maHD = mahd;
            this.KH = kh;
            this.ngayLapHD = DateTime.Now
                ;
            //this.giaHD = 10;






        }


        public void getInfo()
        {
            var tab = new StringBuilder();
            tab.Append(' ', 5);
            Console.Write("\nHóa đơn: ");
            Console.Write($"<Mã hóa đon: {this.maHD}> ");
            Console.Write($"<Ngày lập HD: {this.ngayLapHD.Day}-{this.ngayLapHD.Month}-{this.ngayLapHD.Year}> ");
            Console.WriteLine($"<Giá: {this.giaHD}>");
            Console.Write($"\n{tab}Thông tin khách hàng: ");
            this.KH.getInfo();
            Console.WriteLine($"\n{tab}Danh sách các chi tiết hóa đơn:");
            foreach (var item in this.chitietHD)
            {
                item.getInfo();
            }
            Console.WriteLine();

            //Console.Write("So san pham: " + Q.Count);

        }
        

        public void toTxtFile()
        {
            FileStream fs = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/danh_sach_hoa_don.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            var tab = new StringBuilder();
            tab.Append(' ', 5);
            sw.Write("\nHóa đơn: ");
            sw.Write($"<Mã hóa đon: {this.maHD}> ");
            sw.Write($"<Ngày lập HD: {this.ngayLapHD}> ");
            sw.WriteLine($"<Giá: {this.giaHD}>");
            sw.Write($"\n{tab}Thông tin khách hàng: ");
            sw.Write($"Mã KH: {this.KH.maKH}, ");
            sw.Write($"Tên KH: {this.KH.tenKH}, ");
            sw.Write($"SDT: {this.KH.SDT}, ");
            sw.WriteLine($"Địa chỉ: {this.KH.diaChi}.");

            sw.WriteLine($"\n{tab}Danh sách các chi tiết hóa đơn:");
            foreach (var item in this.chitietHD)
            {

                if (item.GetType() == typeof(QuatDung))
                {
                    sw.Write($"\n{tab}{tab}Máy quạt: ");
                    sw.Write($"<Mã quạt: {item.maSP}>, ");
                    sw.Write($"<Loại máy quạt: Quạt đứng>, ");
                    sw.Write($"<Tên quạt: {item.tenSP}>, ");
                    sw.Write($"<Đơn giá: {item.giaBan}>, ");
                    sw.WriteLine($"<Số lượng: {item.soLuong}>");
                }
                else if (item.GetType() == typeof(QuatHoiNuoc))
                {
                    sw.Write($"\n{tab}{tab}Máy quạt: ");
                    sw.Write($"<Mã quạt: {item.maSP}>, ");
                    sw.Write($"<Loại máy quạt: Quạt hơi nước>, ");
                    sw.Write($"<Tên quạt: {item.tenSP}>, ");
                    sw.Write($"<Đơn giá: {item.giaBan}>, ");
                    sw.Write($"<Dung tích nước: {item.dungTich}>, ");
                    sw.WriteLine($"<Số lượng: {item.soLuong}>");
                }
                else if (item.GetType() == typeof(QuatDien))
                {
                    sw.Write($"\n{tab}{tab}Máy quạt: ");
                    sw.Write($"<Mã quạt: {item.maSP}>, ");
                    sw.Write($"<Loại máy quạt: Quạt điện>, ");
                    sw.Write($"<Tên quạt: {item.tenSP}>, ");
                    sw.Write($"<Đơn giá: {item.giaBan}>, ");
                    sw.Write($"<Dung lượng pin: {item.dungLuong}>, ");
                    sw.WriteLine($"<Số lượng: {item.soLuong}>");
                }
                else if (item.GetType() == typeof(MayLanhMotChieu))
                {
                    sw.Write($"\n{tab}{tab}Máy lạnh: ");
                    sw.Write($"<Mã máy lạnh: {item.maSP}>, ");
                    sw.Write($"<Loại máy lạnh: Máy lạnh một chiều>, ");
                    sw.Write($"<Tên máy lạnh: {item.tenSP}>, ");
                    sw.Write($"<Đơn giá: {item.giaBan}>, ");
                    sw.Write("<Công nghệ Inverter: ");
                    sw.Write(item.inverter ? "Có>, " : "Không>, ");
                    sw.WriteLine($"<Số lượng: {item.soLuong}>");
                }
                else if (item.GetType() == typeof(MayLanhHaiChieu))
                {
                    sw.Write($"\n{tab}{tab}Máy lạnh: ");
                    sw.Write($"<Mã máy lạnh: {item.maSP}>, ");
                    sw.Write($"<Loại máy lạnh: Máy lạnh hai chiều>, ");
                    sw.Write($"<Tên máy lạnh: {item.tenSP}>, ");
                    sw.Write($"<Đơn giá: {item.giaBan}>, ");
                    sw.Write("<Công nghệ Inverter: ");
                    sw.Write(item.inverter ? "Có>, " : "Không>, ");
                    sw.Write("<Công nghệ khử mùi: ");
                    sw.Write(item.khumui ? "Có>, " : "Không>, ");
                    sw.Write("<Công nghệ kháng khuẩn: ");
                    sw.Write(item.khangkhuan ? "Có>, " : "Không>, ");
                    sw.WriteLine($"<Số lượng: {item.soLuong}>");
                }
            }

            sw.Flush();
            fs.Close();
        }
    }
}
