using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> mylist  = Solution();
            foreach (int i in mylist)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
        public static List<int> Solution()
        {
            var myFnList = new List<int>();
            for (int i = 100; i <= 170; i++)
            {
                if(i%2 == 0)
                {
                    myFnList.Add(i);
                }
            }
            return myFnList;
        }
    }
}
//Lists



//Write a method that returns a list of even integer numbers between 100 and 170 (inclusive).



//Your myFnList should contain the following numbers: