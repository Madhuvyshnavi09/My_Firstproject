using System;
using System.Collections.Generic;
using System.Text;
//public:- public is a access modifiy access to everywhere

namespace My_Firstproject.oops
{

    class Student
    {
        //Assign the voice and create the object nside the main method

        public int id;                      //<---  innstance variable
        public string name;                //<----instance variable
        public double marks;               //<---- instance variable


        static void Main(string[] args)   //<--Main method
        {
            Student stud1 = new Student();//<---object creation//stud1:new student creating the object1
            stud1.id = 101;                //<--- local variable
            stud1.name = "madhu";          //<---local variabl
            stud1.marks = 72;              //<--- local variable


            Console.WriteLine(stud1.id + " " + stud1.name + " " + stud1.marks); //<---- Display result

        }

    }
}

