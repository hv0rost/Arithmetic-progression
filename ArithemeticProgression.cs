using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic_progression
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, i = 0;
            while(true)
            {
                Console.Write("Enter start digit of arithmetic progression: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter end digit of arithmetic progression:");
                b = Convert.ToDouble(Console.ReadLine());

                if (a < b)
                    break;
            }

            while(a < (b - 1.15 ))
            {
                Console.WriteLine($"a{i++} = {a += 1.15}");
            }

            Console.ReadKey();

        }
    }
}
