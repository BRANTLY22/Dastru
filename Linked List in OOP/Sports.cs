using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List_in_OOP
{
    internal class Sports
    {
        // Store the name of the sport
        public string Name { get; set; }
        // Store the shape type used in the sport
        public string ShapeType { get; set; }
        // Store the role of the sport (Team or Individual)
        public string Role { get; set; }
        // Method to display sport details
        public virtual void DisplayDetails()
        {
            // Print sport name
            Console.WriteLine($"Sport Name  : {Name}");
            // Print shape type
            Console.WriteLine($"Shape Type  : {ShapeType}");
            // Print sport role
            Console.WriteLine($"Sport Role  : {Role}");
        }
    }

    // Child class that inherits from Sports
    internal class PlayerSport : Sports
    {
        // Store the player's name
        public string PlayerName { get; set; }

        // Override method to show player details
        public override void DisplayDetails()
        {
            // Call parent class method
            base.DisplayDetails();

            // Print player name
            Console.WriteLine($"Player Name : {PlayerName}");

            // Print separator line
            Console.WriteLine("**********************************");
        }
    }
}
