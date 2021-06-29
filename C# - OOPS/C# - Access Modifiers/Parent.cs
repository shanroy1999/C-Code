using System;
namespace C____Access_Modifiers
{
    // Parent / Super Class -> properties inherited by the child class
    public partial class PresentationObject{
        public int Width { get; set;}
        public int Height { get; set;}

        public void Copy(){
            Console.WriteLine("Object Copied to Clipboard");
        }

        public void Duplicate(){
            Console.WriteLine("Object Duplicated to Clipboard");
        }

    }
}
