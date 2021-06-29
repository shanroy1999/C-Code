using System;
namespace C____Access_Modifiers
{
    public class Person3{

        // Create Constructor for the Person Class to set the Birthdate and no longer change it further
        public Person3(DateTime birthdate){
            Birthdate = birthdate;
        }

        // Birthdate Prperty of the person set only once and cannot be changed
        public DateTime Birthdate{ 
            get;
            private set;
        }

        // Declare Age Property - Calculate Age from the birthdate
        public int Age{
            // Only Declare Get method and not the Set Method
            // Doesnt make sense to set the age of the person
            // Age -> should be calculated based on Birthdate
            get{
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;

                return years;
            }
        }

    }
}
