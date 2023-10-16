using System;
using System.Formats.Asn1;

namespace HelloWorld
{
    class Program
    {
        // constants as fields ---> Constants are immutable
        const double Pi = 3.1415;
        const int weeks = 52, months = 12;
        const int days = 365;
        const string myBirthDay = "09091992";

        static void Main(string[] args)
        {
            int num1 = 13;
            int num2 = 5;
            int sum = num1 + num2;

            double d1 = 3.5;
            double d2 = 1.337;
            double sumD = d1 / d2;

            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + sum);
            Console.WriteLine(d1 + " devided by " + num2 + " is " + sumD);

            string stringForFloat = "0.85"; // datatype should be float
            string stringForInt = "12345"; // datatype should be int
            float myFloat = float.Parse(stringForFloat);
            int myInteger = Int32.Parse(stringForInt);
            Console.WriteLine("Int = {0}, Float = {1}", myInteger, myFloat);

            //This is the escape characters
            string s1 = "This is a \"string\" with \n a slash / and  \\ a colon: ";
            Console.WriteLine(s1);

            string myName;
            Console.Write("Please enter your name and press enter : ");
            myName = Console.ReadLine();
            string myNameUpperCase = String.Format("Upper Case : {0}", myName.ToUpper());
            string myNameLowerCase = String.Format("Lower Case : {0}", myName.ToLower());
            string myNameTrim = String.Format("Trim: {0}", myName.Trim());
            string myNameSubstring = String.Format("Substring: {0}", myName.Substring(0, 5));
            Console.WriteLine(myNameUpperCase);
            Console.WriteLine(myNameLowerCase);
            Console.WriteLine(myNameTrim);
            Console.WriteLine(myNameSubstring);

            /* search function
            Console.Write("Enter the string here: ");
            //Read first input string.
            string input = myName;

            Console.WriteLine("Enter a Character to Search:  ");
            //Read the character input to search.
            char searchInput = Console.ReadLine()[0];

            //Gets the Index of the character from the string.
            int searchIndex = input.IndexOf(searchInput);
            
            //Prints the Index as a search result on console.
            Console.WriteLine("Index of character {0} in the string {1} is {2}", searchInput, input, searchIndex);
            */

            //Concatinate
            Console.Write("Please enter your lastName: ");
            string mylastName = Console.ReadLine();

            string myFullName = string.Concat(myName, " ", mylastName);
            Console.WriteLine("Your full name is : {0}", myFullName);

            byte myByte = 25;
            Console.WriteLine(myByte);
            sbyte mySbyte = -15;
            Console.WriteLine(mySbyte);
            int myInt = -12341;
            Console.WriteLine(myInt);
            uint myUnit = 123091;
            Console.WriteLine(myUnit);
            short myShort = -32768;
            Console.WriteLine(myShort);
            float myFloat2 = -31.1289f;
            Console.WriteLine(myFloat2);
            Double myDouble = 22.22;
            Console.WriteLine(myDouble);
            char myChar = 'A';
            Console.WriteLine(myChar);
            bool myBool = true;
            Console.WriteLine(myBool);
            string myString = "I control text";
            Console.WriteLine(myString);
            string numText = "15";
            Console.WriteLine(numText);
            int myNumFromText = int.Parse(numText);

            //Cannot reassign with the different data type
            //number = null ---> Number cannot be null and cannot assign null to var
            var number = 0; // int
            var text = "Text"; // string
            var isTrue = false; // boolean
            Console.WriteLine(number + text + isTrue);


            Console.WriteLine("My birth day is always going to be {0}", myBirthDay);

            WriteSomething();
            WriteSomethingSpecific("This is my specific thing");

            int myAddResult = Add(1, 3);
            Console.WriteLine(myAddResult);
            Console.WriteLine(Add(1, 3));

        }
        // acess modifier (static) return type method name (parameter1, parameter2)
        public static void WriteSomething() // public is the access modifier ---> to called method with in static this have to be static as well.
        {
            Console.WriteLine("I am called from a method");

        }

        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }

        // void is return empty value ---> here we don't use void
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static void GreetFriend()
        {
            string friendName = "Frank";
            Console.WriteLine(friendName);
            friendName = Console.ReadLine();
            Console.WriteLine(friendName);
        }


    }
}

