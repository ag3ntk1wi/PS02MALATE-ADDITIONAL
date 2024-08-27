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
            Console.Write("Enter Letter: ");
            char letter = Convert.ToChar(Console.ReadLine());

            if (letter == 'a' || letter == 'A' || letter == 'e' || letter == 'E' || letter == 'i' || letter == 'I' || letter == 'o' || letter == 'O' || letter == 'u' || letter == 'U')
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonant");
            }

            Console.ReadKey();
        }
    }
}
