using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class AreaOfCircle14
    {
        public static void Main(String[]args)
        {
            int r,area;
            float pi = 3.14f;
            Console.WriteLine("Enter the radius of the circle");
            r = Convert.ToInt32(Console.ReadLine());

            area = 3.14 * r * r;
            Console.WriteLine(area);

        }
    }
}
