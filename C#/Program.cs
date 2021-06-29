using System;
using System.Collections.Generic; // contains List Data Structure
using System.Text; // Contains StringBuilder Class
using System.IO; // Load all classes for Files and Directories

// using the Calculator Class present in Math folder
using C_.Math;

namespace C_
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\n");

            // VARIABLES AND DATA TYPES
            byte n = 2;
            int c = 10;
            float totalPrice = 20.95f;
            char ch = 'a';
            string firstName = "Shantanu";
            bool isWorking = true;
            var newProgram = true;
            const float Pi = 3.14f;  // Cannot change the value of Pi as its declared constant
            // Pi = 1; // Give Error

            Console.WriteLine("Byte: " + n);
            Console.WriteLine("Integer: " + c);
            Console.WriteLine("Float:" + totalPrice);
            Console.WriteLine("Character: " + ch);
            Console.WriteLine("String: " + firstName);
            Console.WriteLine("Boolean: " + isWorking);
            Console.WriteLine("Variable: " + newProgram);
            Console.WriteLine("Constant Float: " + Pi);
            Console.WriteLine("\n");

            // Using Placeholders and supplying arguments in format string
            Console.WriteLine("Min Value of Byte: {0}, Max Value of Byte: {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("Min Value of Float: {0}, Max Value of Float: {1}\n", float.MinValue, float.MaxValue);

            // TYPE CONVERSION
            // byte to integer conversion
            byte b = 1;         // 1 byte
            int i = b;          // int -> 4 bytes => implicit conversion take place by compiler
            Console.WriteLine("Byte to Integer: "+ i);

            // integer to byte -> give error
            // int j = 1;
            // byte k = j;
            // Console.WriteLine(b);

            // Using Cast to convert integer to byte
            int j = 1;
            byte k = (byte) j;
            Console.WriteLine("Integer to Byte: " + k);

            // Casting to convert string to integer
            // var s = "1234";
            // int p = (int) s;        // Give error as String and Integer conversion is not compatible

            // Using Convert class to convert string to integer
            var s = "1234";
            int p = Convert.ToInt32(s);
            Console.WriteLine("String to Integer: " + p);

            // Converting the string to Byte
            // byte m = Convert.ToByte(s);   
            // Gives an exception error as byte doesn't have enough capacity to store 1234

            // EXCEPTION HANDLING
            try
            {
                var st = "1234";
                byte m = Convert.ToByte(st);  // String and Byte are not compatible
                Console.WriteLine("String to Byte: " + m);
            }
            catch (Exception)
            {
                Console.WriteLine("Exception Caught : Number cannot be converted to a byte");
            }

            try
            {
                var str = "true";
                bool bl = Convert.ToBoolean(str);       // String and Bool are compatible
                Console.WriteLine("String to Bool: " + bl + "\n");
            }
            catch (Exception)
            {
                Console.WriteLine("Exception Caught : String cannot be converted to a boolean\n");
            }

            // ARITHMETIC OPERATORS
            var t1 = 3;
            var t2 = 10;
            var t3 = 15;
            Console.WriteLine("Sum = " + (t1+t2));
            Console.WriteLine("Subtraction = " + (t1-t2));
            Console.WriteLine("Multiplication = "+ t1*t2);
            Console.WriteLine("Integer Division = " + t1/t2);
            Console.WriteLine("Float Division = "+ (float)t1/(float)t2 + "\n");

            // OPERATOR PRECEDENCE
            Console.WriteLine("Operator Precedence: " + (t1 + t2 * 4));
            Console.WriteLine("Change Precedence: " + ((t1 + t2) * 4) + "\n");

            // COMPARISON OPERATORS
            Console.WriteLine("Comparison Operator: " + (t1>t2));
            Console.WriteLine("Equality Compare: " + (t1==t2));
            Console.WriteLine("Not Equality Compare: " + (t1!=t2));
            Console.WriteLine("Not Operator: " + (!(t1!=t2)) + "\n");

            // LOGICAL OPERATORS
            Console.WriteLine("Logical AND Operator: " + (t3>t2 && t3>t1));
            Console.WriteLine("Logical AND Operator: " + (t3>t2 && t3==t1));
            Console.WriteLine("Logical OR Operator: " + (t3>t2 || t3==t1) + "\n");

            // Creating object of the Class Person
            var John = new Person();
            // Accessing members of the Class object
            John.FirstName = "John";
            John.LastName = "Mulaney";
            // Accessing the Class Method
            John.Introduce();

            // Accessing the Calculator class from Calculator.cs
            Calculator cal = new Calculator();
            int result = cal.Add(1,2);
            Console.WriteLine("\nCalculator Class Addition Method: " + result + "\n");

            // WriteLine method -> accessible directly from Console class => WriteLine method is Static
            // We dont create new console object to access the WriteLine method

            // ARRAYS
            int[] numbers = new int[3];
            // Array of integers => all elements initialized to 0

            // inserting values into array
            numbers[0] = 1;
            Console.WriteLine("Array of Integers: " + numbers[0] + " " + numbers[1] + " " + numbers[2]);

            // Array of booleans => all elements initialized to False
            var arr = new bool[3];
            arr[0] = true;
            Console.WriteLine("Array of Booleans: " + arr[0] + " " + arr[1] + " " + arr[2]);

            // Array of Strings
            var names = new String[3] {"Jack", "John", "Jim"};
            Console.WriteLine("Array of Strings: " + names[0] + " " + names[1] + " " + names[2] + "\n");

            var array = new [] {3, 4, 5, 6, 7, 8, 9};        // not necessary to write the data type 'int'

            // Length of an Array
            // Length -> static method
            Console.WriteLine("Length of the Array: " + array.Length);

            // IndexOf method of Array -> find position of element in array
            // IndexOf -> 2 parameters -> the name of array to search in and the element to search
            Console.WriteLine("Index of the element 5 in Array is: " + Array.IndexOf(array, 5) + "\n");

            // Clear Method of Array -> elements from starting index to a length cleared : 
            // integer value becomes 0, bool value become False, string becomes null
            // Clear() -> 3 parameters -> name of the array, starting index, number of elements to clear
            Console.WriteLine("Length of Array before Clear Method: " + array.Length);
            Console.WriteLine("Elements of Array before the Clear Method: {0}", string.Join(", ", array));
            Array.Clear(array, 0, 3);
            Console.WriteLine("Length of Array after Clear Method: " + array.Length);
            Console.WriteLine("Elements of Array after the Clear Method: {0}", string.Join(", ", array));

            // Copy Method of an Array
            // Copy() -> 3 parameters -> source, destination, number of elements to copy
            var array_copy = new int[5];
            Console.WriteLine("Array before copying: {0}", string.Join(",", array_copy));
            Array.Copy(array, array_copy, 5);
            Console.WriteLine("Array after copying: {0}", string.Join(",", array_copy));

            // Sort Method of the Array
            var array3 = new int[5] {100, 25, 16, 10000, 1000};
            Console.WriteLine("Array before Sorting: {0}", string.Join(", ", array3));
            Array.Sort(array3);
            Console.WriteLine("Array after Sorting: {0}", string.Join(", ", array3));
            
            // Reverse Method of Array
            Console.WriteLine("Original Array: {0}", string.Join(", ", array3));
            Array.Reverse(array3);
            Console.WriteLine("Reversed Array: {0}", string.Join(", ", array3));

            Console.WriteLine("\n");

            // LISTS
            var l1 = new List<int>() {1, 2, 3, 4, 5};
            Console.WriteLine("Original List: {0}", string.Join(", ", l1));
            l1.Add(10);                                 // In List we can add/remove but not in Arrays
            Console.WriteLine("List after adding element: {0}", string.Join(", ", l1));
            l1.Remove(3);
            Console.WriteLine("List after removing element 3: {0}", string.Join(", ", l1));
            Console.WriteLine("\n");

            var l2 = new List<int>() {5, 10, 2, 6, 5, 9};
            Console.WriteLine("Original List 2: {0}", string.Join(", ", l2));

            // IndexOf Method of the List => static method => tells index of element from beginning of list
            Console.WriteLine("Index of Element 5 in the list: " + l2.IndexOf(5));

            // LastIndexOf Method of the List => tell index of element from the end of the list
            Console.WriteLine("Last Index of Element 5 in the list: " + l2.LastIndexOf(5));

            // Count Method of the List => count number of object in the list
            Console.WriteLine("Number of elements in the list: " + l2.Count);

            // Remove both 5's from the list
            // Cannot do using foreach loop as it doesn't allow to change collections
            for(var ct=0; ct<l2.Count; ct++){
                if(l2[ct] == 5){
                    l2.Remove(l2[ct]);
                }
            }
            Console.WriteLine("List after removing both the 5's : {0}", string.Join(", ", l2));

            // Clearing the List -> remove all elements from the list
            // Clear() Method used
            Console.WriteLine("List before clearing : {0}", string.Join(", ", l2));
            Console.WriteLine("List length before clearing : {0}", l2.Count);
            l2.Clear();
            Console.WriteLine("List after clearing : {0}", string.Join(", ", l2));
            Console.WriteLine("List length after clearing : {0}", l2.Count);

            Console.WriteLine("\n");

            // STRINGS
            var fName = "Roger";
            string lName = "Federer";       // using string keyword
            String fName2 = "Rafael";
            String lName2 = "Nadal";        // using String class

            string fullName = fName + " " + lName;
            string fullName2 = string.Format("{0} {1}", fName2, lName2);
            Console.WriteLine("One of the Greatest: " + fullName + ", " + fullName2);

            // Join an array of strings
            var newName = new string[3] {"Juan", "Martin", "Delpotro"};
            var joinedName = string.Join(".", newName);
            Console.WriteLine("Joining Strings of an array: " + joinedName + "\n");

            // VERBATIM STRING
            // No need of escape characters in Verbatim string
            var verbatimText = @"Roger Federer
            The Greatest of All Time(GOAT)";
            Console.WriteLine("Verbatim String: " + verbatimText + "\n");

            // String Methods
            // Trim Method => deletes white spaces at the beginning or at the end of string
            var pattern = "  * ** *** ****       ";
            Console.WriteLine("Original String: '{0}'", pattern);
            Console.WriteLine("Trimmed String: '{0}'", pattern.Trim());

            // ToUpper Method
            var gt = "Elizabeth Hornswoggle";
            Console.WriteLine("Original String: '{0}'", gt);
            Console.WriteLine("Uppercase String: '{0}'", gt.ToUpper());

            var index = gt.IndexOf(' ');
            // Substring Method
            var f_gt = gt.Substring(0, index);
            var l_gt = gt.Substring(index+1);
            Console.WriteLine("First Name: '{0}'", f_gt);
            Console.WriteLine("Last Name: '{0}'", l_gt);

            // Split Method
            var split = gt.Split(' ');
            var fn_gt = split[0];
            var ln_gt = split[1];
            Console.WriteLine("First Name after Split: '{0}'", fn_gt);
            Console.WriteLine("Last Name after Split: '{0}'", ln_gt);

            // Replace Method
            Console.WriteLine("Name after Replacing: '{0}'", gt.Replace("Elizabeth", "Chandler"));

            if(String.IsNullOrEmpty(null))
                Console.WriteLine("This is a Null String");
            
            if(String.IsNullOrEmpty(""))
                Console.WriteLine("This is an empty string");
            
            if(String.IsNullOrEmpty(" ".Trim()))
                Console.WriteLine("This String has Character but is Invalid");

            if(String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("This contains either Null or WhiteSpace Character");

            // Convert String to Integer
            var n2 = "25";
            var age = Convert.ToInt32(n2);
            Console.WriteLine("String Converted to Integer: "+age);
            var age2 = Convert.ToByte(n2);
            Console.WriteLine("String Converted to Byte: "+age2);

            // Convert float to String with Currency
            var cost = 29.99f;
            Console.WriteLine("Cost of the item: "+ cost.ToString("C"));

            Console.WriteLine("\n");

            // STRINGBUILDER => no searching methods, only manipulation methods
            var builder = new StringBuilder();

            // Append Method
            Console.WriteLine("This is using String Builder: ");
            builder.Append('-', 10);        // Append character 10 times
            builder.AppendLine();           // Add a new line
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);
            Console.WriteLine(builder);

            // Replace Method
            Console.WriteLine("Replacing Character: ");
            builder.Replace('-', '+');
            Console.WriteLine(builder);

            // Remove Method
            Console.WriteLine("Removing Characters from StringBuilder: ");
            builder.Remove(0, 10);      // Remove 10 characters
            Console.WriteLine(builder);

            // Insert Method
            Console.WriteLine("Inserting Characters in StringBuilder: ");
            builder.Insert(0, new string('*', 10));      // Insert 10 characters
            Console.WriteLine(builder);

            // Accessing the Individual Characters of the StringBuilder
            Console.WriteLine("Accessing Individual Characters in StringBuilder: ");
            Console.WriteLine("3rd Character of StringBuilder: " + builder[2]);  // 3rd character at index 2
            Console.WriteLine("18th Character of StringBuilder: " + builder[17]);
            
            Console.WriteLine("\n");

            // ENUM
            // Using Enum by accessing the member of enum
            var method = ShippingMethod.ExpressMail;
            Console.WriteLine("Enum Member: " + method);
            // internally -> enum is an integer -> can cast that into an integer
            Console.WriteLine("Enum Converted to Integer: " + (int)method);

            // can convert an integer into Shipping Method
            var num = 2;
            Console.WriteLine("Integer converted to enum: " + (ShippingMethod)num);

            // Convert the Enum to String
            Console.WriteLine("Enum converted to String: " + method.ToString());

            // Convert String to Enum using Parsing
            var methName = "ExpressMail";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methName);
            Console.WriteLine("String Converted to Enum: " + shippingMethod + "\n");

            // REFERENCE TYPES AND VALUE TYPES
            // Value Type
            var e1 = 10;    // integer -> value type
            var e2 = e1;    // copy of e1 -> the actual value is copied, e1 and e2 become completely independent
            e2++;
            Console.WriteLine(string.Format("a : {0}, b : {1}\n", e1, e2));

            // When copy value type into different variable => copy of that value taken and stored in target variable
            // The value type and its copy becomes completely independent and do not affect each other

            // Reference Type
            var arr1 = new int[3] {1, 2, 3};  // array -> reference type
            var arr2 = arr1;   // copy of arr1 => memory value or reference is copied & not actual value
            arr2[0] = 0;
            Console.WriteLine(string.Format("for arr1 : {0}, for arr2 : {1}\n", arr1[0], arr2[0]));

            // When copy reference type into different variable => both (reference type variable and its copy) 
            //                                                    will be changed if any one of them is changed

            var n1 = 1; // Value Type variable
            Console.WriteLine("Original Value: " + n1);

            Increment(n1); // passed in Increment() method -> copy of variable sent to Increment() method
            Console.WriteLine("Value after Increment method: " + n1); // No change in value seen

            // Both variables (in Main and Increment method) have same name but stored in two diff locations
            // one n1 -> in scope of Main method and other n1 in scope of Increment method
            // n1 in Main method -> no meaning outside Main
            // n1 in Increment method -> no meaning outside Increment method
            // When Increment method called -> new locatn for n1 created, value incremented by 10 and destroyed immediately

            Person2 obj = new Person2() { Age = 20};
            Console.WriteLine("Original Age of Person: " + obj.Age);
            makeOld(obj);
            Console.WriteLine("Age after Incrementing: " + obj.Age + "\n");

            // CONDITIONAL STATEMENTS
            // If statement Ladder
            int hour = 10;
            if(hour>0 && hour<12){
                Console.WriteLine("It is Morning\n");
            } else if(hour>=12 && hour<18){
                Console.WriteLine("It is afternoon\n");
            } else{
                Console.WriteLine("It is evening\n");
            }

            bool isCustomer = true;
            float price;
            if(isCustomer)
                price = 10f;
            else
                price = 20.99f;
            Console.WriteLine(price);

            // Single Line If-else statement => Conditional Operator
            float price2 = isCustomer ? 10f : 20.99f;
            Console.WriteLine(price2 + "\n");

            // Switch Case Statement
            var season = Season.Winter;
            switch(season){
                case Season.Summer:
                    Console.WriteLine("It is the Summer Season\n");
                    break;
                case Season.Winter:
                    Console.WriteLine("Get ready in your warm clothes\n");
                    break;
                case Season.Monsoon:
                    Console.WriteLine("Get ready to take out your umbrella\n");
                    break;
                case Season.Spring:
                    Console.WriteLine("Its time for the Spring Season\n");
                    break;
                default:
                    Console.WriteLine("There is no Season\n");
                    break;
            }

            var season2 = Season.Spring;
            switch(season2){
                // If output of two cases are same
                case Season.Summer:
                case Season.Spring:
                    Console.WriteLine("Its time for the Bonus Season\n");
                    break;
                case Season.Winter:
                    Console.WriteLine("Get ready in your warm clothes\n");
                    break;
                case Season.Monsoon:
                    Console.WriteLine("Get ready to take out your umbrella\n");
                    break;
                default:
                    Console.WriteLine("There is no Season\n");
                    break;
            }

            // ITERATION STATEMENTS
            // For loop
            Console.WriteLine("Numbers from 1 to 10 using for loop:\n");
            for(i=0; i<10; i++){
                Console.WriteLine(i);
            }
            Console.WriteLine("\n");

            Console.WriteLine("Even Numbers from 1 to 10 using for loop:\n");
            // Even numbers between 1 to 10
            for(j=1; j<=10; j++){
                if(j%2==0){
                    Console.WriteLine(j);
                }
            }
            Console.WriteLine("\n");

            Console.WriteLine("Odd Numbers from 10 to 1 using for loop:\n");
            // Reverse the order -> 10 to 1
            for(k=10; k>=1; k--){
                if(k%2!=0){
                    Console.WriteLine(k);
                }
            }
            Console.WriteLine("\n");

            Console.WriteLine("Characters of String using For Loop:\n");
            // Display characters of string using for loop
            string s2 = "Johnny Depp";
            for(c=0; c<s2.Length; c++){
                Console.WriteLine(s2[c]);
            }
            Console.WriteLine("\n");

            // For Each Loop
            // Iterate over String
            Console.WriteLine("Characters of String using For Each Loop:\n");
            foreach(var chr in s2){
                Console.WriteLine(chr);
            }
            Console.WriteLine("\n");

            // Iterate over Arrays
            Console.WriteLine("Elements of an Array using For Each Loop:\n");
            int[] ar = new int[5] {1, 2, 3, 4, 5};
            foreach(var v in ar){
                Console.WriteLine(v);
            }
            Console.WriteLine("\n");

            // While Loop
            Console.WriteLine("Even Numbers from 0 to 10 using While Loop:\n");
            var t = 0;
            while(t<=10){
                if(t%2==0){
                    Console.WriteLine(t);
                }
                t++;
            }
            Console.WriteLine("\n");

            // Take User Input
            Console.WriteLine("Taking user input:\n");
            while(true){
                Console.Write("Type your Name: ");
                var input = Console.ReadLine();

                // Until the input is not empty continue the loop
                // input empty => loop breaks
                if(!String.IsNullOrWhiteSpace(input)){
                    Console.WriteLine("Your Name is: "+input);
                    continue;                                       // continue to the beginning of the loop
                }
                break;

                // If the input string is empty -> break the loop
                //if(String.IsNullOrWhiteSpace(input)){
                    //break;
                //}
                //Console.WriteLine("Your Name is: "+input);
            }
            Console.WriteLine("\n");

            // RANDOM CLASS TO GENERATE RANDOM NUMBERS
            // Generate 10 Random numbers using Random Class
            Console.WriteLine("Generating Random Numbers:\n");
            var random = new Random();
            for(var h = 0; h<10; h++){
                Console.WriteLine(random.Next());
            }
            Console.WriteLine("\n");

            // Limit the Range of Random Numbers generated
            Console.WriteLine("Generating Random Numbers which are less than 20:\n");
            var rand = new Random();
            for(var h = 0; h<10; h++){
                Console.WriteLine(rand.Next(20));
            }
            Console.WriteLine("\n");

            // Generate Random Numbers between a min value and a max value
            Console.WriteLine("Generating Random Numbers between 1 and 50:\n");
            var rand2 = new Random();
            for(var h = 0; h<10; h++){
                Console.WriteLine(rand2.Next(1, 50));
            }
            Console.WriteLine("\n");

            // Generate Random Characters for Random Passwords
            Console.WriteLine("Generating Password using Random Characters:");
            var rand3 = new Random();
            for(var h = 0; h<10; h++){
                Console.Write((char)rand3.Next(97, 122));
            }
            Console.WriteLine("\n");

            // Generating Random String
            Console.WriteLine("Generating Password String using Random Character Array:");
            const int passwordLength = 10;
            var rand4 = new Random();
            var buffer = new char[passwordLength];
            for(var h = 0; h<passwordLength; h++){
                buffer[h] = (char)('a' + rand4.Next(0, 26));
            }
            var password = new string(buffer);
            Console.WriteLine(password);
            Console.WriteLine("\n");

            // DATETIME
            // DateTime -> structure in C# in System namespace -> take arguments (Year, Month, Date)
            var datetime = new DateTime(2015, 01, 26);    // Date -> January 26, 2015
            Console.WriteLine("India's Republic Day is on: " + datetime);

            var now = DateTime.Now;         // Current date time
            Console.WriteLine("The Date - Time right now is: " + now);
            Console.WriteLine("The Hour right now is: " + now.Hour);
            Console.WriteLine("The Minutes right now is: " + now.Minute);
            Console.WriteLine("The Seconds right now is: " + now.Second);

            var today = DateTime.Today;     // Today's Date irrespective of time
            Console.WriteLine("The Date today is: " + today);

            // Datetime => immutable -> cannot change once defined
            // To change datetime -> AddHours, AddMinutes, AddSeconds, etc. to existing object
            var tomorrow = now.AddDays(1);
            Console.WriteLine("The Date-Time tomorrow will be: " + tomorrow);

            var yesterday = now.AddDays(-1);
            Console.WriteLine("The Date-Time yesterday was: " + yesterday);

            // Converting DateTime object to Strings
            Console.WriteLine("Date converted to Long Date: " + now.ToLongDateString());
            Console.WriteLine("Date converted to Short Date: " + now.ToShortDateString());
            Console.WriteLine("Time converted to Long Time: " + now.ToLongTimeString());
            Console.WriteLine("Time converted to Short Time: " + now.ToShortTimeString());
            Console.WriteLine("Date and Time converted to String: " + now.ToString());
            Console.WriteLine("Date converted to String in specified format: " + now.ToString("yyyy-MM-dd"));
            Console.WriteLine("Time converted to String in specified format: " + now.ToString("HH:MM"));

            Console.WriteLine("\n");

            // TIMESPAN -> represents a length of time -> immutable like datetime
            var timespan = new TimeSpan(1, 2, 3);       // 1 Hour 2 Minutes and 3 Seconds
            var timespan1 = new TimeSpan(1, 0, 0);      // 1 Hour 0 Minutes and 0 seconds
            var timespan2 = TimeSpan.FromHours(1);      // 1 Hour
            Console.WriteLine("TimeSpan Duration: " + timespan);
            
            // subtracting two datetime object -> create timespan
            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(20);
            var duration = end - start;
            Console.WriteLine("Duration: " + duration);

            Console.WriteLine("Minutes of timespan: "+ timespan.Minutes);  // return minutes component of timspan object
            Console.WriteLine("Total Minutes of timespan: "+ timespan.TotalMinutes); // Adds the hour's minute also => 60 + 2 = 62 minutes

            // Add and Subtract to timespan
            Console.WriteLine("Add 5 minutes to the timespan: " + timespan.Add(TimeSpan.FromMinutes(5)));
            Console.WriteLine("Subtract 5 minutes from the timespan: " + timespan.Subtract(TimeSpan.FromMinutes(5)));

            // Convert Timespan to String
            Console.WriteLine("Timespan converted to String: " + timespan.ToString());

            // Convert String to Timespan
            Console.WriteLine("String converted to Timespan: " + TimeSpan.Parse("01:02:03"));

            Console.WriteLine("\n");

            // DEALING WITH FILES
            // Copy File -> (source, destination, override)

            /*
            File.Copy(@"C:\Users\Lenovo\Desktop\New folder\Deloitte\Udemy Courses\9 - C# Basics\Screen.jpg", 
                      @"C:\Users\Lenovo\Desktop\New folder\Deloitte\Udemy Courses\9 - C# Basics\myFile.jpg",
                      true);

            var path = @"C:\Users\Lenovo\Desktop\New folder\Deloitte\Udemy Courses\9 - C# Basics\Screen.jpg";

            // Delete File
            File.Delete(path);

            // Check if the File Exists at the Path
            if(File.Exists(path)){
                Console.WriteLine("File was not deleted");
            } else{
                Console.WriteLine("File Deleted Successfully!");
            }
            */

            var path2 = @"C:\Users\Lenovo\Desktop\New folder\Deloitte\Udemy Courses\9 - C# Basics\reading.txt";

            // Read all the text in the txt file
            var content = File.ReadAllText(path2);
            Console.WriteLine("Content of the Text File is : ");
            Console.WriteLine(content);
            Console.WriteLine("\n");

            // Directory
            // Create Directory
            // Directory.CreateDirectory(@"C:\Users\Lenovo\Desktop\New folder\Deloitte\Udemy Courses\9 - C# Basics\Directory Created");

            // Get Files from the Directory -> 2nd argument is the type of files to get
            Console.WriteLine("All Types of Files : ");
            var files = Directory.GetFiles(@"C:\Users\Lenovo\Desktop\New folder\Deloitte", "*.*", SearchOption.AllDirectories);
            foreach(var file in files){
                Console.WriteLine(file);
            }
            Console.WriteLine("\n");

            Console.WriteLine("All PDF Files : ");
            var files2 = Directory.GetFiles(@"C:\Users\Lenovo\Desktop\New folder\Deloitte", "*.pdf", SearchOption.AllDirectories);
            foreach(var file in files2){
                Console.WriteLine(file);
            }
            Console.WriteLine("\n");

            // PATH CLASS
            // Without Path class
            var dotIndex = path2.IndexOf(".");
            var externsion = path2.Substring(dotIndex);

            // With Path Class
            Console.WriteLine("THIS IS USING PATH CLASS: ");
            Console.WriteLine("Extension: " + Path.GetExtension(path2));
            Console.WriteLine("File Name: " + Path.GetFileName(path2));
            Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path2));
            Console.WriteLine("File Name without Extension: " + Path.GetFileNameWithoutExtension(path2));
            Console.WriteLine("\n");
        }

        // ENUMS
        public enum ShippingMethod{
            RegularAirMail = 1,
            RegisteredAirMail = 2,
            ExpressMail = 3
        }

        // CLASS
        public class Person2{
            public int Age;
        }

        // METHODS
        public static void Increment(int n1){
            n1 += 10;
        }
        public static void makeOld(Person2 p){
            p.Age += 10;
        }
    }
}