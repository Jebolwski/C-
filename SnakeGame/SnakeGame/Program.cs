using System;
using System.IO;

namespace Program
{
    class Sample
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            int[] X = new int[10];
            int[] Y = new int[10];
            int parts = 5;
            for(int i = 0; i < 5; i++)
            {
                X[i] = 44-i;
                Y[i] = 15;
                Console.SetCursorPosition(X[i], Y[i]);
                if (i == 0)
                {
                    Console.Write("0");
                }
                else
                {
                    Console.Write("*");
                }
            }
            while(true)
            {

                for (int i = parts; i > 1; i--)
                {
                    X[i - 1] = X[i - 2];
                    Y[i - 1] = Y[i - 2];
                }
                
                char key = Console.ReadKey(true).KeyChar;
                switch (key)
                {
                    case 'w':
                        Y[0]--;
                        break;
                    case 's':
                        Y[0]++;
                        break;
                    case 'd':
                        X[0]++;
                        break;
                    case 'a':
                        X[0]--;
                        break;
                }
                
                Console.Clear();
                for (int i = 0; i <= (parts-1); i++)
                {
                    if (X[i] < 0 || X[i] > Console.WindowWidth-1)
                    {
                        Console.WriteLine("Yatayda sınırlar geçildi.");
                        goto GAME_OVER;
                    }
                    if (Y[i] < 0 || Y[i] > Console.WindowHeight-1)
                    {
                        Console.WriteLine("Dikeyde sınırlar geçildi.");
                        goto GAME_OVER;
                    }
                    
                    for (int j = 1; j <= (parts-1); j++)
                    {
                        if ((X[j] == X[0]) && (Y[j] == Y[0])){
                            Console.WriteLine("Kendine çarptın.");
                            goto GAME_OVER;
                        }
                    }
                    
                    Console.SetCursorPosition(X[i], Y[i]);
                    if (i == 0)
                    {
                        Console.Write("0");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                
            }
            GAME_OVER:
                Console.WriteLine("Oyun Bitti.");
        }
        
    }
}
