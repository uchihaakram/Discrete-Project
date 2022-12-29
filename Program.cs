using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a n1");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a n2");
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("the prime numbers are:");
            double i, j;


            for (i = n1; i <= n2; i++)
            {
                double count = 0;
                for (j = 1; j <= i; j++)
                {

                    if (i % j == 0)
                    { count++; }
                }

                if (count <= 2)
                { Console.WriteLine(i); }


            }
            Console.ReadKey();
        }
    }
}
