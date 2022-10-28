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
            Console.WriteLine("\n****************");
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


    }
}