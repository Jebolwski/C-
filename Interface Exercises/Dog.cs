using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Exercises
{
    internal class Dog : Animal
    {

        public override void Eat()
        {
            Console.WriteLine(this.Getname()+" is eating");
        }
    }
}
