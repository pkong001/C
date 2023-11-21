//Advancetage of Loops
/*
 * For loop
 * While Loop
 * Do while loop
 * do each loop
*/

//For loop


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section5Plus
{
    class Program
    {
        static void Main(string[] args)
        {
            //Check condition then start running
            for(int counter = 0; counter <= 3; counter++)
            {
                Console.WriteLine(counter);
            }
            Console.WriteLine();

            //Run once then check condition before continue on running
            int _counter = 0;
            do
            {
                Console.WriteLine(_counter);
                _counter += 1;
                Thread.Sleep(1000);
            } while (_counter <= 3);

            _counter = 0;
            while(_counter <= 3)
            {
                Console.WriteLine(_counter);
                _counter += 1;
            }

            //Challenge???
            /*
             * To pass the tests, your loop should skip all divisible by 3 values and stops running when i = 10.
            */
            int i = -10;

            while (true)
            {

                // TODO
                if (i == 11)
                {
                    Console.WriteLine(" FINAL BREAK REACHED! This should not happen!");
                    break;
                }
                if (i % 3 == 0)
                {
                    i++;
                    continue;
                }
                if (i == 10)
                {
                    break;
                }

                Console.WriteLine(i++);
            }


            //Challenge???
            string input = "0";
            int count = 0;
            int total = 0;
            int currentNumber = 0;

            while (input != "-1")
            {
                Console.WriteLine("Last number was {0}", currentNumber);
                Console.WriteLine("Please enter the next score");
                Console.WriteLine("Current amount of entries {0}", count);
                Console.WriteLine("Please enter -1 once you are ready to calculate the average");

                input = Console.ReadLine();
                if (input.Equals("-1"))
                {
                    Console.WriteLine("--------------------------------------------");
                    double average = (double)total / (double)count;
                    Console.WriteLine("The average score of your students is {0}", average);
                }
                if (int.TryParse(input, out currentNumber) && currentNumber > 0 && currentNumber < 21)
                {
                    total += currentNumber;
                }
                else
                {
                    if (!(input.Equals("-1")))
                    {
                        Console.WriteLine("Please enter a value between 1 and 20!");
                    }
                    continue;
                }

                count++;

            }
            Console.ReadLine();
        }



    }
}