using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07___Arrays
{
    public class Exercise
    {
        public static void GetOdd(int[] Array)
        {
            // TODO
            foreach (int k in Array)
            {
                if (k % 2 != 0)
                    Console.WriteLine(k);
                else
                    continue;
            }
        }

        public static void GetEven(int[] Array)
        {
            foreach (int k in Array)
            {
                if (k % 2 == 0)
                    Console.WriteLine(k);
                else
                    continue;
            }
        }

        public static void Run()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            GetOdd(array);
            GetEven(array);

        }
    }
}
