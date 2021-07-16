using System;
using System.Collections.Generic;
using System.Text;

namespace oop.Devices.Fan.FanTypes
{
    class StandFan : FanClass
    {
        public StandFan()
        {
            Price = 500;
        }

        public override void AddDevice()
        {
            base.AddDevice();
        }
        public override string getInfo()
        {
            return $"\n\tMáy quạt:" +
            $"\n\tMã sản phẩm: {ID}" +
            $"\n\tTên: {Name}" +
            $"\n\tLoại quạt: Quạt đứng" +
            $"\n\tNơi sản xuất: {Producer}" +
            $"\n\tĐơn giá: {Price}" +
            $"\n\tSố lượng: {Amount}\n\n";
        }

        public override int totalPrice()
        {
            return this.Price * this.Amount;
        }
    }
}
