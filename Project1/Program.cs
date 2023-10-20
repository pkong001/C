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

            string _friend1 = "Nut";
            string _friend2 = "Mob";
            string _friend3 = "Tian";

            GreetFriend(_friend1,_friend2,_friend3);

            Console.WriteLine("Pleaes enter a number!");
            string userInput = Console.ReadLine();
            int _num1 = 5;
            int _num2 = 0;
            int result;

                try
            {
                result = _num1 / _num2;
            }
            catch(Exception)
            {
                Console.WriteLine("Cannot devided by zero");
            }
                try
                {
                    int userInputAsInt = int.Parse(userInput);
                }
                catch(FormatException)
                {
                    Console.WriteLine("Format exception, please enter the correct type next time.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Overflow exception, the number was too long or too short for int32");
                }
                catch(ArgumentNullException)
                {
                    Console.WriteLine("The value was empty");
                }
                catch (Exception)
                {
                    Console.WriteLine("Something went wrong!");
                }
                finally
                {
                    Console.WriteLine("Finally we reached the end of the line");
                }

            _num1 = -5;
            _num2 = 3;
            int _num3;

            // unary operators
            _num3 = -num1;
            Console.WriteLine("num3 is {0}", _num3);

            bool _isSunny = true;
            Console.WriteLine("is it sunny? {0}", !_isSunny);

            // increment operators
            int _num = 0;
            _num1++;
            Console.WriteLine("num is {0}", _num);
            Console.WriteLine("num is {0}", _num++);
            // pre-increment
            Console.WriteLine("num is {0}", ++_num);


            // decrement operators
            _num1--;
            Console.WriteLine("num is {0}", _num);
            Console.WriteLine("num is {0}", _num--);
            // pre-decrement
            Console.WriteLine("num is {0}", --_num);

            //normal operator
            int _result;
            _result = _num1 + _num2;
            Console.WriteLine("result of _num1 + _num2 is {0}", _result);

            //Relational and type operators
            bool _isLower;
            _isLower = _num1 < _num2;
            Console.WriteLine("result of num1 < num2 is {0}", _isLower);

            // equality operator
            bool _isEqual;
            _isEqual = _num1 == _num2;
            Console.WriteLine("result of _num1 == _num2 is {0}", _isEqual);

            _isEqual = _num1 != _num2;
            Console.WriteLine("result of _num1 != _num2 is {0}", _isEqual);

            //conditional operators
            // AND
            bool _isLowerAndSunny = _isLower && _isSunny;
            Console.WriteLine("result of _isLowerAndSunny {0}", _isLowerAndSunny);
            // OR
            bool _isLowerOrSunny = _isLower || _isSunny;
            Console.WriteLine("result of _isLowerOrSunny {0}", _isLowerOrSunny);

            //Conditioning
            Console.WriteLine("What's the temperature like?");
            string _temperaturestring = Console.ReadLine();
            int _temperature = int.Parse(_temperaturestring);

            if (_temperature == 10)
            {
                Console.WriteLine("It's 10 degree");
            }
            else if (_temperature < 10)
            {
                Console.WriteLine("The temperature is very low");
            }
            else
            {
                Console.WriteLine("I just want to say no!!!");
            }
            if (_temperature > 10)
            {
                Console.WriteLine("It's more than 10 degree");
            }

            string numberAsString = "128";
            int parsedValue;
            bool success = int.TryParse(numberAsString, out parsedValue);
            // The retunred boolen is true when parsing was successful

            if (success)
                Console.WriteLine("Parsing successful - number is " + parsedValue);
            else
                Console.WriteLine("parsing failed");
                

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

        public static void GreetFriend(string _friendName1, string _friendName2, string _friendName3)
        {
            Console.WriteLine("Hi {0}, my friend!", _friendName1);
            Console.WriteLine("Hi {0}, my friend!", _friendName2);
            Console.WriteLine("Hi {0}, my friend!", _friendName3);
        }

    }
}

