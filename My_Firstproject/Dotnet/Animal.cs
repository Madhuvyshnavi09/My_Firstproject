using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Dotnet
{
    class Animal
    {
        public string name;
        public int legs;
        public string food_type;

        static void Main(string[]args)
        {
            Animal one = new Animal();
            one.name = "lion";
            one.legs = 4;
            one.food_type = "meat";
            Console.WriteLine(one.name + " " + one.legs + " " + one.food_type);

            Animal two = new Animal();
            two.name = "frog";
            two.legs = 4;
            two.food_type = "insects";
            Console.WriteLine(two.name + " " + two.legs + " " + two.food_type);

        }

    }
}
