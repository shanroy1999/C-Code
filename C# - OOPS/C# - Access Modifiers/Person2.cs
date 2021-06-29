using System;

namespace C____Access_Modifiers
{
    public class Person2{

        // Automatically use the getter and setter property
        public DateTime Birthdate{
            get;
            set;
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
