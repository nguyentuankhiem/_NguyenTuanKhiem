using System;
using System.Collections.Generic;
using System.Text;

namespace oop.Devices.Fan.FanTypes
{
    class SteamFan : FanClass
    {
        private int waterCap;
        public int WaterCapacity { get; set; }

        public SteamFan()
        {
            Console.Write($"\n\t\t\t\tDung tích nước: ");
            while (true)
            {
                try
                {
                    this.waterCap = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.Write($"\n\t\t\t\tDung tích nước: ");
                }
            }
            this.price = this.waterCap * 400;
        }
        public override void AddDevice()
        {
            base.AddDevice();
        }
        public override string getInfo()
        {
            return $"\n\tMáy quạt: " +
            $"\n\tMã sản phảm: {this.ID}" +
            $"\n\tTên: {this.Name}" +
            $"\n\tLoại quạt: Quạt hơi nước" +
            $"\n\tNơi sản xuất:  {this.Producer}" +
            $"\n\tĐơn giá: {this.Price}" +
            $"\n\tDung tích nước: {this.WaterCapacity}" +
            $"\n\tSố lượng: {this.Amount}\n\n";
        }
        public override int totalPrice()
        {
            return this.Price * this.Amount;
        }
    }
}
