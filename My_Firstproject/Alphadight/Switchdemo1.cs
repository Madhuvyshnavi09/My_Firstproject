﻿using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Alphadight
{
    class Switchdemo1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string str = Console.ReadLine();
            switch (str)
            {
                case "happy":
                    Console.WriteLine("Happy");
                    break;
                case "new":
                    Console.WriteLine("New");
                    break;
                case "year":
                    Console.WriteLine("year");
                    break;
                default:
                    Console.WriteLine("Welcome");
                    break;


            }
        }
             
    }
}
