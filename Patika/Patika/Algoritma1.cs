using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input: ");
        string input = Console.ReadLine();

        string result = SwapCharactersWithPrevious(input);

        Console.WriteLine("Output: " + result);
    }

    static string SwapCharactersWithPrevious(string input)
    {
        char[] chars = input.ToCharArray();

        for (int i = 1; i < chars.Length; i++)
        {
            char temp = chars[i];
            chars[i] = chars[i - 1];
            chars[i - 1] = temp;
        }

        return new string(chars);
    }
}
