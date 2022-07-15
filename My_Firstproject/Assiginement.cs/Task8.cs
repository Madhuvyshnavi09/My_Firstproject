using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Assiginement.cs
{
    class Task8
    {
        static void Main(string[]args)
        {
            int a;
            Console.WriteLine("please enter the age of the person");
            a = int.Parse(Console.ReadLine());


            if (a > 13 && a < 20)
                Console.WriteLine("he/she is a teenager");
            else
            {
                Console.WriteLine("he/she is not teenager");
            }
        }
    }
}
