using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Encapsulation
{
    class Student2
    {
        int id;
        string name;
        Double per;
        public Student2()//default or no parametrize
        {
            //*id=800;
            //name="meenu";
            //per=72;

            Console.WriteLine("Default");

        }

        public Student2(int sid, string sname, double smarks)
        {
            id = sid;
            name = sname;
            per = smarks;
        }
        Student s = new Student();
        //Console.WriteLine(s.id +" "+s.name+" "+s.per);
        Student s1 = new Student();
        //Console.WriteLine(s1.id+" "+s1.name+" "+s1.per);


        Student s2 = new Student();
        //Consolr.WriteLine(s2.id+" "+s2.name+""+s2.per);



    } 
 }

        

    

