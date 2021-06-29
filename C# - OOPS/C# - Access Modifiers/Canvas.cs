using System;
using System.Collections.Generic;

namespace C____Access_Modifiers
{
    // Problem with this code -> every time new shape is added in ShapeType enum -> need to create new case
    // Class that contains this method -> needs to be compiled again
    // Tight Coupling is there
    // If there are 10 different types of shapes -> DrawShapes() method will be really long and complex
    
    public class Canvas{
        public void DrawShapes(List<Shape2> shapes){
            foreach (var shape in shapes){              // Iterate over the list of shapes

                // Polymorphism
                shape.Draw();                   // at runtime, shape object may be circle or rectangle
                                                // if circle -> draw method of circle called
                                                // if rectangle -> draw method of rectangle called

                // switch(shape.Type){
                //     case ShapeType.Circle:
                //         break;

                //     case ShapeType.Rectangle:
                //         break;

                // case ShapeType.Triangle:
                //     Console.WriteLine("Draw a Triangle");
                //     break;
            }
        }
    }
}
