using System;
using System.Collections;


namespace Program
{
    class Sample
    {
        static void Main(string[] args)
        {
            B b = new B();
            A a = new A();
            object c;
            c = a;
            Console.WriteLine(c.GetType().Name);
            a = b;
            Console.WriteLine(a.GetType().Name);
            object[] objs;
            objs = new object[] { "Ankara", new A(), new B(), new Random() };
            foreach (object o in objs)
                Console.WriteLine(o.GetType().Name);

            int d = 42;
            object e = (object)d;
            Console.WriteLine(e+" "+(int)e);

            ArrayList list = new ArrayList();

            list.Add(e);
            list.Add(a);
            list.Add("messi");
            list.Add(a);
            list.Add("messi");

            Console.WriteLine("eleman sayisi : "+list.Count);
            Console.WriteLine("kapasite : "+list.Capacity);

            Taban tab;

            Taban tab1= new Taban();

            Turemis tur = new Turemis();

            tab = tur;

            Type ture = typeof(Turemis);


            Console.WriteLine(ture.BaseType.Name);

            VideoGame mgs = new VideoGame(null,"Metal Gear Solid",2007,85);
            Console.WriteLine(mgs.ToString());
            Console.WriteLine("===============");
            Foo(tab1);
            Foo(tab);
            Foo(tur);
            Console.WriteLine("===============");

            object obje;
            int num = 214;
            double longnum;
            
            //Kutulama
            obje= (object)num;
            longnum= (int)obje;
            Console.WriteLine(longnum);
            Console.WriteLine("=================");
            ArrayList arrayList= new ArrayList();
            
            arrayList.Add(num);
            arrayList.Add(longnum);
            arrayList.Add(obje);

            foreach(object item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("messi");
            Kutuphane kutuphane = new Kutuphane(2019,"Millet Kütüphanesi",198);
            Console.WriteLine("ronaldo");
            Console.WriteLine(kutuphane.ToString());
            
        }
        public static void Foo(object o)

        {
            Console.WriteLine(o.GetType().Name);

        }
    }

    class A
    {

        public int messi;

        public A() : this(20) {
            Console.WriteLine("A default construtor...");
        }

        public A(int x)
        {
            messi = x;
            Console.WriteLine("A(int x) constructor...");
        }
    }

    class B : A 
    {
        public int ronaldo;
        public B() : this(20) {
            Console.WriteLine("B default constructor...");
        }
        public B(int x)
        {
            ronaldo = x;
            Console.WriteLine("B(int x) constructor...");
        }
    }


    class Taban
    {
        public int a;
    }

    class Turemis : Taban
    {
        public int b;
    }


    class Consolee
    {
        public string name { get; set; }
        public int release_date { get; set; }

        public Consolee() { }

        public Consolee(string name, int release_date)
        {
            this.name = name;
            this.release_date = release_date;
        }
    }

    class VideoGame
    {
        Consolee[] consoles = new Consolee[5];

        public VideoGame(Consolee[] consoles, string name, int release_date, int score)
        {
            this.consoles = consoles;
            this.name = name;
            this.release_date = release_date;
            this.score = score;
        }

        public string name { get; set; }
        public int release_date { get; set; }

        public int score { get; set; }

        public VideoGame() { }


        public override string ToString()
        {
            return this.name + "-" + this.score + "-" + this.release_date;
        }

    }

    class Person
    {
        public string name;
        public int age;

        public Person() { }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }   
    }

    class Kutuphane
    {
        private int creationdate;
        private string name;
        private int capacity;
        public int creation_date
        {
            get { return creationdate; }
            set { creationdate = value > 500 ? value : -1; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value > 5 ? value : -1; }
        }

        public Kutuphane(int creation_date, string name, int capacity)
        {
            this.creation_date = creation_date;
            this.Name = name;
            this.Capacity = capacity;
        }

        public Kutuphane() { }

        public override string ToString()
        {
            return this.Name+"-"+this.creation_date+"-"+this.Capacity;
        }
    }
}