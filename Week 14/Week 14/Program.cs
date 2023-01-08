using System;

namespace Program
{
    class App
    {
        static void Main(string[] args)
        {
            Deleg deleg;
            App app=new App();
            deleg = new Deleg(app.ReturnRandom);
            deleg();
            Console.WriteLine("========");
            int[]array= new int[10] {3,4,6,2,7,4,12,4,2,7};
            Wat(new Deleg1(disp), array);
        }

        public static void Wat(Deleg1 deleg,int[] array)
        {
            for (int i = 0; i < 10; i++)
            {
                Random random = new Random();
                array[i] = random.Next(10);
            }
            foreach(int i in array)
            {
                deleg(i);
            }

        }

        public static void disp(int x)
        {
            Console.WriteLine(x);
        }
        public void ReturnRandom()
        {
            Random random= new Random();
            Console.WriteLine(random.Next(10));
        }
    }

    delegate void Deleg();
    delegate void Deleg1(int x);
}