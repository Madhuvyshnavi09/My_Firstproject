using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.basic1
{
    class Vowel3
    {

        static void Main(string[] args)
        {
            Console.WriteLine("enter the char");
            char ch = Convert.ToChar(Console.ReadLine());
             
            if (ch =='a'||ch=='e'||ch =='i'||ch=='u'||ch=='o'||ch=='e'||ch=='a')
            {
                Console.WriteLine("vowel");

            }
            else
            {
                Console.WriteLine("consonenet");
            }
        }
    }
}
