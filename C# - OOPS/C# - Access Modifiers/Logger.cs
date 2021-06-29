using System;

namespace C____Access_Modifiers
{
    // Create class Logger -> accessed by both the Migrator and Installer as it is used in common to both.
    // Both Migrator and Installer -> Have Composition relation with Logger Class
    public class Logger{
        public void Log(string message){
            Console.WriteLine("Message from Logger: " + message);
        }
    }
}
