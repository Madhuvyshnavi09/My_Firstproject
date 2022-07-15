using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Alphadight
{
    class OddEvenSwitch
    {
        static void Main(string[]args)
        {
            int num;
            //reading a number from user
            Console.WriteLine("enter any number to check even or odd:");
            num = Convert.ToInt32(Console.ReadLine());
               
            switch (num%2)
            {
                //if n%2==0
                case 0:
                    Console.WriteLine(num + "is even number");
                    break;
                case 1:
                    Console.WriteLine(num + " is odd number");
                    break;

            }
                
        }
    }
}
