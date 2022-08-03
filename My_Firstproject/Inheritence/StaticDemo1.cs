using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Inheritence
{
    class Staticdemo1
    {
        static int x = 0;
         
        static Staticdemo1()
        {
            x++;
            Console.WriteLine(x);
        }
        void Display()
        {
            Console.WriteLine(x);
        }
        static int Addition()
        {
            return 2 + 5;
        }
        static void Main(string[]args)
        {
            Console.WriteLine(x);

            Staticdemo1 d = new Staticdemo1();
            Console.WriteLine(Staticdemo1.x);


            int ans=Staticdemo1.Addition();
            Console.WriteLine("Addition" +ans);


        }
    }
}
