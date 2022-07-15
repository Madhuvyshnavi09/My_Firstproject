using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Looping
{
    class MagicDemo
    {
        static void Main(string[]args)
        {
            int magic_number = 56;
            while(true)
            {
                Console.WriteLine("enter the number");
                int num = int.Parse(Console.ReadLine());
                if (num > magic_number)
                {
                    Console.WriteLine("number is greater than magic pls try again...");
                    continue;

                }
                else if (num < magic_number)
                {
                    Console.WriteLine("Number is lesstha magic number pls try again...");
                    continue;
                }
                else
                {
                    Console.WriteLine("you guess correct.......");
                    break;
                }


                
            }
        }
    }
}
