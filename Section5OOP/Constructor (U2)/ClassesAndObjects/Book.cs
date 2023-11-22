using System;

namespace Coding.Exercise
{
    public class Book
    {
        private string _title;
        private int _pages;

        public string Title
        {
            get { return _title; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    _title = "Unknown";
                else
                    _title = value;
            }
        }

        public int Pages
        {
            get { return _pages; }
            set
            {
                if (value < 1)
                    _pages = 1;
                else
                    _pages = value;
            }
        }
    }
}
