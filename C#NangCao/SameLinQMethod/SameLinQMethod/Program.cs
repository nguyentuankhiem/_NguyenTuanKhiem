using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SameLinQMethod
{   
    public class Car
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }

        // contructor
        public Car(int id, string name, int year)
        {
            this.ID = id;
            this.Name = name;
            this.Year = year;
        }
        public override string ToString()
        {
            return $"{this.ID} - {this.Name} - {this.Year}";
        }
    }

    // same LinQ Method
    public static class SameLinQMethod
    {
        public static IEnumerable<T> MyMethod<T>(this IEnumerable<T> list, Func<T, bool> myCodition)
        {
            foreach (var item in list)
            {
                if (myCodition(item)) yield return item;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // fake data list 
            var carList = new List<Car>
            {
                new Car(1, "Toyota", 1990),
                new Car(2, "Mazda", 1920),
                new Car(3, "Mitsubishi", 1870)
            };

            var list = carList.MyMethod(c => c.Year >= 1900);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
