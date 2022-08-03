using System;
using System.Collections.Generic;
using System.Text;

namespace My_Firstproject.Inheritence
{
    class Address
    {
        public int pincode;
        public string city;

        public Address(int pincode, string city)
        {
            this.pincode=pincode;
            this.city = city;


        }
        public void ShowAddress()
        {
            Console.WriteLine(" " + pincode + " " + city);
        }
        class person
        {
            int id;
            string name;
            Address adr;



            person(int id,string  name, Address adr)
            {
                Console.WriteLine(id + " "+name);
                adr.ShowAddress();
            }
            static void Main(string[]args)
            {
                Address a = new Address(524, "atp");
                person p;
                p = new person(1, "meenu",a);
                p.Displayperson();

               

            }

            private void Displayperson()
            {
                throw new NotImplementedException();
            }
        }
        

    }
}
