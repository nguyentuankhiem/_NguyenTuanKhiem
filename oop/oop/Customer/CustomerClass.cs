using System;
using System.Collections.Generic;
using System.Text;

namespace oop.Customer
{
    public class CustomerClass
    {
        private string id { get; set; }
        private string name { get; set; }
        private string address { get; set; }
        private string pnumber { get; set; }

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
            return $"\n\tMã: {this.id}" +
            $"\n\tTên: {this.name}" +
            $"\n\tĐịa chỉ: {this.address}" +
            $"\n\tSố điện thoại: {this.pnumber}\n";
        }
    }
}
