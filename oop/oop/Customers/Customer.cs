using System;
using System.Collections.Generic;
using System.Text;

namespace oop.Customers
{
    public class Customer
    {
        private string id;
        private string name;
        private string address;
        private double pnumber;

        public string ID { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Address { get { return address; } set { address = value; } }
        public double PNumber { get { return pnumber; } set { pnumber = value; } }

        public void addCustomer()
        {
            Console.Write("\n\t\tMã: ");
            this.id = Console.ReadLine();
            Console.Write("\n\t\tHọ và tên: ");
            this.name = Console.ReadLine();
            Console.Write("\n\t\tĐịa chỉ: ");
            this.address = Console.ReadLine();
            Console.Write("\n\t\tSố điện thoại: ");

            //this.pnumber = int.Parse(Console.ReadLine()); 
            while (true)
            {
                try
                {
                        this.pnumber = double.Parse(Console.ReadLine());
                        break;
                    
                }
                catch (Exception)
                {
                    Console.WriteLine("\n\t\tSố điện thoại không chứa ký tự và không được để trống!");
                    Console.Write("\n\t\tSố điện thoại: ");
                }
            }
        }

        public string getInfo()
        {
            //Console.WriteLine("\nCustomer Info: ");
            return $"\n\tMã: {this.ID}" +
            $"\n\tTên: {this.Name}" +
            $"\n\tĐịa chỉ: {this.Address}" +
            $"\n\tSố điện thoại: {this.PNumber}\n";
        }
    }
}
