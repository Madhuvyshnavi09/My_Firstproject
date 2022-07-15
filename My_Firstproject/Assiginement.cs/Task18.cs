using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Assiginement.cs
{
    class Task18
    {
        static void Main(string[]args)
        {
            int n1, n2;
            Console.WriteLine(" enter younger age");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter older age");
            n2 = int.Parse(Console.ReadLine());

            if(n1==2)
            {
                Console.WriteLine("print siblings");
            }

            Console.WriteLine("only childern print no siblings");
            n1 = int.Parse(Console.ReadLine());


            if(n1>n2)
            {
                Console.WriteLine("print no siblings");

            }
            Console.WriteLine("enter oldest child  if only  one has younger sibling");
                n2 = int.Parse(Console.ReadLine());

            if(n1<n2)
            {
                Console.WriteLine("print good morning");

            }

            Console.WriteLine("youngest child if only have one older sibling");
            n2 = int.Parse(Console.ReadLine());

            if(n1<=n2)
            {
                Console.WriteLine("print hi");
            }

            Console.WriteLine("enter middel child if the person has both younger and older sibling");
            n1 = int.Parse(Console.ReadLine());
            if(n1==n2)
            {
                Console.WriteLine("good friends");

            }
                 Console.ReadLine();


        }
    }
}
