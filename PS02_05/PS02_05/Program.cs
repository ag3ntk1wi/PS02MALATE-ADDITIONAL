using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS02_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            string countedChars = "";

            for (int i = 0; i < word.Length; i++)
            {
                char currentChar = word[i];

                if (countedChars.IndexOf(currentChar) != -1)
                {
                    continue;
                }

                int count = 0;
                for (int j = 0; j < word.Length; j++)
                {
                    if (word[j] == currentChar)
                    {
                        count++;
                    }
                }

                countedChars += currentChar;

                Console.WriteLine($"{currentChar}: {count}");
            }
            Console.ReadKey();
        }
    }
}
