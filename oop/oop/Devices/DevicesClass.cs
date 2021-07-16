using System;
using System.Collections.Generic;
using System.Text;

namespace oop.Devices
{
    abstract class DevicesClass
    {
        protected string ID { get; set; }
        protected string Name { get; set; }
        protected string Producer { get; set; }
        protected int Amount { get; set; }
        protected int Price { get; set; }

        public virtual void AddDevice()
        {
            Console.Write("\n\t\t\t\tMã sản phẩm: ");
            this.ID = Console.ReadLine();
            Console.Write("\n\t\t\t\tTên sản phẩm: ");
            this.Name = Console.ReadLine();
            Console.Write("\n\t\t\t\tNơi sản xuất: ");
            this.Producer = Console.ReadLine();
            Console.Write("\n\t\t\t\tSố lượng: ");
            while (true)
            {
                try
                {
                    this.Amount = int.Parse(Console.ReadLine());
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
