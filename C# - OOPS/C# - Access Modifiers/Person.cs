using System;

namespace C____Access_Modifiers
{
    public class Person{

        // Private Access Modifier -> cannot access _birthdate field outside Person Class
        private DateTime _birthdate;

        // Getter and Setter Functions
        // For accessing _birthdate outside the Person Class:
        public void SetBirthDate(DateTime bdate){
            this._birthdate = bdate;                         // Set _birthdate to the value passed in the method
        }

        public DateTime GetBirthDate(){
            return _birthdate;                      // Get the _birthdate value
        }
    }
}
