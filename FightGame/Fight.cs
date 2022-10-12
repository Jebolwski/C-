using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightGame
{
    internal class Fight
    {
        public static string FightResult(Fighter Fighter1, Fighter Fighter2) {
            Random rd = new Random();   
            int rd1 = rd.Next(100, 140);
            int rd2 = rd.Next(100, 140);    
            int fighter1_point = Fighter1.strength + Fighter1.speed + Fighter1.health + rd1;
            int fighter2_point = Fighter2.strength + Fighter2.speed + Fighter2.health + rd2;
            if (fighter1_point > fighter2_point) {
                Console.WriteLine(fighter1_point +", "+ fighter2_point);
                return Fighter1.nickname;
            }
            else if (fighter1_point==fighter2_point)
            {
                Console.WriteLine(fighter1_point + ", " + fighter2_point);
                return "Tie";
            }
            else
            {
                Console.WriteLine(fighter2_point +", "+ fighter1_point);
                return Fighter2.nickname;
            }
        }

    }
}
