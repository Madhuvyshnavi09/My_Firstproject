using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Looping
{
    class Odd_Number
    {
        static void Main(string[]args)
        {
            //print odd numbers betwwen 1 to 10//
            int sum = 0;
            for(int i = 1; i<10;i++)
            {
                if(i%2==1)
                    {
                    sum = sum +i;


                }
                Console.WriteLine(sum);
            }
        }
    }
}
