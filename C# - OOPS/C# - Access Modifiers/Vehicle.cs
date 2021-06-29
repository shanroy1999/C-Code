using System;

namespace C____Access_Modifiers
{
    // Parent Class
    public class Vehicle{
        private readonly string _registrationNumber;
        
        // Default Constructor
        // public Vehicle(){
        //     Console.WriteLine("Vehicle Class being initiialized");
        // }

        // Parameterized Constructor
        public Vehicle(string registrationNumber){
            _registrationNumber = registrationNumber;
            Console.WriteLine("Vehicle is being initialized {0}", registrationNumber);
        }
    }
}
