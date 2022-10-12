using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightGame
{
    internal class Fighter
    {
        public int age { get; set; }
        public string nickname { get; set; }
        public string fullname { get; set; }
        public int health { get; set; }
        public int strength { get; set; }
        public int speed { get; set; }

        public Fighter(int age, string nickname, string fullname, int health, int strength, int speed)
        {
            this.age = age;
            this.nickname = nickname;
            this.fullname = fullname;
            this.health = health;
            this.strength = strength;
            this.speed = speed;
        }

        public override string ToString()
        {
            return this.fullname.Split(" ")[0] + " " + this.nickname + " " + this.fullname.Split(" ")[1];
        }
    }
}
