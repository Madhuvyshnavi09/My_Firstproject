using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Dowhile
{
    class Number
    {
        static void Main(string[] args)
        {
            char ch;
            do
            {
                Console.WriteLine("enter the 1st number");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the 2 nd number");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("1.Addition\n2.subtraction\n3.multiplication\n4.dividion");
                Console.WriteLine("enter your choice");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Addition=" + (num1 + num2));
                        break;
                    case 2:
                        Console.WriteLine("subtraction=" + (num1 - num2));
                        break;
                    case 3:
                        Console.WriteLine("multiplication=" + (num1 * num2));
                        break;
                    case 4:
                        Console.WriteLine("division=" + (num1 / num2));
                        break;
                    default:
                        Console.WriteLine("invalis choice");
                        break;
                }
                Console.WriteLine("do you want to continue......");
                ch = Convert.ToChar(Console.ReadLine());

            } while (ch == 'y' || ch == 'y');
        }
    }
}










