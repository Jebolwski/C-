using System;

namespace Program
{
    class Sample
    {
        static void Main(string[] args)
        {
            Youtube youtube = new Youtube();
            Video video = new Video();
            video.duration = 258;
            video.name = "Thats life - Frank Snitra";
            Youtube.PlayVideo(video);
            B b = new B();
            b.a = 10;
            b.d = 20;

            Dog boncuk = new Dog();
            Dog siyah = new Dog("Siyah",5,"Dog");
            boncuk.Age = 16;
            boncuk.Name = "Boncuk";
            boncuk.Type = "Dog";

            ToyShop AhmetinDukkani = new ToyShop();
            Toy[] toys = new Toy[100];
            Random rand = new Random();
            for (int i = 0; i < toys.Length; i++)
            {
                toys[i]=new Toy(rand.Next(0,100)*10,"Toy "+i);
            }
            AhmetinDukkani.toys = toys;
            AhmetinDukkani.name = "Ahmetin Dükkanı";
            AhmetinDukkani.city = cities.Sivas;
            Console.WriteLine(siyah.Name+" "+siyah.Age+" "+siyah.Type);

            AhmetinDukkani.ToString1();


            Engineer ahmet = new Engineer(1400,"BTÜ","Ahmet",20);
        }
    }

    class Engineer : Person
    {
        public int wage;
        public string company;

        public Engineer() : base(){}

        public Engineer(int wage, string company,string name,int age) : base(name,age)
        {
            this.wage = wage;
            this.company = company;
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

    class Youtube
    {
        public static void PlayVideo(Video vid)
        {
            Console.WriteLine("Now playing the video {0}, time left for video to end is {1} seconds.", vid.name, vid.duration);
        }
    }

    class Video
    {
        public string name;
        public int duration;

    }

    class A
    {
        public int a;
        protected int b;
        private int c;

        public A()
        {

        }

        public A(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
    }

    class B : A
    {
        public int d;
        protected int e;

        public B():base()
        {
        }

        public B(int d,int e,int a) : base(a,d,e)
        {
            this.d = d;
            this.e = e;
        }
    }

    class Dog : Animal
    {
        public Dog() : base() { }

        public Dog(string name,int age,string type) : base(name, age, type) { }


    }

    class Animal
    {
        private string name;
        private int age;
        private string type;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public Animal()
        {

        }

        public Animal(string name, int age, string type)
        {
            Name = name;
            Age = age;
            Type = type;
        }
    }


    class ToyShop
    {
        
        public string name;
        public cities city;
        //Aggregation
        public Toy[] toys = new Toy[100];

        public ToyShop(){}

        public ToyShop(string name, cities city, Toy[] toys)
        {
            this.name = name;
            this.city = city;
            this.toys = toys;
        }

        public void ToString1()
        {
            Console.WriteLine("============== "+this.name +" ==============\n"+"Dükkanın bulunduğu şehir : "+this.city+"\n"+"==== Dükkandaki Oyuncaklar =====");
            foreach (Toy item in this.toys)
            {
                Console.WriteLine(item.name+", "+item.price+ " tl");
            }
        }
    }


    enum cities
    {
        New_York,Istanbul,Bursa,North_Bergan,Colarado,Sivas
    }

    class Toy
    {

        public double price;
        public string name;
        private Func<int> next;
        private string v;

        public Toy(){}

        public Toy(int price, string name)
        {
            this.price = price;
            this.name = name;
        }

    }

    class Bullet
    {
        public string name;
        public int count;
        public Bullet(){}

        public Bullet(string name, int count)
        {
            this.name = name;
            this.count = count;
        }
    }

    class Gun
    {
        public string name;
        public int production_year;
        public Bullet ammo;
        public Gun(){}

        public Gun(string name, int production_year,int count)
        {
            this.ammo = new Bullet("5.76", count);
            this.name = name;
            this.production_year = production_year;
        }
    }

}