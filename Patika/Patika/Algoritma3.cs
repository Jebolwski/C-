using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("İkili sayıları girin (n tane, boşlukla ayrılmış):");
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');

        Dictionary<int, int> sums = new Dictionary<int, int>();

        for (int i = 0; i < numbers.Length; i += 2)
        {
            int firstNumber = int.Parse(numbers[i]);
            int secondNumber = int.Parse(numbers[i + 1]);
            int sum = firstNumber + secondNumber;

            if (sums.ContainsKey(sum))
            {
                Console.Write((firstNumber == secondNumber ? sum * sum : sum) + " ");
            }
            else
            {
                sums.Add(sum, 0);
                Console.Write(sum + " ");
            }
        }
    }
}
