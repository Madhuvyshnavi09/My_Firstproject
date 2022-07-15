using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.basic1
{
    class RCST
    {

        static void Main(string[]args)
        {
            Console.WriteLine("enter length");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("enter breadth");
            int breadth = int.Parse(Console.ReadLine());
            Console.WriteLine("enter radius");
            int radius =int.Parse(Console.ReadLine());
            {
                Console.WriteLine("enter height");
                int height = int.Parse(Console.ReadLine());
                 Console.WriteLine("1.Areaofrectangle /n2.areaofsquare/n3.areaofcircle/n4 areaoftriangle"); 
                  Console.WriteLine("enter your choice");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("areaofreactangle" + (length + breadth));
                        break;
                    case 2:
                        Console.WriteLine("areaofsquare" + (length + length));
                        break;
                    case 3:
                        Console.WriteLine("areaofcircle" + (3.14 * radius * radius));
                        break;
                    case 4:
                        Console.WriteLine("areaoftriangle" + (1 / 2 * length * height));
                        break;

                    default:
                        Console.WriteLine("invalid choice");
                        break;




                }
                    
                    
            }


                
        }
    }
}
