using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List_in_OOP
{
    internal class SportLinkedList
    {
        // LinkedList to store PlayerSport objects
        private LinkedList<PlayerSport> sports = new LinkedList<PlayerSport>();

        // Method to add a new sport to the list
        public void Insert()
        {
            // Create a new PlayerSport object and get input from user
            PlayerSport sport = new PlayerSport
            {
                Name = UserInput.GetString("Enter sport name: "),
                ShapeType = UserInput.GetString("Enter shape type: "),
                Role = UserInput.GetString("Enter role (Team/Individual): "),
                PlayerName = UserInput.GetString("Enter player name: ")
            };
            // Add sport to the end of the linked list
            sports.AddLast(sport);

            // Show success message
            Console.WriteLine("Sport added successfully!\n");
        }
        // Method to remove a sport from the list
        public void Remove()
        {
            // Check if the list is empty
            if (sports.Count == 0)
            {
                Console.WriteLine("List is empty.\n");
                return;
            }
            // Get sport name to remove
            string name = UserInput.GetString("Enter sport name to remove: ");

            // Start from the first node
            var node = sports.First;

            // Loop through the linked list
            while (node != null)
            {
                // Check if sport name matches
                if (node.Value.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    // Remove the matched node
                    sports.Remove(node);

                    // Show success message
                    Console.WriteLine("Sport removed successfully.\n");
                    return;
                }
                // Move to the next node
                node = node.Next;
            }
            // If sport not found
            Console.WriteLine("Sport not found.\n");
        }
        // Method to display all sports in the list
        public void Display()
        {
            // Check if list is empty
            if (sports.Count == 0)
            {
                Console.WriteLine("No sports to display.\n");
                return;
            }
            // Loop through the list and display details
            foreach (var sport in sports)
            {
                sport.DisplayDetails();
            }
        }
    }
}
