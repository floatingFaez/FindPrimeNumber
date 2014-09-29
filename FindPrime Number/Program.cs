using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindPrime_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x, y, n = 20;
            //for (x = 2; x <= n; x++)
            //{
            //    for (y = 2; y <= x; y++)
            //    {
            //        if (x % y == 0)
            //            break;
            //    }
            //    if (x == y)
            //        Console.WriteLine(x);
            //}

            Console.Write("Enter an iteger Number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int i;
            for (i = 2; i <=number; i++)
            {
                if (number % i == 0)
                    break;
            }

            if (number == i)
                Console.WriteLine("This is the prime number");
            else
                Console.WriteLine("This is not a prime number");

            Console.ReadKey();
        }
    }
}
