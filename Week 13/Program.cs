using System;

namespace Space{
    class Program
    {
        static void Main(string[] args) {
            Messi messi = new Messi();
            messi.age = 35;
            messi.nationality = "Argentina";
            messi.club = "PSG";
            messi.name = "Leo Messi";
            messi.Celebration();

            Teacher tea = new Teacher();
            //tea.Age = 10;
            Console.WriteLine(tea.Age);
            tea.Walk();

            Random r = new Random();
            string name = null  ;
            switch (r.Next(5))
            {
                case 0:
                    name = "Ali";
                    break;
                case 1:
                    name = "Veli";
                    break;
                case 2:
                    name = "Selami";
                    break;
                case 3:
                    name = "Ayşe";
                    break;
                case 4:
                    name = "Fatma";
                    break;
            }
            Console.WriteLine(name);

            ZShape z = new ZShape();
            z.MoveDown();
            z.WriteMessi();
        }
    }

    abstract class Footballer
    {
        public string name;
        public int age;

        public string club;
        public string nationality;

        public abstract void Celebration();
    }

    class Messi : Footballer
    {
        public override void Celebration()
        {
            Console.WriteLine("Alhamdulillah.");
        }
    }

    abstract class Person
    {
        public string name;
        private int age;

        public virtual int Age
        {
            get { return age; }
        }

        public string job;

        public abstract void Walk();
    }

    class Engineer : Person
    {
        private int age;

        public override int Age
        {
            get { return age; }
        }
        public override void Walk()
        {
            Console.WriteLine("Tak tak tak...");            
        }

    }

    class Teacher : Person
    {
        private int age;

        public override int Age
        {
            get { return age; }
        }
        public override void Walk() {
            Console.WriteLine("Bum bum bum...");
        }
    }

    class Doctor : Person
    {
        private int age;
        public override int Age
        {
            get { return age; }
        }
        public override void Walk() {
            Console.WriteLine("Kno kno kno...");
        }
    }

    abstract class Shape
    {
        public int messi=1;

        public abstract void MoveRight();

        public abstract void MoveLeft();

        public abstract void MoveUp();

        public abstract void MoveDown();
    }

    class TShape : Shape
    {
        public new int messi=2;

        public override void MoveDown()
        {
            Console.WriteLine("down t");
        }

        public override void MoveLeft()
        {
            Console.WriteLine("left t");
        }

        public override void MoveRight()
        {
            Console.WriteLine("right t");
        }

        public override void MoveUp()
        {
            Console.WriteLine("up t");
        }
    }

    class ZShape : TShape
    {

        public new int messi=3;

        public override void MoveDown()
        {
            Console.WriteLine("down z");
            base.MoveDown();
        }

        public override void MoveLeft()
        {
            Console.WriteLine("down z");
        }

        public override void MoveRight()
        {
            Console.WriteLine("down z");
        }

        public override void MoveUp()
        {
            Console.WriteLine("down z");
        }

        public void WriteMessi()
        {
            Console.WriteLine(messi);
            Console.WriteLine(base.messi);
            Console.WriteLine(((Shape)this).messi);
        }
    }
}
