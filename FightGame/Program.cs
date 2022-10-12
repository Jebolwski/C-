using System;

namespace FightGame
{
    class Program
    {
        public static void Main()
        {
            Fighter fighter1 = new Fighter(32,"The Diamond","Dustin Poririer",92,91,94);
            Fighter fighter2 = new Fighter(36, "Iron", "Michael Chandler", 86, 94, 93);
            int fighter1_count = 0;
            int fighter2_count = 0; 
            float roll_count = 200;
            for (int i = 0; i <roll_count; i++)
            {
                string fighter = Fight.FightResult(fighter1, fighter2);
                if (fighter == fighter1.nickname)
                {
                    fighter1_count++;
                }
                else if (fighter == "tie")
                {
                    Console.WriteLine("Tie");
                    fighter1_count++;
                    fighter2_count++;
                }
                else
                {
                    fighter2_count++;
                }
            }
            if (fighter1_count>fighter2_count )
            {
                float perc = (fighter1_count / roll_count) * 100;
                string perc1 = perc.ToString("0.00");
                Console.WriteLine(fighter1.fullname + " wins " + fighter1_count + " out of " + roll_count + " (" + perc1 + "%)");
            }
            else if(fighter1_count==fighter2_count){
                Console.WriteLine("It is a tie between " +fighter1.fullname+" and "+ fighter2.fullname);
            }
            else
            {
                float perc = (fighter2_count / roll_count) * 100;
                string perc1 = perc.ToString("0.00");
                Console.WriteLine(fighter2.fullname + " wins " + fighter2_count + " out of " + roll_count + " (" + perc1 + "%)");

            }
        }
    }
}