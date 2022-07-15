using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.DoWhile

{
    class Loop_days

    {
        static void Main(string[] args)
        {
            char ch;
            do
            {
                Console.WriteLine("enter 1st day");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("enter 2nd day");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("1.monday\n2.tuesday\n3.wednesday\n4.thursday\n5.friday\n6.saturday\n7.sunday");
                Console.WriteLine("enter your choice");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("monday");
                        break;
                    case 2:
                        Console.WriteLine("tuesday");
                        break;
                    case 3:
                        Console.WriteLine("wednesday");
                        break;
                    case 4:
                        Console.WriteLine("thursday");
                        break;
                    case 5:
                        Console.WriteLine("friday");
                        break;
                    case 6:
                        Console.WriteLine("saturday");
                        break;

                    case 7:
                        Console.WriteLine("sunday");
                        break;
                    default:
                        Console.WriteLine("invalid option");
                        break;
                }
                Console.WriteLine("do you want to select............");
                ch = Convert.ToChar(Console.ReadLine());
            } while (ch == 'y' || ch == 'y');
        }
    }
}       











                
            
        
    