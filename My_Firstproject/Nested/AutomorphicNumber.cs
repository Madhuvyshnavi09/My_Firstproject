using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Nested
{
    class AutomorphicNumber
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter your number");
            int num = Convert.ToInt32(Console.ReadLine());


            if (CheckAutomorphicNumber(num))

            {
                Console.WriteLine("Automorphic Number"); 
            }
           else
            {
                Console.WriteLine("not Automorphic Number");
            }

            Console.ReadLine();


        }
        public static bool CheckAutomorphicNumber(int num)
        {
            int square = num * num;
            while(num>0)
            {
                if(num%10!=square%10)
                {
                    return false;
                }
                num = num / 10;
                square = square / 10;
            }
            return true;
        }
    }
}
