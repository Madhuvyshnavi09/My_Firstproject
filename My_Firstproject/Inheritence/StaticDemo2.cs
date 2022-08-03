using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Inheritence
{
    class StaticDemo2
    {
        int x = 10;
        static int y = 56;
         
        void show()
        {
            Console.WriteLine(x + " " + y);
        }
        static void Mymethod()
        {
            StaticDemo2 s = new StaticDemo2();
            Console.WriteLine(s.x + " " + y);

            //int s.x + y;\\
        }
        static void Main(string[] args)
        {
            StaticDemo2 d = new StaticDemo2();
            d.show();

            StaticDemo2.Mymethod();
            //Console.WriteLine(x);
        }
            
    }
}
