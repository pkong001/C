﻿

using System.Drawing;

namespace ClassesAndObjects
{
    internal class Car2
    {
        // private Member variables/fields
        // access modifier private
        private string _name; // private field typically used for storing data.
        private int _hp;
        private string _color;
        private int _MaxSpeedWriteOnly;

        public int MaxSpeed { get; set; }

        public int MaxSpeedReadOnly { get; } = 10;

        public int MaxSpeedWriteOnly
        {
            set
            {
                _MaxSpeedWriteOnly = value;
            }
        }



        // the public property
        public string Name
        {
            get { return _name; } // get accessor
            set
            {
                if (value == "")
                {
                    _name = "Hello World Default Name";
                }
                else
                {
                }
                _name = value;
            } // set accessor
        }



        // Default Constructor
        public Car2()
        {
            _name = "Car2";
            _hp = 5;
            _color = "red";
            Drive();
        }
        // Partial Specification Constructor
        public Car2(string name, int hp = 0)
        {
            _name = name;
            Console.WriteLine(name + " was created");
            _hp = hp;
            _color = "red";
            Drive();
        }
        // Full Specification Constructor
        public Car2(string name, int hp, string color)
        {
            _name = name;
            Console.WriteLine(name + " was created");
            _hp = hp;
            _color = color;
            Drive();
        }



        // Member Method
        public void Drive()
        {
            Console.WriteLine(_name + " is driving");
        }

        // Member Methods
        public void Stop()
        {
            Console.WriteLine(_name + " stopped!");
        }

        public void Details()
        {
            Console.WriteLine("The " + _color + " car " + _name
                + " has " + _hp + " hp");
        }
    }
}
