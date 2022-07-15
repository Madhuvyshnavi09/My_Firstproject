using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.constrctions
{
    class Second_Use
    {
        public void input()
        {
            Console.WriteLine("input Method");


            this.show();
        }
        public void show()
        {
            Console.WriteLine("shw method");
        }
   
    
    static void Main(string[]args)
        {
            Second_Use t = new Second_Use();
            t.input();
            //t.show();
        }
    
    
    }





}
