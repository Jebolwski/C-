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

            //while (!Console.KeyAvailable)
            //{
            //    DateTime t = DateTime.Now;
            //    Console.Write("{0:D2}:{1:D2}:{2:D2}\r",t.Hour, t.Minute, t.Second);
            //}

            int[,] a = new int[9, 9]
            {
                {5, 3, 4, 6, 7, 8, 9, 1, 2 },
                {6, 7, 2, 1, 9, 5, 3, 4, 8 },
                { 1, 9, 8, 3, 4, 2, 5, 6, 7},
                {8, 5, 9, 7, 6, 1, 4, 5, 3 },
                {4, 2, 6, 8, 5, 3, 7, 9, 1},
                {7, 1, 3, 9, 2, 4, 8, 5, 6 },
                {9, 6, 1, 5, 3, 7, 2, 8, 4 },
                {2, 8, 7, 4, 1, 9, 6, 3, 5},
                {3, 4, 5, 2, 8, 6, 1, 7, 9 }
            };


            for(int i = 0; i < 9; i++)
            {
                
                int[] array = new int[9];
                //Getting 1d sinlge array
                for (int j=0;j<9;j++)
                {
                    array[j] = a[i,j];
                }
                int min_index = 0;
                for (int k = 0; k < 9; k++)
                {
                    min_index = k;
                    for (int b = k; b < 9; b++)
                    {
                        if (array[b] < array[min_index])
                        {
                            min_index = b;
                        }
                    }
                    int temp = array[min_index];
                    array[min_index] = array[k];
                    array[k] = temp;
                }
                for(int j=0; j<8; j++)
                {
                    if(array[j]+1 != array[j + 1])
                    {
                        Console.WriteLine("Olmaz {0}. satırda hata var.",i);
                        return;
                    }
                }
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