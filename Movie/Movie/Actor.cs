using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie
{
    internal class Actor : Human
    {
        public Movie movie;
        public String character_name;
        public String character_age;
        public String gender;
        public String character_photo_url;

        public Actor(Movie movie, string character_name, string character_age, string gender, string character_photo_url)
        {
            this.movie = movie;
            this.character_name = character_name;
            this.character_age = character_age;
            this.gender = gender;
            this.character_photo_url = character_photo_url;
        }
    }
}
