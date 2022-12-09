using System;

namespace Program
{
    class Sample
    {
        static void Main(string[] args)
        {
            Date date = new Date();
            date.Day = 20;
            date.Year = 2004;
            date.Month = 11;

            Browser edge;

            edge.price = 0;
            edge.name = "Edge";
            edge.create_date = 2013;

            edge.price = edge.create_date;

            Console.WriteLine(edge.price+" "+edge.create_date);

            Browser chrome = new Browser("Chrome",2010,0);

            Console.WriteLine(chrome.name);

            DateTime time1 = new DateTime(2003,10,18,0,10,0);

            DateTime time2 = new DateTime(2004, 10, 18, 0, 10, 0);

            Console.WriteLine(time1>time2);

            Console.WriteLine(time1.ToString());

            //Console.Write("Enter a date : ");

            //DateTime dt = DateTime.Parse(Console.ReadLine());

            //Console.WriteLine(dt.ToString());

            string sentence = "ben {messiyim} sen penaldosun.";

            int firstIndex = sentence.IndexOf("{");
            int lastIndex = sentence.IndexOf("}");

            string sentence_small = sentence.Substring(firstIndex+1,lastIndex-firstIndex-1);

            sentence.Remove(3, 10);

            Console.WriteLine(sentence);
            
            Console.WriteLine("bulduğumuz : "+sentence_small);

            string sentence1 = "ben ronaldoyum sen penaldosun.";

            string word = "ronaldoyum";

            string begstring = sentence1.Substring(0,sentence1.IndexOf(word));
            string endstring = sentence1.Substring(sentence.IndexOf(word)+1);

            Console.WriteLine(begstring+" "+endstring);

            Sample sample = new Sample();
            Direction d=Direction.Up;
            sample.GoToDirection(d);

            char character;

            character = Console.ReadKey(true).KeyChar;

            Console.WriteLine(character+" ---------");
        }



        public void GoToDirection(Direction d)
        {
            Console.WriteLine(d+"="+(int)d);
        }
    }

    

    enum Direction
    {
        Right=1,Up=5,Down,Left
    }

    class Date
    {
        private int day;
        private int month;
        private int year;

        public int Day
        {
            get { return day; }
            set { day = value; }
        }

        public int Month { 
            get { return month; }
            set { month = value; }
        }

        public int Year
        {
            get { return year; }
            set
            {
                year = value;
            }
        }
    }

    struct Browser
    {
        public string name;
        public int create_date;
        public int price;

        public Browser(string name,int create_date,int price){
            this.name = name;
            this.create_date = create_date;
            this.price = price;
        }
    }
}
