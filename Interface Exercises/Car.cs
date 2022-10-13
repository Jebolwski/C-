using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Exercises
{
    internal class Car : IVehiculo
    {
        public int year { get; set; }
        public string name { get; set; }
        public int fuel { get; set; }

        public void Drive()
        {
            if (this.fuel > 0)
            {
                Console.WriteLine("Driving the car " + this.name);
            }
            else
            {
                Console.WriteLine("Cant drive the car, there is no fuel left.");
            }
        }

        public bool Refuel(int fuel)
        {
            Console.WriteLine("Refueling "+this.name);
            this.fuel += fuel;
            return true;
        }
    }
}
