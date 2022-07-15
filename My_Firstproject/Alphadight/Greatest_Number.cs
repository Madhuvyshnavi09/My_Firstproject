using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Alphadight
{
    class Greatest_Number
    {
        static void Main(string[]args)
        {
            //console.writeline("check greatest number is using nested if else statement");

            Console.WriteLine("enter 1st number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter 2nd number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter 3rd number");
            int num3 = int.Parse(Console.ReadLine());
              if(num1>num2)
            {
                if(num1>num3)
                {
                    Console.WriteLine("the larger number is=" + num1);
                }
                  else if (num2>num3)
                {
                    if(num2>num1)
                    {
                        Console.WriteLine("the largest number is=" + num2);

                    }
                    else
                    {
                        Console.WriteLine("the largest number is=" + num3);

                    }
                      
                } 
            }


        }
    }
}
