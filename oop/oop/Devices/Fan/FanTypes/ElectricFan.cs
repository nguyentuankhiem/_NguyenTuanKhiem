using System;
using System.Collections.Generic;
using System.Text;

namespace oop.Devices.Fan.FanTypes
{
    class ElectricFan : FanClass
    {
        private int batteryCap { get; set; }

        public ElectricFan()
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
                    Console.Write("\n\t\t\t\tDung lượng pin: ");
                }

            }
            this.Price = this.batteryCap * 500;
        }
        public override void AddDevice()
        {
            base.AddDevice();
        }
        public override string getInfo()
        {
            return $"\n\tMáy quạt: " +
            $"\n\tMã sản phẩm: {this.ID}" +
            $"\n\tTên: {this.Name}" +
            $"\n\tLoại quạt: Quạt điện" +
            $"\n\tNơi sản xuất: {this.Producer}" +
            $"\n\tĐơn giá: {this.Price}" +
            $"\n\tDung lượnng pin: {this.batteryCap}" +
            $"\n\tSố lượng: {this.Amount}\n\n";
        }

        public override int totalPrice()
        {
            return this.Price * this.Amount;
        }
    }
}
