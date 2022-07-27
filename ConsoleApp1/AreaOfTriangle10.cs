using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class AreaOfTriangle10
    {
        public static void Main10(String[]args)
        {
            Console.WriteLine("enter base:");
           int Base = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter height");
            int height = Convert.ToInt32(Console.ReadLine());

             int area = (Base*height)/2;

            Console.WriteLine("area of triangle:"+area);
        }
    }
}
