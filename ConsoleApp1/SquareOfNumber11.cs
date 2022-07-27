using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class SquareOfNumber11
    {
        public static void Main11()
        {
           
            Console.WriteLine("enter a number");
           int  Number = Convert.ToInt32(Console.ReadLine());

           double sqr = Math.Pow(Number,2);
                Console.WriteLine("Square of{0} is:{1}",Number,sqr);

        }
    }
}
