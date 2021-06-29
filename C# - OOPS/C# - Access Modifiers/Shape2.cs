using System;
namespace C____Access_Modifiers
{
    // Shape2 class only has properties
    // doesnt have any behaviour / methods
    // data is here but behaviour is in Canvas
    public class Shape2{
        public int Width { get; set; }
        public int Height { get;  set; }
        public Position Position { get; set; }

        // Create a new method -> Draw => declared virtual method for allowing method overriding
        public virtual void Draw(){
        }
    }

    public class Circle : Shape2{
        // override the draw method inherited from Shape2 Class specifically for Circle Shape
        // Polymorphism -> many forms of Draw() function depending on objects
        public override void Draw()
        {
            // Code specific to Circle class
            Console.WriteLine("Draw a Circle");

             // base.Draw();        // draw() method of base class has no implementation
        }
    }

    public class Rectangle : Shape2{
        // override Draw() method of Shape2 Class for Rectangle Shape
        public override void Draw(){
            // Code Specific to Rectangle Class
            Console.WriteLine("Draw a Rectangle");
        }
    }

    public class Triangle : Shape2{
        public override void Draw(){
            Console.WriteLine("Draw a Triangle");
        }
    }
}
