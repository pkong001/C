using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare and initualize a 2-dimensional Array
            int[,] array2D = new int[,]
            {
                {11, 12, 13 },
                {21, 22, 23 },
                {31, 32, 33 }
            };

            //We access the Value 23
            //Note, that Indexes start with 0
            Console.WriteLine(array2D[1, 2]);


            //3-Dimensions are more complex, but the Conzept is the same
            string[,,] array3D = new string[,,] 
            {
                {
                    {"000", "001", "002" },
                    {"010", "011", "012" },
                    {"020", "021", "022" }
                },
                {
                    {"100", "101", "102" },
                    {"110", "111", "112" },
                    {"120", "121", "122" }
                },
                {
                    {"200", "201", "202" },
                    {"210", "211", "212" },
                    {"220", "221", "222" }
                },
                {
                    {"Hi", "I", "am" },
                    {"also", "part", "of" },
                    {"the", "3-dimensional", "array" }
                }

            };

            //We access the Value "201"
            Console.WriteLine(array3D[2, 0, 1]);

            //Hi
            Console.WriteLine(array3D[3, 0, 0]);

            //Will give us the Dimension of the corresponding Array
            int amountDimensions = array3D.Rank;
            Console.WriteLine("The Dimension is {0}", amountDimensions);

            //Multi-dimensional Arrays can also be created that way:
            string[,] arr2D = { { "00", "01" } };

            Console.WriteLine(arr2D[0, 0]);

            //To keep the Console open
            Console.Read();

            //The iterate through each one
            foreach (int item in array2D)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("This is our 2D array printed using nested for loop");
            // outer for loop // 0 = row
            for (int i = 0; i < array2D.GetLength(0) ; i++)
            {
                // inner for loop // 1 = column
                for (int j = 0; j < array2D.GetLength(1) ; j++) 
                {
                    //print only odd number
                    if (array2D[i,j]%2 != 0)
                    {
                        Console.Write(array2D[i, j] + " ");
                    }
                    else
                    {
                        continue;
                    }
                    
                }
            }


            Console.ReadKey();
            Console.WriteLine();


            // *** THIS WILL ONLY WORK WITH THE ARRAY THAT HAVE SAME NUMBERS OF COLUMNS AND ROWS
            Console.WriteLine("This is the other way");
            for (int i = 0, j = 2; i < array2D.GetLength(0) ; i++ , j--)
            {
                Console.WriteLine(array2D[i, j]);
            }

            Console.WriteLine();
            Console.ReadKey();

            string[,] _board =
            {
                {"X", "", "X" },
                {"O", "", "O" },
                {"O", "", "" }
            };

            Console.WriteLine(TicTacToe.Checker(_board));

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
