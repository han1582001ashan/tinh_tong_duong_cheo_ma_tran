using System;
using System.Globalization;
namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type size: ");
            int size = Int32.Parse(Console.ReadLine());

            int[,] array = new int[size, size];
            int sum= 0;
           
            for (int row = 0; row < array.GetLength(0); row++)
            {

                for (int col = 0; col < array.GetLength(1); col++)
                {
                    array[row, col] = Int32.Parse(Console.ReadLine());

                }
            }
            Console.WriteLine("Your Maxtrix: ");
            for (int row = 0; row < array.GetLength(0); row++)
            {
                Console.Write("\n");
                for (int col = 0; col < array.GetLength(1); col++)
                {
                    Console.Write(array[row, col] + " ");
                    if (col == row)
                    {
                        sum= sum+ array[row, col];
                    }
                }
                

            }
             Console.WriteLine("\nSum value is: " + sum);
            

        }
    }
}