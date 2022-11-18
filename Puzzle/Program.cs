using System;


namespace Program
{
    class Sample
    {
        static void Main(string[] args)
        {
            string[] puzzleAnswers = new string[12] {"MORS","FEN","KARABİBER","İNCİR","OKSİJEN","TOPUK","ZARARLI","ORANGUTAN","ZEMİN","SİLMEK","DÖRT","MEYVE"};
            char[,] puzzle = new char[13, 11] { 
                { 'S', 'İ', 'D', 'S', 'I', 'K', 'O', 'F', 'T', 'L', 'A' }, 
                { 'N', 'T', 'N', 'P', 'M', 'K', 'I', 'F', 'O', 'Y', 'G' },
                { 'A', 'U', 'P', 'C', 'S', 'K', 'M', 'O', 'R', 'S', 'Y' }, 
                { 'T', 'V', 'Z', 'İ', 'İ', 'A', 'Z', 'H', 'I', 'I', 'A' },
                { 'I', 'O', 'J', 'R', 'K', 'R', 'A', 'T', 'N', 'E', 'F' }, 
                { 'G', 'E', 'P', 'V', 'F', 'A', 'R', 'T', 'G', 'H', 'E' }, 
                { 'N', 'M', 'M', 'U', 'Z', 'B', 'A', 'R', 'K', 'K', 'U' }, 
                { 'A', 'Z', 'E', 'H', 'K', 'İ', 'R', 'A', 'E', 'F', 'K' }, 
                { 'R', 'F', 'Y', 'T', 'F', 'B', 'L', 'A', 'M', 'V', 'V' }, 
                { 'O', 'F', 'V', 'R', 'I', 'E', 'I', 'K', 'L', 'E', 'V' },
                { 'E', 'D', 'E', 'Ö', 'M', 'R', 'A', 'N', 'İ', 'O', 'G' },
                { 'R', 'D', 'M', 'D', 'K', 'U', 'Z', 'O', 'S', 'E', 'M' },
                { 'Y', 'V', 'N', 'N', 'İ', 'M', 'E', 'Z', 'T', 'T', 'U' },
            };

            //YATAY GEÇİŞLER
            for(int i = 0; i < puzzle.GetLength(0); i++)
            {
                for(int j = 0; j < puzzle.GetLength(1); j++)
                {
                    string word = "";
                    for(int k=j;k<puzzle.GetLength(1); k++)
                    {
                        word += puzzle[i,k];
                        if (puzzleAnswers.Contains(word))
                        {
                            Console.WriteLine("Puzzlede kelime bulundu : "+word);
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
                        word += puzzle[k, i];
                        if (puzzleAnswers.Contains(word))
                        {
                            Console.WriteLine("================");
                            Console.WriteLine("Puzzlede kelime bulundu : " + word);
                            Console.WriteLine("Dikeyde bulundu {0}.sutünda {1}.satır ile {2}.satır arasında.",i+1,j+1,k+1);
                        }
                    }
                }
            }
        }
    }
}
