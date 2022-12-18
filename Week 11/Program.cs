using System;
using System.Collections;
using System.Xml.Linq;


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

            Turemis tur = new Turemis();

            tab = tur;

            Type ture = typeof(Turemis);


            Console.WriteLine(ture.BaseType.Name);
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
}