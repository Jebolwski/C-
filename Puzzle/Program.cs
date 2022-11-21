using System;
using System.Runtime.InteropServices;

namespace Program
{
    class Sample
    {
        static void Main(string[] args)
        {
            //Aranan kelimeler
            string[] puzzleAnswers = new string[25] { "fastFood", "snape", "chriger", "obiwan", "forum", "program", "etkinlik", "bildirim", "yetenek", "hukuk", "sinema", "internet", "ticaret", "medya", "sorumluluk", "televisyon", "sistem", "ses", "taraf", "nugget","tehlike","teknoloji","yazar","kredi","hikaye" };
            //Verilen puzzle
            char[,] puzzle = new char[15, 21] { 
                { 'a', 'l', 'z', 'a', 'j', 'k', 'i', 'l', 'n', 'i', 'k', 't', 'e', 'h', 'b', 'n', 'k', 'n', 'd', 'm', 'i' }, 
                { 'x', 'q', 't', 'm', 'y', 'z', 'f', 'i', 'u', 'b', 'f', 'a', 'r', 'a', 't', 'a', 'w', 'r', 'a', 'a', 'y' },
                { 's', 'a', 'p', 'v', 'e', 'd', 'g', 't', 'g', 'c', 'o', 'y', 'i', 'd', 'b', 'w', 'k', 'u', 'j', 'g', 'q' }, 
                { 'h', 'o', 'v', 'l', 'z', 't', 'e', 'x', 'g', 's', 'r', 'w', 'o', 'b', 'i', 'i', 'p', 'v', 'w', 'r', 'q' },
                { 'j', 'k', 'r', 't', 'o', 'c', 's', 'm', 'e', 's', 'k', 'o', 'l', 'z', 'f', 'b', 't', 'i', 'm', 'y', 'e' }, 
                { 'z', 'e', 'k', 'u', 'l', 'a', 'n', 'i', 't', 'j', 'f', 'r', 'f', 'o', 'i', 'o', 'j', 'm', 'i', 'o', 'y' }, 
                { 'i', 'n', 'k', 'b', 'm', 'v', 's', 'z', 's', 't', 'k', 'e', 'e', 't', 'u', 'o', 'g', 'q', 'r', 'd', 'n' }, 
                { 'n', 'e', 'z', 'i', 'o', 'l', 'b', 'i', 's', 'i', 'a', 'h', 'e', 'd', 'l', 'q', 'x', 'p', 'i', 'l', 'y' }, 
                { 't', 't', 'w', 'k', 'l', 'v', 'u', 'a', 'n', 'w', 'd', 'r', 'p', 'o', 'i', 'h', 't', 'm', 'd', 'i', 'c' }, 
                { 'e', 'e', 'x', 'z', 'a', 'h', 'f', 'l', 'n', 'e', 'a', 'm', 'n', 'j', 'o', 'a', 'd', 'f', 'l', 'p', 'h' },
                { 'r', 'y', 't', 'h', 'w', 'q', 'e', 'i', 'u', 'c', 'm', 'k', 'k', 'n', 'i', 'w', 'f', 'f', 'i', 'k', 'r' },
                { 'n', 'h', 'u', 'k', 'u', 'k', 'a', 't', 'i', 'k', 'e', 'a', 'b', 't', 'n', 'h', 'j', 'o', 'b', 'a', 'i' },
                { 'e', 'e', 'y', 'a', 'k', 'i', 'h', 't', 'n', 't', 's', 'w', 'g', 'e', 'z', 'o', 's', 't', 'r', 'q', 'g' },
                { 't', 'e', 'q', 't', 'e', 'l', 'e', 'v', 'i', 'z', 'y', 'o', 'n', 'c', 'r', 'l', 'x', 'e', 'k', 'v', 'e' },
                { 'd', 'g', 'n', 't', 'd', 'n', 'k', 'm', 'a', 'r', 'g', 'o', 'r', 'p', 'f', 'p', 'q', 'z', 's', 'm', 'r' },
            };

            //YATAY GEÇİŞLER
            for(int i = 0; i < puzzle.GetLength(0); i++)
            {
                for(int j = 0; j < puzzle.GetLength(1); j++)
                {
                    string word = "";
                    for(int k=j;k<puzzle.GetLength(1); k++)
                    {
                        //Normal kelime oluşturuluyor
                        word += puzzle[i,k];
                        //Normal kelimenin tersi oluşturuluyor
                        char[] charArray = word.ToCharArray();
                        Array.Reverse(charArray);
                        string word1 = new string(charArray);
                        //Normal bulunan kelime aranan kelimeler listesinde mi diye bakılıyor
                        if (puzzleAnswers.Contains(word))
                        {
                            Console.WriteLine("================");
                            Console.WriteLine("Puzzlede kelime bulundu : "+word);
                            Console.WriteLine("Dikeyde bulundu {0}.satırda {1}.sutün ile {2}.sutün arasında.", i + 1, j + 1, k + 1);
                        }
                        //Normal kelimenin tersi aranan kelimeler listesinde mi diye bakılıyor
                        if (puzzleAnswers.Contains(word1))
                        {
                            Console.WriteLine("================");
                            Console.WriteLine("Puzzlede kelime bulundu : " + word1);
                            Console.WriteLine("Dikeyde bulundu {0}.satırda {1}.sutün ile {2}.sutün arasında.", i + 1, j + 1, k + 1);
                        }
                    }
                }
            }
        
            //DİKEY GEÇİŞLER
            for(int i = 0; i < puzzle.GetLength(1); i++)
            {
                for(int j=0; j<puzzle.GetLength(0); j++)
                {
                    string word = "";

                    for (int k = j; k < puzzle.GetLength(0); k++)
                    {
                        //Normal kelime oluşturuluyor
                        word += puzzle[k, i];
                        //Normal kelimenin tersi oluşturuluyor
                        char[] charArray = word.ToCharArray();
                        Array.Reverse(charArray);
                        string word1 = new string(charArray);

                        //Normal bulunan kelime aranan kelimeler listesinde mi diye bakılıyor
                        if (puzzleAnswers.Contains(word))
                        {
                            Console.WriteLine("================");
                            Console.WriteLine("Puzzlede kelime bulundu : " + word);
                            Console.WriteLine("Dikeyde bulundu {0}.sutünda {1}.satır ile {2}.satır arasında.",i+1,j+1,k+1);
                        }

                        //Normal kelimenin tersi aranan kelimeler listesinde mi diye bakılıyor
                        if (puzzleAnswers.Contains(word1))
                        {
                            Console.WriteLine("================");
                            Console.WriteLine("Puzzlede kelime bulundu : " + word1);
                            Console.WriteLine("Dikeyde bulundu {0}.sutünda {1}.satır ile {2}.satır arasında.", i + 1, j + 1, k + 1);
                        }
                    }
                }
            }

            //ÇAPRAZ GEÇİŞLER
            for (int i = 0; i < puzzle.GetLength(0); i++)
            {
                for (int j = 0; j < puzzle.GetLength(1); j++)
                {
                    string word = "";
                    int x = 0;
                    int y = 0;
                    while ((i + x)<puzzle.GetLength(0) && (j+y)<puzzle.GetLength(1))
                    {
                        
                        word += puzzle[(i+x), (j+y)];
                        char[] charArray = word.ToCharArray();
                        Array.Reverse(charArray);
                        string word1 = new string(charArray);
                        if (word1 == word)
                        {
                            word1 = "messi";
                        }
                        if (puzzleAnswers.Contains(word))
                        {
                            Console.WriteLine("================");
                            Console.WriteLine("Puzzleda kelime bulundu : "+word);
                            Console.WriteLine("Çaprazda bulundu puzzle[{0},{1}] ile puzzle[{2},{3}] arasında",i,j,i+x,j+y);
                        }

                        if (puzzleAnswers.Contains(word1))
                        {
                            Console.WriteLine("================");
                            Console.WriteLine("Puzzleda kelime bulundu : " + word1);
                            Console.WriteLine("Çaprazda bulundu puzzle[{0},{1}] ile puzzle[{2},{3}] arasında", i, j, i + x, j + y);
                        }

                        x += 1;
                        y += 1;
                    }
                }
            }

            for (int i = 0; i <puzzle.GetLength(0); i++)
            {
                for (int j = puzzle.GetLength(1)-1; j > 0; j--)
                {
                    string word = "";
                    int x = 0;
                    int y = 0;
                    while ((i+x) < puzzle.GetLength(0) && (j-y) > 0)
                    {

                        word += puzzle[(i+x), (j-y)];
                        char[] charArray = word.ToCharArray();
                        Array.Reverse(charArray);
                        string word1 = new string(charArray);
                        if (word1 == word)
                        {
                            word1 = "messi";
                        }
                        if (puzzleAnswers.Contains(word))
                        {
                            Console.WriteLine("================");
                            Console.WriteLine("Puzzleda kelime bulundu : " + word);
                            Console.WriteLine("Çaprazda bulundu puzzle[{0},{1}] ile puzzle[{2},{3}] arasında", i, j, x-i, j-y);
                        }

                        if (puzzleAnswers.Contains(word1))
                        {
                            Console.WriteLine("================");
                            Console.WriteLine("Puzzleda kelime bulundu : " + word1);
                            Console.WriteLine("Çaprazda bulundu puzzle[{0},{1}] ile puzzle[{2},{3}] arasında", i, j, x-i, j-y);
                        }

                        x += 1;
                        y += 1;
                    }
                }
            }


        }
    }
}
