using System;

namespace C____Access_Modifiers
{
    public class Circle3 : Shape3{
        // Overriding the inherited abstract draw() method from the abstract class Shape3
        // If abstract method not overriden -> Error
        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle by overriding Abstract Class");
        }
    }
}
