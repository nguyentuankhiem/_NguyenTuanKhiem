using System;
using System.Collections.Generic;
using System.Text;

namespace oop.Devices.AirConditioners.AirConditionerTypes
{
    class OneWayAirConditioner : AirConditioner
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
        public void insertInverter()
        {
            Console.Write("\n\t\t\t\tInverter (1-có, 2-không): ");
            while (true)
            {
                try
                {
                    this.inver = int.Parse(Console.ReadLine());
                    if (this.inver != 1 && this.inver != 2)
                    {
                        Console.WriteLine("\n\t\t\t\tVui lòng chọn");
                        Console.Write("\n\t\t\t\tInverter (1-có, 2-không): ");
                        this.inver = int.Parse(Console.ReadLine());
                    }
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("\n\t\t\t\tVui lòng chọn");
                    Console.Write("\n\t\t\t\tInverter (1-có, 2-không): ");
                }
            }
        }
        public override void AddDevice()
        {
            insertInverter();
            base.AddDevice();
            setPrice();

        }
        public override string getInfo()
        {
            return $"\n\tMáy lạnh: " +
            $"\n\tMã sản phẩm: {this.ID}" +
            $"\n\tTên: {this.Name}" +
            $"\n\tLoại máy lạnh: Máy lạnh một chiều" +
            $"\n\tNơi sản xuất: {this.Producer}" +
            $"\n\tĐơn giá: {this.Price}" +
            $"\n\tCông nghệ Inverter: {this.Inverter}" +
            $"\n\tSố lượng: {this.Amount}\n\n";
        }
        public override int setPrice()
        {
            if (this.inver == 1)
            {
                this.price = 1500;
            }
            else 
            { 
                this.price = 1000; 
            }
            return this.price;
        }
        public override int totalPrice()
        {
            return this.Price * this.Amount;
        }
    }
}
