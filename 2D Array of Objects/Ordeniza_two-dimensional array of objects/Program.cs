using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordeniza_two_dimensional_array_of_objects
{
    internal class Program
    {
        //Name: Brantly Ordeniza
        //Course: Dastru
        //2D Array of Objects
        static void Main(string[] args)
        {
            // Create a 2D array of Sports objects (2 rows, 2 columns)
            Sports[,] sports = new Sports[2, 2];

            // Initialize objects
            sports[0, 0] = new Sports
            {
                Name = "Basketball",
                ShapeType = "Round Ball",
                Role = "Team Sport"
            };

            sports[0, 1] = new Sports
            {
                Name = "Soccer",
                ShapeType = "Round Ball",
                Role = "Team Sport"
            };

            sports[1, 0] = new Sports
            {
                Name = "Tennis",
                ShapeType = "Round Ball",
                Role = "Individual / Doubles"
            };

            sports[1, 1] = new Sports
            {
                Name = "Badminton",
                ShapeType = "Shuttlecock",
                Role = "Individual / Doubles"
            };

            Console.WriteLine("HERE ARE THE SPORTS YOU LIKE\n");

            // Loop through the 2D array using nested loops
            for (int i = 0; i < sports.GetLength(0); i++)
            {
                for (int j = 0; j < sports.GetLength(1); j++)
                {
                    sports[i, j].DisplayDetails();
                }
            }

            Console.ReadKey();
        }
    }
}
