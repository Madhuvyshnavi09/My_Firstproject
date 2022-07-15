using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Assiginement.cs
{
    class Task15
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("enter your age");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter your friend age");
            n2 = int.Parse(Console.ReadLine());
            if (n1 == n2)
            {
                Console.WriteLine("print hi friend");


                Console.WriteLine("print hi friend");
            }

            {
                Console.WriteLine("if our friend age is greater than your age");
                n1 = int.Parse(Console.ReadLine());
                if (n1 > n2) 
                {
                    Console.WriteLine("print good morning");
                }

                Console.WriteLine("if your friend age is less than your age");
                n1 = int.Parse(Console.ReadLine());

                if(n1<n2)
                {

                    Console.WriteLine("print how are you");
                }
                Console.ReadLine();


            }

        }
    }
}


            
        
    

