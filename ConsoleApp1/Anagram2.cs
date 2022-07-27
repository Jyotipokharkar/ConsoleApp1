using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Anagram2
    {
        static void Main2(String[] args)
        {
            Console.WriteLine("enter the string first") ;
            string str1 = Console.ReadLine();

            Console.WriteLine("enter the string second");
            string str2 = Console.ReadLine();

            String s = str1.ToLower();
            string s1 = str2.ToLower();
            if (s.Length == s1.Length)
            {
                char[] ch1 = s.ToCharArray(); 
                char[] ch2 = s.ToCharArray();

                //sorting logic
                Array.Sort(ch1);
                Array.Sort(ch2);
                string st = new string(ch1);
                string st2 = new string(ch1);
                if (st == st2)
                {
                    Console.WriteLine("anagram");
                }
                else 
                {
                    Console.WriteLine("not anagram");
                }
            }
        }
    }
}
