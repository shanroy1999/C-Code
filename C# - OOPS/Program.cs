using System;
namespace C____OOPS
{
    partial class Program
    {
        static void Main(string[] args)
        {
            // var person = new Person();  => Not required as Parse method is Static
            
            Console.WriteLine("\nStatic Methods of a Class: ");
            // static member -> only accessible from class and not an object
            var p = Person.Parse("Jack");
            p.Introduce("John");
            Console.WriteLine("\n");

            Console.WriteLine("Constructors: ");
            // Create the Customer Object
            var customer = new Customer(1, "John");     // Defining object using 2 parameter constructor
            Console.WriteLine("Id of the customer: " + customer.Id);
            Console.WriteLine("Name of the customer: " + customer.Name);
            Console.WriteLine("\n");

            Console.WriteLine("Adding Orders to the Orders List for the Customer: ");
            customer.Orders.Add(new Order());           // Adding Order to the Orders list
            customer.Orders.Add(new Order());
            Console.WriteLine("Number of Customer Orders after Adding Order to List: "+customer.Orders.Count);

            customer.Promote();             // Reinitializes the Orders List and makes it empty -> data lost
            // Read Only Modifier -> prevents from reinitializing the Orders List
            Console.WriteLine("Number of Customer Orders after using the Promote method(with ReadOnly Modifier): "+customer.Orders.Count);
            // Need to Use ReadOnly Modifier -> situation where the field should be initialized only once
            Console.WriteLine("\n");

            Console.WriteLine("Method Overloading: ");
            try{
                var point = new Point(10, 20);
                Console.WriteLine("Initial Point Location: ({0} {1})", point.X, point.Y);

                // Move using the Point object overload
                point.Move(new Point(40, 60));
                Console.WriteLine("Second Point Location: ({0} {1})", point.X, point.Y);

                // Move using the integer overload method
                point.Move(100, 200);
                Console.WriteLine("Third Point Location: ({0} {1})", point.X, point.Y);

                // Checking null value -> Exception Handled
                point.Move(null);
                Console.WriteLine("Point Location: ({0} {1})", point.X, point.Y);
                Console.WriteLine("\n");
            }
            catch (Exception ){
                Console.WriteLine("An unexpected error Occured\n");
            }

            // Sum of n numbers
            Console.WriteLine("Using Variable number of parameters/input for an array input:");
            Calculator calculator = new Calculator();
            Console.WriteLine("Sum of the numbers with 4 array inputs: " + calculator.Add(1, 2, 10, 15));
            Console.WriteLine("Sum of the numbers with 6 array inputs: " + calculator.Add(1, 2, 10, 15, 50, 40));
            Console.WriteLine("\n");
        }
    }
}