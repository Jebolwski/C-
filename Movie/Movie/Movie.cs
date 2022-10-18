using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie
{
    internal class Movie
    {
        double imdb_rating;
        String movie_name;
        int budget;
        int year;
        int ticket_sales;
        public ArrayList actors;

        public Movie()
        {

        }

        public Movie(double imdb_rating, string movie_name, int budget, int year, int ticket_sales)
        {
            this.imdb_rating = imdb_rating;
            this.movie_name = movie_name;
            this.budget = budget;
            this.year = year;
            this.ticket_sales = ticket_sales;
        }

        public void MovieInfo()
        {
            Console.WriteLine("Movie is named " + this.movie_name + ". It has " + this.imdb_rating + " rating on imdb.");
            Console.WriteLine("ACTORS :");
            foreach (Actor actor in actors)
            {
                Console.WriteLine(actor.character_name);
            }
        }

    }
}
