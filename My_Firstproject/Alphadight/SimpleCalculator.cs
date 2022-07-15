using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Alphadight
{
    class SimpleCalculator
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter 1st number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter 2nd number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the operator");
            char op = Convert.ToChar(Console.ReadLine());
             
            switch(op)
            {
                case '+': Console.WriteLine("Adddition="+(num1+num2));
                    break;
                case '-': Console.WriteLine(" subtraction=" + (num1 - num2));
                    break;
                case '*': Console.WriteLine("multiplication=" + (num1 * num2));
                    break;
                case '/': Console.WriteLine("division=" +(num1 / num2));
                    break;
                default: Console.WriteLine("invalid operator");
                    break;




            }
        } 
    }
}
