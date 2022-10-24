using System;

namespace Program
{
    class Sample
    {
        static void Main(string[] args)
        {

            Console.WriteLine(myPow(3, 5));
            Console.WriteLine(mySqrt(5)); 
            Console.WriteLine(getE(14));
        }
        public static double myPow(double num1,double num2)
        {
            if (num2 == 0) {
                return 1;
            }
            else
            {
                return num1*myPow(num1, num2-1);
            }
        }

        public static double mySqrt(double num1)
        {
            return Math.Pow(num1,0.5);
        }

        public static double getE(double j)
        {
            double result;
            if ((int)(j) <= 1)
            {
                return 1;
            }
            else
            {
                result = 1/(factorial((int)(j) - 1));
                return result+getE(j-1);
            }
            
            
        }
        static double factorial(int i)
        {
            if (i == 0 || i == 1)
            {
                return 1;
            }
            else
            {
                return i * factorial(i - 1);
            }
        }
    }
}
