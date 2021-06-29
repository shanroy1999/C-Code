using System;
namespace C____Access_Modifiers
{
    // If there is an abstract method, the class must also be abstract
    public abstract class Shape3{
        public int Width { get ; set; }
        public int Height { get; set; }

        // create Abstract method which must be overriden, implemented by derived classes
        public abstract void Draw();

        public void Copy(){
            Console.WriteLine("Abstract Class Defined Method : Shape has been copied");
        }

        public void Select(){
            Console.WriteLine("Abstract Class Defined Method : Shape has been selected");
        }
    }
}
