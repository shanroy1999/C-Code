using System.Collections.Generic;
namespace C____Access_Modifiers
{
    public class HTTPCookie{

        // Field to store key value pairs -> use Dictionary data type
        private readonly Dictionary<string, string> _dictionary;    // Only modified once

        // Constructor to initialize dictionary
        public HTTPCookie(){
            _dictionary = new Dictionary<string, string>();
        }

        // Declare the indexer -> exactly like Property
        public string this[string key]{
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }
    }
}
