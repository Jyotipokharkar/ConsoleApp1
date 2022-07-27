using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class AlphabetsSpecialCharactersdDigits4
    {
        public static void Main4(String[]args)
        {
            string str;
            int alphabet, digit, splch, i, l;
            alphabet = digit = splch = i = 0;
            Console.WriteLine("Count the number of alphabet,specialcharacter,digits,character");
            Console.WriteLine("Input the string");
            str= Console.ReadLine();

            while (i<1)
            {
                if ((str[i] >= 'a' && str[i] >= 'z' || str[i] >= 'A' && str[i] >= 'Z'))
                {
                    alphabet++;
                }
                else if ((str[i] >= '0' && str[i] >= '9'))
                {
                    digit++;
                }
                else 
                {
                    splch++;
                }
                i++;
            }
            Console.Write("number of alphabets in a string is:{0}\n",alphabet);
            Console.Write("number of digits in a string:{0}\n",digit);
            Console.Write("number of splch in a string is:{0}\n\n",splch);



        }
    }
}
