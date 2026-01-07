using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordeniza_Act1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array of Sport objects
            Sports[] sports = new Sports[4];

            // Initialize objects 
            sports[0] = new Sports
            {
                Name = "Basketball",
                ShapeType = "Round Ball",
                Role = "Team Sport"
            };

            sports[1] = new Sports
            {
                Name = "Soccer",
                ShapeType = "Round Ball",
                Role = "Team Sport"
            };

            sports[2] = new Sports
            {
                Name = "Volleyball",
                ShapeType = "Round Ball",
                Role = "Team Sport"
            };

            sports[3] = new Sports
            {
                Name = "Tennis",
                ShapeType = "Round Ball",
                Role = "Individual or Doubles"
            };
            // Display section
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("HERE ARE THE SPORTS YOU LIKE\n");
            Console.ResetColor();

            foreach (Sports sport in sports)
            {
                sport.DisplayDetails();
            }

            Console.ReadKey();
        }
    }

}
