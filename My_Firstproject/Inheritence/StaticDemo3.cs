using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Inheritence
{
    class StaticDemo3
    {
        static StaticDemo3()
        {
            Console.WriteLine("HIIII");
        }
        StaticDemo3()
        {
            Console.WriteLine("Default");
        }
        static void Main(string[]args)
        {
            StaticDemo3 d = new StaticDemo3();
            
        }
    }
}
