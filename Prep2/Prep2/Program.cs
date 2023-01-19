using System;
using System.Collections;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            int jun = 3;
            Months mon = (Months)jun;
            Console.WriteLine(mon);
            Console.WriteLine((int)Months.June);
            string s;
            int index;
            s = "eskişehir";
            index = s.IndexOf('i');
            if (index == -1)
                System.Console.WriteLine("Cannot find!..");
            else
                System.Console.WriteLine("Found at the {0} index", index);

            string sentence = "Ben messi sen ronaaaldo.";
            string word = "messi";
            string result = "";
            int indeks=sentence.IndexOf(word);
            string left = sentence.Substring(0,indeks);
            string right= sentence.Substring(indeks+word.Length,sentence.Length-(indeks + word.Length));
            result += left +"{"+word+"}"+ right;
            Console.WriteLine(result);
            int count = 0;
            for(int i=0;i<sentence.Length;i++) {
                if (sentence[i] == 'a')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            //while (true)
            //{
            //    char a = Console.ReadKey(true).KeyChar;
            //    if (a == 'q')
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine(a);
            //    }
            //}

            //Sample k = new Sample(1);
            Sample mess = new Sample(2,4); 
            Type t = typeof(Test);
            Console.WriteLine(t.BaseType.Name);
            Console.WriteLine(typeof(string[]).BaseType.Name);
            A x;
            B y = new B();
            C z = new C();
            x = y;
            y = z;
            Console.WriteLine("{0}, {1}, {2}", x.GetType().Name, y.GetType().Name, z.GetType().Name);

            object[] objs = new object[] { "Ankara", new A(), new B(), new C(), new Random() };
            foreach (object o in objs)
                Console.WriteLine(o.GetType().Name);
            A a = new C();
            B b;
            b = (C)a;
            Console.WriteLine(b.GetType().Name);
            ArrayList arl = new ArrayList();
            arl.Add("messi");
            arl.Add(3);
            arl.Add(b);
            arl.Insert(3, a);
            arl.Add("ne");
            foreach (object item in arl)
            {
                Console.Write(item+",");
            }
            Console.WriteLine();
            Console.WriteLine(arl.Count);
            Console.WriteLine(arl.Capacity);
            arl.RemoveAt(3);
            arl.RemoveAt(3);
            Console.WriteLine(arl.Count);
            Console.WriteLine(arl.Capacity);
            A an;
            C c = new C();
            an = c;
            an.Foo(0);
            an.Bar(0);
            ArrayList al = new ArrayList();
            al.Add(new Sample());
            al.Add(new Mample());
            al.Add(new Tample());
            foreach (object o in al)
                Console.WriteLine(o.ToString());

            Console.WriteLine(a.Bar);
        }
        
        class Mample
        {
            public override string ToString()
            {
                return "This is a Mample";
            }
        }
        class Tample
        {
            public override string ToString()
            {
                return "This is a Tample";
            }
        }

        class A
        {
            public virtual void Foo(int a)
            {
                Console.WriteLine("A.Foo");
            }
            public void Bar(int a)
            {
                Console.WriteLine("A.Bar");
            }
            //...
        }
        class B : A
        {
            public override void Foo(int a)
            {
                Console.WriteLine("B.Foo");
            }
            public new void Bar(int a)
            {
                Console.WriteLine("B.Bar");
            }
            //...
        }
        class C : B
        {
            public override void Foo(int a)
            {
                Console.WriteLine("C.Foo");
            }
            public new void Bar(int a)
            {
                Console.WriteLine("C.Bar");
            }
            //...
        }

        class Sample
        {
            private int m_a;
            private int m_b;
            private string m_name;
            public Sample() : this(10, 20, "No name")
            {
                Console.WriteLine("default constructur");
            }
            public Sample(int a) : this(a, 20, "No name")
            {
                Console.WriteLine("int int constructor: {0}", a);
            }
            public Sample(int a, int b) : this(a, b, "No name")
            {
                Console.WriteLine("int int constructor: {0}, {1}", a, b);
            }
            public Sample(int a, int b, string name)
            {
                m_a = a;
                m_b = b;
                m_name = name;
                Console.WriteLine("int int, string constructor: {0}, {1}, {2}", a, b, name);
            }
        }

        struct Test
        {
            //...
        }

        enum Months
        {
            Jan,Feb,March,Apr,May,June,July,August,Sep,Oct,November,December
        }
    }
}