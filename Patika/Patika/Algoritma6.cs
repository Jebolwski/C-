using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input: ");
        string input = Console.ReadLine();

        string[] words = input.Split(' ');

        foreach (string word in words)
        {
            bool hasConsecutiveConsonants = CheckConsecutiveConsonants(word);
            Console.Write(hasConsecutiveConsonants + " ");
        }
    }

    static bool CheckConsecutiveConsonants(string word)
    {
        for (int i = 0; i < word.Length - 1; i++)
        {
            if (IsConsonant(word[i]) && IsConsonant(word[i + 1]))
            {
                return true;
            }
        }
        return false;
    }

    static bool IsConsonant(char c)
    {
        char[] consonants = { 'b', 'c', 'd', 'f', 'g', 'ğ', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'r', 's', 'ş', 't', 'v', 'y', 'z',
                               'B', 'C', 'D', 'F', 'G', 'Ğ', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'R', 'S', 'Ş', 'T', 'V', 'Y', 'Z'};

        foreach (char consonant in consonants)
        {
            if (c == consonant)
            {
                return true;
            }
        }
        return false;
    }
}
