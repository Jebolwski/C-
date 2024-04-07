using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input: ");
        string input = Console.ReadLine();

        string[] parts = input.Split(',');

        foreach (string part in parts)
        {
            if (part.Length >= 2 && int.TryParse(part.Substring(part.IndexOf(',') + 1), out int index))
            {
                string text = part.Substring(0, part.IndexOf(','));
                if (index >= 0 && index < text.Length)
                {
                    Console.Write(text.Remove(index, 1) + " ");
                }
                else
                {
                    Console.Write("Invalid index! ");
                }
            }
            else
            {
                Console.Write("Invalid input format! ");
            }
        }

        Console.WriteLine();
    }
}
