using oop.Customer;
using oop.Devices;
using oop.Devices.AC.ACTypes;
using oop.Devices.Fan.FanTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace oop.Bill
{
    class BillClass
    {
        private string id { get; set; }

        private DateTime dateCreated = DateTime.Now;

        private CustomerClass customer { get; set; }
        private int totalPrice { get; set; }

        private DevicesClass devices;

        private int detailsNum;

        private int deviceChoice;

        private int fanType;
        private int ACType;
        private string data;

        public void CreateBill()
        {
            Console.Write("\n\tMã hóa đơn: ");
            id = Console.ReadLine();
            Console.WriteLine("\n\tThông tin khách hàng: ");
            customer = new CustomerClass();
            customer.addCustomer();
            Console.WriteLine("\n\tNhập danh sách chi tiết các hóa đơn: ");
            Console.Write("\n\t\tSố lượng chi tiết trong danh sách các chi tiết hóa đơn: ");
            while (true)
            {
                try
                {
                    detailsNum = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.Write("\n\t\tSố lượng chi tiết trong danh sách các chi tiết hóa đơn: ");
                }
            }
            for (int i = 0; i < detailsNum; i++)
            {
                Console.WriteLine($"\n\t\tNhập chi tiết hóa đơn thứ {i + 1}:");
                Console.Write("\n\t\t\tChọn loại thiết bị điện (1-máy quạt, 2-máy lạnh): ");
                while (true)
                {
                    try
                    {
                        deviceChoice = int.Parse(Console.ReadLine());
                        if (deviceChoice != 1 && deviceChoice != 2)
                        {
                            Console.Write("\n\t\t\tChọn loại thiết bị điện (1-máy quạt, 2-máy lạnh): ");
                            deviceChoice = int.Parse(Console.ReadLine());
                        }
                        break;
                    }
                    catch (Exception)
                    {
                        Console.Write("\n\t\t\tChọn loại thiết bị điện (1-máy quạt, 2-máy lạnh): ");
                    }
                }
                switch (deviceChoice)
                {
                    case 1:
                        Console.Write("\n\t\t\tChọn loại máy quạt (1-quạt đứng, 2-quạt hơi nước, 3-quạt điện): ");
                        while (true)
                        {
                            try
                            {
                                fanType = int.Parse(Console.ReadLine());
                                break;
                            }
                            catch (Exception)
                            {
                                Console.Write("\n\t\t\tChọn loại máy quạt (1-quạt đứng, 2-quạt hơi nước, 3-quạt điện): ");
                            }
                        }
                        switch (fanType)
                        {
                            case 1:
                                devices = new StandFan();
                                break;
                            case 2:
                                devices = new SteamFan();
                                break;
                            case 3:
                                devices = new ElectricFan();
                                break;
                        }
                        break;
                    case 2:
                        Console.Write("\n\t\t\tChọn loại máy lạnh (1-máy lạnh một chiều, 2-máy lạnh hai chiều): ");
                        while (true)
                        {
                            try
                            {
                                ACType = int.Parse(Console.ReadLine());
                                break;
                            }
                            catch (Exception)
                            {
                                Console.Write("\n\t\t\tChọn loại máy lạnh (1-máy lạnh một chiều, 2-máy lạnh hai chiều): ");
                            }
                        }
                        switch (ACType)
                        {
                            case 1:
                                devices = new OneWayAC();
                                break;
                            case 2:
                                devices = new TwoWayAC();
                                break;
                        }
                        break;
                }
                devices.AddDevice();
                this.totalPrice += devices.totalPrice();
                
                data += devices.getInfo();
                data += "\n\t--------------------";
            }

        }
        public string getInfo()
        {

            return $"\n----------Hóa đơn----------" +
            $"\n\n\tID: {this.id}" +
            $"\tNgày tạo: {this.dateCreated}" +
            $"\tGiá hóa đơn: {this.totalPrice}" +
            $"\n\n----------Thông tin khách hàng----------" +
            $"\n\t\t{customer.getInfo()}" +
            $"\n\n----------Chi tiết hóa đơn----------" +
            $"\n\t\t{data}";
        }


    }


}
