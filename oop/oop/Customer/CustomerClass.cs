using System;
using System.Collections.Generic;
using System.Text;

namespace oop.Customer
{
    public class CustomerClass
    {
        private string id;
        private string name;
        private string address;
        private string pnumber;

        public string ID { get { return id; } }
        public string Name { get { return name; } }
        public string Address { get { return address; } }
        public string PNumber { get { return pnumber; } }

        public void addCustomer()
        {
            Console.Write("\n\t\tMã: ");
            this.id = Console.ReadLine();
            Console.Write("\n\t\tHọ và tên: ");
            this.name = Console.ReadLine();
            Console.Write("\n\t\tĐịa chỉ: ");
            this.address = Console.ReadLine();
            Console.Write("\n\t\tSố điện thoại: ");
            this.pnumber = Console.ReadLine();
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
