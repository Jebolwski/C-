using System;


namespace Program
{
    class Sample
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Foo(15,25));
            Console.WriteLine(isPrime(4));
            asalCarpanlar(1270);
            Console.WriteLine("\n-----------------");
            int n = 100;
            int i = 2;
            while (n != 1)
            {
                if (n % i == 0)
                {
                    Console.Write("{0} ", i);
                    n /= i;
                }
                else
                    i++;
            }
            Triangle(6);
            Console.Write("Radius of circle : ");
            int number = int.Parse(Console.ReadLine());
            
            
            Console.WriteLine("Area of the circle : "+AreaCircle(5)+" Perimeter of the circle : "+PerimeterCircle(6));
        }

        public static int Foo(int a=10,int b=20,int c=30)
        {
            Console.WriteLine("Foo()...");
            return a + b + c;
        }

        public static bool isPrime(int j)
        {
            for(int i = 2; i <= Math.Sqrt(j); i++)
            {
                if (j % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static void asalCarpanlar(int j)
        {
            for (int i = 2; i <=j/2; i++)
            {
                if ( isPrime(i) && j % i == 0)
                {
                    Console.Write(i+" ");
                }
            }
        }


        public static void Triangle(int j)
        {
            Console.WriteLine("\n");
            for(int i = 0; i <= j; i++)
            {
                for (int k = i; k<j; k++)
                {
                    Console.Write(j);
                }
                Console.Write("\n");
            }
        }
        
        public static double AreaCircle(int i)
        {
            return 3.14*i*i;
        }

        public static double PerimeterCircle(int i)
        {
            return 2 * 3.14 * i;
        }

    }
}