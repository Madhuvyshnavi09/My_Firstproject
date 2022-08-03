using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Encapsulation
{
    class Swaping
    {
        public void swap(ref int num1,ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;

        }
        static  void Main(string[]args)
        {
            Swaping s = new Swaping();
            Console.WriteLine("enter 1st number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter 2nd number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(num1 + " " + num2);
            Console.WriteLine(".........................");
            s.swap(ref num1, ref num2);//pass  by reference
            Console.WriteLine(num1 + " " + num2);
        }
    }
}
