using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Assiginement.cs
{
    class Task7
    {

        static void Main(string[]args)
        {
            int n;
            Console.WriteLine("enter a number");
            n = int.Parse(Console.ReadLine());
            if(n>=0 && n<=9)
            {
                Console.WriteLine("single digit number",n);


            }
            if (n > 10 && n < 99)
            {
                Console.WriteLine(" double digit number", n);
            }
            Console.ReadLine();
        }
    }
}
