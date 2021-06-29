using System;
namespace C____Access_Modifiers
{
    public class Customer{
        // public interface of Customer Class
        public int Id{ get; set; }
        public string Name{ get; set; }

        public void Promote(){
            var rating = CalculateRating(ExcludeOrders: true);             
            
            // If any changes done in CalculateRating method, only need to change once here
            // That's why CalculateRating not public, otherwise multiple changes need to be made

            if(rating==0)
                Console.WriteLine("Promoted to B Level");
            else
                Console.WriteLine("Promoted to A Level");
        }

        // CalculateRating() -> method is about implementation details of customer class
        // From outside -> no one needs to see the method, 
        // only want to see the customer properties and Promote method
        // Encapsulation -> hide details inside and reveal public details only

        // private -> cannot be accessed by the derived class
        // protected -> can be accessed by the derived class  => private preferred
        private int CalculateRating(bool ExcludeOrders){
            return 0;
        }
    }
}
