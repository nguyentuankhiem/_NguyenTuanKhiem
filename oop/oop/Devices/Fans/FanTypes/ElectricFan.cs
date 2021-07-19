using System;
using System.Collections.Generic;
using System.Text;

namespace oop.Devices.Fans.FanTypes
{
    class ElectricFan : Fan
    {
        private int batteryCap { get; set; }
        public int BatteryCapacity { get; set; }

        public void insertBatteryCap()
        {
            Console.Write("\n\t\t\t\tDung lượng pin: ");
            while (true)
            {
                try
                {
                    this.batteryCap = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("\n\t\t\t\tVui lòng nhập dung lượng");
                    Console.Write("\n\t\t\t\tDung lượng pin: ");
                }

            }
        }
        public override void AddDevice()
        {
            insertBatteryCap();
            base.AddDevice();
            setPrice();
        }
        public override string getInfo()
        {
            return $"\n\tMáy quạt: " +
            $"\n\tMã sản phẩm: {this.ID}" +
            $"\n\tTên: {this.Name}" +
            $"\n\tLoại quạt: Quạt điện" +
            $"\n\tNơi sản xuất: {this.Producer}" +
            $"\n\tĐơn giá: {this.Price}" +
            $"\n\tDung lượnng pin: {this.BatteryCapacity}" +
            $"\n\tSố lượng: {this.Amount}\n\n";
        }

        public override int setPrice()
        {
            this.price = this.batteryCap * 500;
            return this.price;
        }
        public override int totalPrice()
        {
            return this.Price * this.Amount;
        }
    }
}
