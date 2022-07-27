using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class AreaOfRectangle9
    {
        public static void Main9(String[] args)
        {
            int length, breadth, area;
            Console.WriteLine("enter  length of rectangle");
            length = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("enter  breadth of rectangle");
            breadth = Convert.ToInt32(Console.ReadLine());

            area = length * breadth;

            Console.WriteLine("area of rectangle"+area);

        }
    }
}
