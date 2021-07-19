using System;
using System.Collections.Generic;
using System.Text;

namespace oop.Devices
{
    abstract class Device
    {
        protected string id { get; set; }
        protected string name { get; set; }
        protected string producer { get; set; }
        protected int amount { get; set; }
        protected int price { get; set; }

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
                    Console.WriteLine("\n\t\t\t\tVui lòng nhập số lượng sản phẩm");
                    Console.Write("\n\t\t\t\tSố lượng: ");
                }
            }

        }
        public abstract string getInfo();
        public abstract int totalPrice();

        public abstract int setPrice();

    }
}
