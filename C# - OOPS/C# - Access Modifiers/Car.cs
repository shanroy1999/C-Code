using System;

namespace C____Access_Modifiers
{
    // Derived / Child Class
    public class Car: Vehicle{

        // Until an object of Vehicle type is not created, Car type also will not be created
        // Creation of Vehicle type object first -> necessary for creation of Car Type
        // Important to put the default constructor in Vehicle Class for Car type to be created

        // public Car(){
        //     Console.WriteLine("Car is being initialized");
        // }

        // If Vehicle class doesnt have the default constructor -
        // need to use base keyword to initialize Car class with the parameterized constructor
        public Car(string registrationNumber) : base(registrationNumber){
            Console.WriteLine("Car is being initialized {0}", registrationNumber);
        }
    }
}
