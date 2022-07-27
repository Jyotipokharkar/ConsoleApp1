using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class UniqueElementsInArray7
    {
        public static void Main7(String[]args)
        {
            int[] array = { 4,5,6,7,5,8,9,6};

            int n = array.Length;
            Console.WriteLine("unique array elements:");
            for (int i=0;i<n;i++)
            {
                bool isDuplicate = false;
                for (int j = 0; j <i; j++)
                {
                    if (array[i]==array[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (!isDuplicate)
                {
                    Console.WriteLine(array[i]);
                }

            }
            Console.ReadLine();
        }
    }
}
