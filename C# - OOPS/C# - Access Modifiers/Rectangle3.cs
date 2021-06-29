using System;

namespace C____Access_Modifiers
{
    public class Rectangle3 : Shape3{
        // If abstract method not overriden -> Error
        public override void Draw()
        {
            Console.WriteLine("Drawing a Rectangle by overriding Abstract Class");
        }
    }
}
