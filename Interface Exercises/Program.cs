using Interface_Exercises;
using System;

namespace Program
{
    class Program{
        static void Main()
        {
            Car car = new Car();
            car.name = "Subra";
            car.year = 2005;
            car.fuel = 0;
            car.Drive();
            car.Refuel(10);
            car.Drive();

            Dog dog = new Dog();
            dog.Setname("Boncuk");
            dog.Eat();
            dog.Getname();
        }
    }
}
