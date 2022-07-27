using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class SimpleInterest12
    {
        static void Main(string[]args)
        {
            int p, r, t, si;
            Console.WriteLine("enter principal amount");
            p = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter rate amount");
            r = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter time amount");
            t = Convert.ToInt32(Console.ReadLine());

            si = p * r * t/100;

            Console.WriteLine("si="+si);
        }
    }
}
