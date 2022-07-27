using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class SumOfTwoNumbers8
    {
        public static int Sum(int num1,int num2)
        {
            int total;
            total = num1 + num2;
            return total;
        }
        public static void Main8(String[]args)
        {
            Console.WriteLine("calculate the sum of two numbers");
            Console.WriteLine("enter the 1st number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the 2nd number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n enter the sum of two numbers is:{0}", Sum(num1, num2));
                
                

        }
    }
}
