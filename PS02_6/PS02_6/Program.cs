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
            Console.Write("Enter a number: ");
            string num = Console.ReadLine();

            int sum = 0;

            for (int i = 0; i < num.Length; i++)
            {
                char chnum = num[i];

                if (chnum >= '0' && chnum <= '9')
                {
                    sum += chnum - '0';
                }
            }

            Console.WriteLine("Sum of digits: " + sum);

            Console.ReadKey();
        }
    }
}
