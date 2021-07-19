using System;
using System.Collections.Generic;
using System.Text;

namespace oop.Devices.Fans.FanTypes
{
    class SteamFan : Fan
    {
        private int waterCap { get; set; }
        public int WaterCapacity { get; set; }

        public void insertWaterCap()
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
                    Console.WriteLine("\n\t\t\t\tVui lòng nhập dung tích nước");
                    Console.Write($"\n\t\t\t\tDung tích nước: ");
                }
            }
        }

        public override void AddDevice()
        {
            insertWaterCap();
            base.AddDevice();
            setPrice();
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
        public override int setPrice()
        {
            this.price = this.waterCap * 400;
            return this.price;
        }
        public override int totalPrice()
        {
            return this.Price * this.Amount;
        }
    }
}
