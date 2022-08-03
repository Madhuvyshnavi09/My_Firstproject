using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Encapsulation
{
    class Class5
    {
        static void Main(string[]args)
        {
            for (char i='D'; i>='A';i--)
                {
                for(Char j='A';j<=i;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
