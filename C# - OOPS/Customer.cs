using System.Collections.Generic;

namespace C____OOPS
{
    // Constructors
    public partial class Customer{
        public int Id;          // field of the class
                                // Id -> integer -> default value = 0
        public string Name;     // Name -> String -> default value = null

        // Initialize the Orders field straight away without use of default cosntructor
        public readonly List<Order> Orders = new List<Order>();        // Create a List of Orders

        // readonly modifier -> make sure that the list can be modified only once -> provide protection

        // Whenever a class has a list of objects as the member, always initialize list in default constructor
        // If list is not initialized -> it will give an error as list is of reference type -> null reference
        // List -> should be initialized in default constructor, should not be null

        /* Get Rid of the Default Constructor
        // Default Constructor with no paramter
        // Always need to make sure that default constructor goes first so that Orders is iniitialized
        public Customer(){
            Orders = new List<Order>() {};             // Initialize the Orders list
        }
        */

        // Declare Overloaded Constructor with 1 parameter
        public Customer(int id){                            // First call the orders list of Default constructor using 'this()'
            this.Id = id;                   // after orders has been initialized, id will be initialized
        }

        // Overloaded Constructor with 2 parameters
        public Customer(int id, string name)
        :this(id){
            this.Name = name;               // after initializing id and orders, name will be initialized
        }
        // this(id) takes the 'id' parameter to jump to second constructor with 1 parameter 
        // where it will further go to default constructor

        // Since we created two custom constructors -> compiler no longer create the default cosntructor
        // Need to define Default constructor now

        public void Promote(){
            //Orders = new List<Order>();  // Reinitialize the Orders list -> Orders list become empty
            // Will get compiler error as we have set the Orders list to readonly and can be initialized only once
        }
    }
}
