using System;

namespace Program
{
    class Sample
    {
        static void Main(string[] args)
        {
            Console.WriteLine(myPow(3, 4));
            Console.WriteLine(mySqrt(5)); 
            Console.WriteLine(eulerNumber());
        }
        public static double myPow(double num1,int num2)
        {
            double result=1;
            for (int i = 1; i <= num2; i++)
            {
                result *=num1;
            }
            return (int)(result * 100)/ 100.0;
        }

        public static double mySqrt(double num1)
        {
            return Math.Pow(num1,0.5);
        }

        public static double eulerNumber()
        {
            // euler number
            double number = 0;
            //numbers from 1 to 14
            for(int i = 1; i < 14; i++)
            {
                
                double factorial = 1;
                int num = i;
                //calculating factorial
                while (num>1)
                {
                    num--;
                    factorial *=num;
                }
                number+=1/factorial;
            }
            return number;
        }
    }
}
