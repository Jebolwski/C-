using System;
using System.Collections;

namespace CreateEvent
{
    class Sample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------Create an event--------------");
            Console.Write("Event name : ");
            String eventName = Console.ReadLine();
            Console.Write("Event year : ");
            int eventYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------Add a fight--------------");
            ArrayList fighters = new ArrayList();
            Boolean flag = true;
            while (flag)
            {
                Console.Write("Fighter 1 name : ");
                String fighterName = Console.ReadLine();
                Fighter fighter = new Fighter(fighterName);
                Console.Write("Fighter 2 name : ");
                String fighterName1 = Console.ReadLine();
                Fighter fighter1 = new Fighter(fighterName1);
                fighters.Add(fighter.fighterName+" vs "+fighter1.fighterName);
                Console.Write("Do you want to continue (yes,no) : ");
                String flagString = Console.ReadLine().ToLower();
                if(flagString == "y" || flagString == "yes")
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }
            Event event1 = new Event(eventName,eventYear,fighters);
            Console.WriteLine("----------Event Summary---------");
            Console.WriteLine("Event Name : "+event1.eventName);
            Console.WriteLine("Event Year : "+event1.eventYear);
            Console.WriteLine("----------Event Lineup---------");
            foreach(String key in event1.eventFights)
            {
                Console.WriteLine(key);
            }
        }
    }
}
