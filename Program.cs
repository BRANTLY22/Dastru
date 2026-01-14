using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Ordeniza_Two_Dimensional_Array
{
    internal class Program
    {
        //Name: Brantly Ordeniza
        //Section: IT401A
        //Problem: Two-Dimensional Array (Initialize elements for your two-dimensional array.
        //You will be the one to decide what data type you will assign to your array.
        //Your output must be table-like.Make sure your table has a row and column header.)
        //Array dimensions: 4 rows x 3 columns (4x3)
        static void Main(string[] args)
        {
            //Initialize a 2D array with 4 rows and 3 columns containing sports names
            string[,] sports = new string[,]
            {
                     {"Basketball", "Cricket", "\tHockey"},
                     {"Volleyball", "Handball", "Lacrosse"},
                     {"Swimming", "Diving", "\tGymnastics"},
                     {"Boxing", "\tSnowboarding", "Golf"}
            };
            //Print the header row with column labels
            Console.WriteLine("\tColumn 1\t\tColumn 2\t\tColumn 3");

            //Loop through each row of the array
            for (int row = 0; row < sports.GetLength(0); row++)
            {
                //Print the row number at the start of each row
                Console.Write($"Row {row + 1}\t");

                //Loop through each column in the current row
                for (int col = 0; col < sports.GetLength(1); col++)
                {
                    //Print each sport name with tabs for spacing
                    Console.Write(sports[row, col] + "\t\t");
                }
                //Move to the next line after printing all columns in the row
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
    
