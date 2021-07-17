using System;
using System.Collections.Generic;
using System.Text;

namespace oop.Devices.AC.ACTypes
{
    class TwoWayAC : ACClass
    {
        private int inver { get; set; }
        private bool Inverter
        {
            get
            {
                if (inver == 1)
                {
                    return true;
                }
                else { return false; }
            }
        }

        private int deo;
        private bool Deodorant
        {
            get
            {
                if (deo == 1)
                {
                    return true;
                }
                else { return false; }
            }
        }

        private int anti;
        private bool Antimicrobial
        {
            get
            {
                if (anti == 1)
                {
                    return true;
                }
                else { return false; }
            }
        }

        public TwoWayAC()
        {
            Console.Write("\n\t\t\t\tInverter (1-có, 2-không): ");
            while (true)
            {
                try
                {
                    this.inver = int.Parse(Console.ReadLine());
                    if (inver != 1 && this.inver != 2)
                    {
                        Console.Write("\n\t\t\t\tInverter (1-có, 2-không): ");
                        this.inver = int.Parse(Console.ReadLine());
                    }
                    break;
                }
                catch (Exception)
                {
                    Console.Write("\n\t\t\t\tInverter (1-có, 2-không): ");
                }
            }

            Console.Write("\n\t\t\t\tKhử mùi (1-có, 2-không): ");
            while (true)
            {
                try
                {
                    this.deo = int.Parse(Console.ReadLine());
                    if (this.deo != 1 && this.deo != 2)
                    {
                        Console.Write("\n\t\t\t\tKhử mùi (1-có, 2-không): ");
                        this.deo = int.Parse(Console.ReadLine());
                    }
                    break;
                }
                catch (Exception)
                {
                    Console.Write("\n\t\t\t\tKhử mùi (1-có, 2-không): ");
                }
            }

            Console.Write("\n\t\t\t\tKháng khuẩn (1-có, 2-không): ");
            while (true)
            {
                try
                {
                    this.anti = int.Parse(Console.ReadLine());
                    if (this.anti != 1 && this.anti != 2)
                    {
                        Console.Write("\n\t\t\t\tKháng khuẩn (1-có, 2-không): ");
                        this.anti = int.Parse(Console.ReadLine());
                    }
                    break;
                }
                catch (Exception)
                {
                    Console.Write("\n\t\t\t\tKháng khuẩn (1-có, 2-không): ");
                }
            }

            if (this.Inverter)
            {
                this.Price = 2500;
                if (this.Deodorant && this.Antimicrobial)
                {
                    this.Price += 1000;
                }
                else if (this.Deodorant || this.Antimicrobial)
                {
                    this.Price += 500;
                }
            }
            else
            {
                this.Price = 2000;
                if (this.Deodorant && this.Antimicrobial)
                {
                    this.Price += 1000;
                }
                else if (this.Deodorant || this.Antimicrobial)
                {
                    this.Price += 500;
                }
            }
        }
        public override string getInfo()
        {
            return $"\n\tMáy lạnh: " +
            $"\n\tMã sản phẩm: {this.ID}" +
            $"\n\tTên: {this.Name}" +
            $"\n\tLoại máy lạnh: Máy lạnh hai chiều" +
            $"\n\tNơi sản xuất: {this.Producer}" +
            $"\n\tĐơn giá: {this.Price}" +
            $"\n\tCông nghệ Inverter: {this.Inverter}" +
            $"\n\tCông nghệ Khử mùi: {this.Deodorant}" +
            $"\n\tCông nghệ Kháng khuẩn: {this.Antimicrobial}" +
            $"\n\tSố lượng: {this.Amount}\n\n";
        }

        public override int totalPrice()
        {
            return this.Price * this.Amount;
        }
    }
}
