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
            Console.Write("Enter numbers separated by spaces: ");
            string num = Console.ReadLine();

            string[] strNums = num.Split(' ');

            int sum = 0;

            foreach (string numStr in strNums)
            {

                if (int.TryParse(numStr, out int number))
                {
                    sum += number;
                }
                else
                {
                    Console.WriteLine($"'{numStr}' is not a valid number.");
                }
            }

            Console.WriteLine("Sum of numbers: " + sum);

            Console.ReadKey();
        }
    }
}
