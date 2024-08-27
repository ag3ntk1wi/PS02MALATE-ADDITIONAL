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
            string revWord = "";
            Console.Write("Enter Word: ");
            string word = Console.ReadLine();

            for (int i = word.Length-1; i >= 0; i--)
            {
                revWord += word[i];
            }

            Console.WriteLine(revWord);

            if (revWord == word)
            {
                Console.WriteLine("This Word is a Palindrome.");
            }
            else
            {
                Console.WriteLine("This Word is not a Palindrome.");
            }

            Console.ReadKey();
        }
    }
}
