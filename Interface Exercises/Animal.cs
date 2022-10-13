using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Exercises
{
    internal abstract class Animal
    {
        private string name;

        public string Getname()
        {
            return name;
        }

        public void Setname(string value)
        {
            name = value;
        }

        public abstract void Eat();
    }
}
