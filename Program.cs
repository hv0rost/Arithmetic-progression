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
            double a, b;
            while (true)
            {
                Console.Write("Enter start digit of arithmetic progression: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter end digit of arithmetic progression:");
                b = Convert.ToDouble(Console.ReadLine());

                if (a < b)
                    break;
            }

            ArProgression(a, b);

            Console.ReadKey();

        }
        public static void ArProgression(double start, double end)
        {
            int i = 0;
            while (start < (end - 1.15))
            {
                Console.WriteLine($"a{i++} = {start += 1.15}");
            }
        }
    }
}
