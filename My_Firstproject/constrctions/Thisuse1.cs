using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.constrctions
{
    class Thisuse1
    {
        int x = 10;

        public void input(int x)
        {
           this. x = x;

        }
        public void  show()
        {
            Console.WriteLine("x-" + x);
        }


        static void Main(string[]args)
        {
            Thisuse1 t = new Thisuse1();
            t.input(450);
            t.show();

        }
    }
}
