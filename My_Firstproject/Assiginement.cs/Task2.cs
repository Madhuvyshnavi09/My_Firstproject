using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Assiginemen.cs
{
    class Task2
    {
        static void Main(string[]args)
        {
            int n;
            Console.WriteLine("enter input value");
            n = int.Parse(Console.ReadLine());


            switch(n%2)
            {


                case 0:
                    Console.WriteLine(n + " is even number");
                    break;

                case 1:
                    Console.WriteLine(n + " is odd number");
                    break;

            }
            Console.ReadLine();
                
        }
    }
}
