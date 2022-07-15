using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.operators
{
    class Integer
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter the city name");

            string city = Console.ReadLine();

            Console.WriteLine("City name=" + city);

            Console.WriteLine("enter the number");

            num = int.Parse(Console.ReadLine());
            Console.WriteLine(num + "  " + (num + 2));

            float per = float.Parse(Console.ReadLine());
            Console.WriteLine("per=" + per);

            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1);

            char ch = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(ch);





        }

    }
}
