using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Alphadight
{
    class TernaryEvenOdd
    { 
        //wap to finf out number is odd or even("only using Ternary operator){
        static void Main(string[]args)
        {
            //wap to finf out number is odd or even("only using Ternary operator)

            int n1 = 2;
            Console.WriteLine("enter number :");
            n1 = int.Parse(Console.ReadLine());


            string number = (n1 % 2 == 0) ? " this is even number" : "this is odd number";
            Console.WriteLine("ans ="+ number);
            Console.ReadLine();

        }
    }
}
