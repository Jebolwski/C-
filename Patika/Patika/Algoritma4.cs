using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Sayıları girin (n tane, boşlukla ayrılmış):");
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');

        int sumOfDifferences = 0;
        int sumOfSquaredDifferences = 0;

        foreach (string number in numbers)
        {
            int num = int.Parse(number);
            int difference = Math.Abs(67 - num);

            if (num < 67)
            {
                sumOfDifferences += difference;
            }
            else
            {
                sumOfSquaredDifferences += difference * difference;
            }
        }

        Console.WriteLine($"Output: {sumOfDifferences} {sumOfSquaredDifferences}");
    }
}
