using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.basic1


{
    class Add
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter 1st number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the 2nd number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("1.addition\n2.subtraction\n3.multiplication\n4division");
            Console.WriteLine("enter your choice");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1: Console.WriteLine("addition" + (num1 + num2));
                    break;
                case 2: Console.WriteLine("subtraction" + (num1 - num2));
                    break;
                case 3: Console.WriteLine("multiplication" + (num1 * num2));
                    break;
                case 4: Console.WriteLine("division" + (num1 / num2));
                    break;
                default: Console.WriteLine("invalid choice");
                    break;


            }


        }
    }
}
