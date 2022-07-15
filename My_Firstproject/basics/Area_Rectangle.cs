using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.basics
{
    class Area_Rectangle
    {

        static void Main(string[] args)
    {
            double baseofrectangle,heightofrectangle,area,perimeter;

            Console.WriteLine("Insert the BASE of the rectangle");
            baseofrectangle = double.Parse(Console.ReadLine());

            Console.WriteLine("Insert the Hieghtoftherectangle");
            heightofrectangle = double.Parse(Console.ReadLine());

            area = baseofrectangle = heightofrectangle;

            perimeter = 2 * baseofrectangle + 2 * heightofrectangle;



            Console.WriteLine("Input-> Base" + baseofrectangle);

            Console.WriteLine("Input-> height:" + heightofrectangle);

            Console.WriteLine("--------");
            Console.WriteLine("RESULT:");

            Console.WriteLine("areaoftherectngle:" + area);


            Console.WriteLine("perimeter of the rectangle:" + perimeter);

            Console.ReadKey();

            

          
        }
                
    }
}
