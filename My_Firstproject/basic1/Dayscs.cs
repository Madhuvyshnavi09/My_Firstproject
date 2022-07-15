using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.basic1
{
    class Dayscs
    {
        static void Main(string[]args)
        {
            int days;
            Console.WriteLine("accept day number and display it eqvivalent day name  in word");


            Console.WriteLine("input day");
            days = Convert.ToInt32(Console.ReadLine()); 

            switch (days)
            {
                case 1:
                    Console.WriteLine("monday");
                    break;
                case 2:
                    Console.WriteLine("tuesday");
                        break;
                case 3:
                    Console.WriteLine("wednesday");
                    break;
                case 4:
                    Console.WriteLine("thursday");
                    break;
                case 5:
                    Console.WriteLine("friday");
                    break;
                case 6:
                    Console.WriteLine("saturday");
                    break;

                case 7:
                    Console.WriteLine("sunday");
                    break;
                default:
                    Console.WriteLine("invalid day number");
                    break;




            }

        }
    }
}
