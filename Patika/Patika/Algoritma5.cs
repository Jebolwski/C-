using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input: ");
        string input = Console.ReadLine();

        string result = SwapFirstAndLast(input);

        Console.WriteLine("Output: " + result);
    }

    static string SwapFirstAndLast(string input)
    {
        if (input.Length <= 1)
            return input;

        char[] characters = input.ToCharArray();

        char firstChar = characters[0];
        char lastChar = characters[input.Length - 1];

        characters[0] = lastChar;
        characters[input.Length - 1] = firstChar;

        return new string(characters);
    }
}