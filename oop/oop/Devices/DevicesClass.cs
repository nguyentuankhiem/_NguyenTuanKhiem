using System;
using System.Collections.Generic;
using System.Text;

namespace oop.Devices
{
    abstract class DevicesClass
    {
        protected string id;
        protected string name;
        protected string producer;
        protected int amount;
        protected int price;

        public string ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Producer
        {
            get
            {
                return producer;
            }
            set
            {
                producer = value;
            }
        }
        public int Amount
        {
            get
            {
                return amount;
            }
            set
            {
                amount = value;
            }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }

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
