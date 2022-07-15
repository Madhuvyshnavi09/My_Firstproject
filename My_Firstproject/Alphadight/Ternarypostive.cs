using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Alphadight
{
    class Ternarypostive
    {
        static void Main(string[]args)
        {
            //console.writeline("check the number is postivie or negative or zero using ternary operator")
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine()); ;
            //string result=num>0?"the number is postive":"the number is negative";
            string result = num > 0 ? "postive" : num < 0 ? "negative" : "zero";
            Console.WriteLine(result);











































































        }
    }
}
