using System;
using System.Collections;
using System.Collections.Generic;

namespace C____Access_Modifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            // p._birthdate = new DateTime(1992, 11, 24); 
            // => Give an Error as _birthdate is Private member of Person Class
            Console.WriteLine("\n");

            Console.WriteLine("Private Access Modifier -> Getter and Setter Properties:");
            p.SetBirthDate(new DateTime(1992, 11, 24)); // Assign 24-Nov-1992 to _birthdate
            Console.WriteLine("Birthdate using Getter: " + p.GetBirthDate());        // Returns the _birthdate
            Console.WriteLine("\n");

            Console.WriteLine("Automatically-implemented Getter and Setter properties using the Compiler:");
            Person2 p2 = new Person2();
            p2.Birthdate = new DateTime(1992, 11, 24);
            Console.WriteLine("Age Calculated: " + p2.Age);
            Console.WriteLine("\n");

            Console.WriteLine("Use Constructor if the Setter property is Private for the Class:");
            Person3 p3 = new Person3(new DateTime(1992, 11, 24));
            Console.WriteLine("Age Calculated: " + p3.Age);
            Console.WriteLine("\n");

            Console.WriteLine("Using Indexer: ");
            var cookie = new HTTPCookie();
            cookie["name"] = "Jack";                // Using the "name" as indexer
            Console.WriteLine("Name Indexer of the Cookie: " + cookie["name"]);
            Console.WriteLine("\n");

            // Using Inheritance Concept (IS-A Relationship)
            Console.WriteLine("Inheritence Concept: ");
            var text = new Text();

            // Accessing Parent Class(PresentationObject) Object using Child Class(Text)
            text.Width = 100;
            Console.WriteLine("Width: "+text.Width);

            // Accessing Parent Class(PresentationObject) Method using Child Class(Text)
            text.Copy();

            // Accessing own Child Class(Text) Method
            text.AddHyperLink("https://www.google.com");
            Console.WriteLine("\n");

            // Association between the classes using Composition (HAS-A relationship)
            Console.WriteLine("Composition Concept: ");

            // DBMigrator and Installer -> both in association with the Logger Class -> Composition Relation
            var dbMigrator = new DBMigrator(new Logger());
            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigrator.Migrate();
            installer.Install();
            Console.WriteLine("\n");

            // Console.WriteLine("Constructor of Base Class always Executed First: ");
            // var car = new Car();            // Will give 2 messages => both of Vehicle and Car Classes

            Console.WriteLine("Using 'base' keyword when Parent Class do not have default constructor : ");
            var car = new Car("MH201499");
            Console.WriteLine("\n");

            // Upcasting and Downcasting of Objects

            // Upcasting
            Console.WriteLine("Upcasting: ");
            Figure fig = new Figure();
            Shape shape = fig;              // implicitly converts fig (child class) to shape (parent class)
            fig.Width = 200;                // child class -> able to access all properties of parent class
            Console.WriteLine("Original Figure Width: "+fig.Width);

            shape.Width = 100;          // Both fig and shape reference to the same object in memory
            Console.WriteLine("Figure Width after assigning Shape object Witdth: "+fig.Width);

            // Downcasting
            Shape shape1 = new Figure();        // shape1 object -> converted to type Figure
            // shape1 -> get limited view, will not be able to define properties that are in Figure object

            // need to downcast the shape1 object
            Figure fig1 = (Figure) shape1;          // now fig1 -> able to access all properties of Figure class
            Console.WriteLine("\n");

            // Boxing and Unboxing
            // Boxing -> Value type converted to object reference
            // Unboxing -> Object reference converted to Value type

            var list = new ArrayList();

            list.Add(1);                    // list.Add -> takes in objects as input -> can input anything
            // integer -> value type in Add() method of list -> boxing takes place

            list.Add("Roger");              // String -> reference type -> Boxing doesn't take place
            list.Add(DateTime.Today);       // Datetime -> structure -> Boxing take place

            // Problem -> Type Safety not there -> Each element in the list has different data type
            // If we try to get 2nd element (String) in list and cast it to -> InvalidCastException
            
            // Using Generic List -> Boxing will not happen in case of Generic List
            var list2 = new List<int>();
            list2.Add(1);                   // Generic List -> Add can only take integer type -> type safety is there

            // Polymorphism
            var shapes = new List<Shape2>();

            // shapes.Add(new Shape { Width = 100, Height = 100, Type = ShapeType.Circle});
            // shapes.Add(new Shape { Width = 100, Height = 300, Type = ShapeType.Rectangle});

            Console.WriteLine("Implementing Polymorphism: ");
            shapes.Add(new Circle());           // first element -> circle -> draw method of circle called
            shapes.Add(new Rectangle());        // second element -> rectangle -> draw method of rectangle
            shapes.Add(new Triangle());         // third element -> triangle -> draw method of triangle called

            var canvas = new Canvas();
            canvas.DrawShapes(shapes);
            Console.WriteLine("\n");

            Console.WriteLine("Implementing Abstract Class: ");
            var rect1 = new Rectangle3();
            rect1.Draw();
            rect1.Copy();
            rect1.Select();
            Console.WriteLine("\n");

            var circle1 = new Circle3();
            circle1.Draw();
            rect1.Copy();
            rect1.Select();
            Console.WriteLine("\n");

        
        }
    }

    // Derived class from Customer Class
    // CalculateRating Method will not be visible to the derived class as its declared private in Customer
    public class Gold : Customer{
        public void OfferVoucher(){
            Customer customer = new Customer();
            // customer.CalculateRating(); -> Error while accessing
        }
    }
}
