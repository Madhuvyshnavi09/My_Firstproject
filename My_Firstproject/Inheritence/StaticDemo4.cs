using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Inheritence
{
    class StaticDemo4
    {
        static int x = 10;
        static StaticDemo4()
        {
            Console.WriteLine("Mystatic");
        }
        static void Main(string[]args)
        {
            Console.WriteLine(x);
        }
    }
}
