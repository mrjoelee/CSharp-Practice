using System;

namespace _2D_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (int element in matrix)
            {
                Console.WriteLine($" {element}");
            }

            //nested for loop
            Console.WriteLine("This is our 2D array printed using nested for loop");
            //outer for loop
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                //inner for loop
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    //only shows even numbers from the matrix
                    //if(matrix[i, j] % 2 == 0)
                    //{
                    //    Console.WriteLine($"{matrix[1, 1]}");
                    //}

                    //diagonal 
                    if(i == j)
                    {
                        Console.WriteLine($"{matrix[i, j]}");
                    }
                    Console.WriteLine("");
                }
            }
           
        }
        //static array - only be accessible within this class
        static int[,] matrix =
        {
            // 3 rows with 3 arrays.
            {1,2,3 },
            {4,5,6 },
            {7,8,9 }
        };
    }
}
