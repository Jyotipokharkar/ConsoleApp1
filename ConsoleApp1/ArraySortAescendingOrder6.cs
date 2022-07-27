using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ArraySortAescendingOrder6
    {
        public static void Main6(String[]args)
        {
            int[] a = new int[] { 1,7,9,5,3,2,4,8,6};
            Array.Sort(a);
            Array.Reverse(a);
            for (int i=1;i<=a.Length;i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
