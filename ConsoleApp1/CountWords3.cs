using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class CountWords3
    {
        public static void Main3(string[]args)
        {
            int a = 0, myword = 1;
            string str = "India is my country";

           while(a<=str.Length-1)
            {
                if (str[a]==' '||str[a]=='\n'||str[a]=='\t')
                {
                    myword++;
                }
                a++;
            }
            Console.Write("numbers of words in a string={0}",myword);

        }
    }
}
