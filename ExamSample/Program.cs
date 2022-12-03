using System;

namespace Program
{
    class Sample
    {
        static void Main(string[] args)
        {
            Sample sample = new Sample();
            Console.WriteLine(sample.MathOperation(5,7));
            Random rnd = new Random();
            int[] dizi = new int[100];
            for (int i = 0; i < dizi.Length; i++)
                dizi[i] = rnd.Next(10, 99);
            int buyuk, kucuk;
            Buyuk_Kucuk(dizi, out buyuk, out kucuk);
            Console.Write("{0}---{1}", buyuk, kucuk);

        }

        class S1 { 
            public static int a= 1; 
            public static int b= 1; 
            public static int c= 1; 
        }
        class S2 { 
            void M2() { 
                S1.c = S1.a + S1.b; 
            } 
        }
        class S3 : S1 { 
            void M3() {
                S1.c = S1.a + S1.b; 
            } 
        }

        class Kare
        {
            private int kenar;

            public int Kenar { get => kenar; set => kenar = kenar < 0 ? 1 : value; }

            public int Alan()
            {
                return kenar * kenar;
            }
        }

        public static void Buyuk_Kucuk(int[] dizi, out int buyuk, out int kucuk)
        {
            buyuk = 0; kucuk = 100;
            foreach (var item in dizi)
            {
                if (item > buyuk) buyuk = item;
                if (item < kucuk) kucuk = item;
            }
        }
        
        public int MathOperation(int a, int b)
        {
            return a+b;
        }

        public int MathOperation(int a, int b, int c)
        {
            return a * b * c;
        }
    }
}