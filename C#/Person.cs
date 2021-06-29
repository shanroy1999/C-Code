using System;

namespace C_
{
    // Creating a new Class
    public class Person{
        // Creating variables of the class
        public string FirstName;
        public string LastName;

        // Creating method of the Class
        public void Introduce(){
            Console.WriteLine("Hi, my name is "+ FirstName + " " + LastName);
        }
    }
}