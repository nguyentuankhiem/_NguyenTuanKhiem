using System;
using System.Collections.Generic;
using System.Text;

namespace oop.Devices
{
    abstract class DevicesClass
    {
        protected string id { get; set; }
        protected string name { get; set; }
        protected string producer { get; set; }
        protected int amount { get; set; }
        protected int price { get; set; }

        public virtual void AddDevice()
        {
            Console.Write("\n\t\t\t\tMã sản phẩm: ");
            this.id = Console.ReadLine();
            Console.Write("\n\t\t\t\tTên sản phẩm: ");
            this.name = Console.ReadLine();
            Console.Write("\n\t\t\t\tNơi sản xuất: ");
            this.producer = Console.ReadLine();
            Console.Write("\n\t\t\t\tSố lượng: ");
            while (true)
            {
                try
                {
                    this.amount = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.Write("\n\t\t\t\tSố lượng: ");
                }
            }

        }
        public abstract string getInfo();
        public abstract int totalPrice();

    }
}
