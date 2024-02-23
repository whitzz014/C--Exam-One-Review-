using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1Review
{
    class Person
    {
        //Properties ++ Getters & Setters
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        //Constructor
        public Person(string name, string address, string phoneNumber)
        {
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
        }

        // Override the default ToString method to provide a custom string representation of the object.
        public override string ToString()
        {
            //Format the output to be this string 
            return $"Name: {Name}, Address: {Address}, Phone Number: {PhoneNumber}";
        }
    }
}
