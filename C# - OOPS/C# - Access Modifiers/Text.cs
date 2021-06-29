using System;
namespace C____Access_Modifiers
{
    // Child Class / Derived Class -> Can have only 1 parent -> inherits from the parent class
    // Child Class -> can access all the properties of parent class, add new additional properties of self
    public class Text : PresentationObject{
        public int FontSize { get; set; }
        public string FontName{ get; set; }
        
        public void AddHyperLink(string url){
        Console.WriteLine("Hyperlink Added for : " + url);
    }
}

}
