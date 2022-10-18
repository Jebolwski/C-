using System;
using System.Collections;

namespace Movie
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie Sopranos = new Movie(9.45,"The Sopranos",120000,1997,10000000);
            Actor JamesGadolfini = new Actor(Sopranos,"Tony Soprano","40s","Male", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fsopranos.fandom.com%2Fwiki%2FTony_Soprano&psig=AOvVaw0N0SPg-lulukchePa8NK5n&ust=1666173977774000&source=images&cd=vfe&ved=0CAwQjRxqFwoTCIDW8_LD6foCFQAAAAAdAAAAABAE");
            ArrayList actors = new ArrayList();
            actors.Add(JamesGadolfini);
            Sopranos.actors = actors;

            Sopranos.MovieInfo();
        }
    }
}
