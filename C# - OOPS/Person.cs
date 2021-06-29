using System;

namespace C____OOPS
{
    // Defining a Class
    public class Person{
        public String Name;  // member / field / attribute of the class

        public void Introduce(string to){                           // method / function of the class
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        // Parse method -> declared Static -> no need to create Person object first
        public static Person Parse(string str){
            var person = new Person();
            person.Name = str;
            return person;                  // return a person object
        }
    }
}
