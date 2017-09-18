using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[5];
            cars[0] = new Car("Car",000,"Audi","C125","black",3.3,350);
            cars[1] = new Car("Car", 000, "BMW", "x5", "black", 5.0, 420);
            cars[0].Show();

            Console.Read();
        }
    }
}
