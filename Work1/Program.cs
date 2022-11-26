using System;

namespace Program
{
    class Sample
    {
        private int m_age;
        public int Age { 
            get { return m_age; }
            set { m_age = value; } 
        }

        static void Main(string[] args)
        {
            Sample sample = new Sample();
            sample.Age = 13;
            //Console.WriteLine(sample.Age);
            //Struct 
            Footballer messi;
            messi = new Footballer();
            messi.Age = 34; 
            messi.Name = "Leo Messi";
            messi.Speed = 89;
            messi.Shoot = 91;
            messi.Dribble = 95;
            messi.Nationality = "Argentina";
            messi.Pass = 92;
            messi.Phsicality = 76;
            //messi.ShootGoal();

            while (!Console.KeyAvailable)
            {
                DateTime t = DateTime.Now;
                Console.Write("{0:D2}:{1:D2}:{2:D2}\r",t.Hour, t.Minute, t.Second);
            }

        }

        struct Footballer
        {
            private int speed;
            private int age;
            private int dribble;
            private int shoot;
            private int pass;
            private int phsicality;
            string name;
            string nationality;
            

            public int Speed { get => speed; set => speed = value; }
            public int Age { get => age; set => age = value; }
            public int Dribble { get => dribble; set => dribble = value; }
            public int Shoot { get => shoot; set => shoot = value; }
            public int Pass { get => pass; set => pass = value; }
            public int Phsicality { get => phsicality; set => phsicality = value; }
            public string Name { get => name; set => name = value; }
            public string Nationality { get => nationality; set => nationality = value; }

            public void ShootGoal()
            {
                Console.WriteLine(name+" shoots and GOALLLLLLLLL!");
            }
        }
    }
}