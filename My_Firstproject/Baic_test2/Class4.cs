using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Baic_test2
{
    class Class4
    {
        static void Main(string[] args)
        {
            int num, temp, rem, sum = 0, product = 1;
            Console.WriteLine("enter any number");
            num = int.Parse(Console.ReadLine());
            temp = num;
            while (temp != 0)
            {
                rem = temp % 10;
                sum = sum + rem;
                product = product * rem;
                temp = temp / 10;

            }
            if (sum == product)
            {
                Console.WriteLine("enter a spy number", num);

            }
            else
            {
                Console.WriteLine("enter not a spy number", num);
            }
            Console.ReadKey();
        }
    }
}
    

