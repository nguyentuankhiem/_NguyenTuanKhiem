using System;
using System.Collections.Generic;
using System.Text;

namespace oop.Devices.Fan.FanTypes
{
    class StandFan : FanClass
    {
        public StandFan()
        {
            this.price = 500;
        }

        public override void AddDevice()
        {
            base.AddDevice();
        }
        public override string getInfo()
        {
            return $"\n\tMáy quạt:" +
            $"\n\tMã sản phẩm: {this.ID}" +
            $"\n\tTên: {this.Name}" +
            $"\n\tLoại quạt: Quạt đứng" +
            $"\n\tNơi sản xuất: {this.Producer}" +
            $"\n\tĐơn giá: {this.Price}" +
            $"\n\tSố lượng: {this.Amount}\n\n";
        }

        public override int totalPrice()
        {
            return this.Price * this.Amount;
        }
    }
}
