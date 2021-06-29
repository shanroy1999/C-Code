using System;
namespace C____OOPS
{
    partial class Program
    {
        public class Point{
            public int X;
            public int Y;

            // Initilize the point
            public Point(int x, int y){
                this.X = x;
                this.Y = y;
            }

            // Move point to a different location
            // Change the value of the fields
            public void Move(int x, int y){
                this.X = x;
                this.Y = y;
            }

            // Overload the Move method by using Point object parameter
            /*
            public void Move(Point newLocation){
                this.X = newLocation.X;                 // Change the value of the fields
                this.Y = newLocation.Y;
            }
            // We are using same concept in both the Move methods -> not a best practice
            */
            public void Move(Point newLocation){

                // prevent the program from getting into a invalid state
                if (newLocation == null)
                    throw new ArgumentNullException("newLocation");
                Move(newLocation.X, newLocation.Y);
            }
            // Problem -> if null passed -> error -> null reference exception

        }
    }
}