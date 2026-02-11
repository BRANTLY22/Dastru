using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List_in_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new linked list to store sports
            SportLinkedList list = new SportLinkedList();

            // Variable to store user choice
            int choice;

            do
            {
                // Show menu to the user
                Console.WriteLine("\n******* SPORTS MENU *******");
                Console.WriteLine("1. Add Sport");
                Console.WriteLine("2. Remove Sport");
                Console.WriteLine("3. Display Sports");
                Console.WriteLine("4. Exit");

                // Get user choice (must be between 1 and 4)
                choice = UserInput.GetInt("Choose an option: ", 1, 4);

                // Clear the console for clean output
                Console.Clear();

                // Perform action based on user choice
                if (choice == 1)
                {
                    // Add a new sport
                    list.Insert();
                }
                else if (choice == 2)
                {
                    // Remove a sport
                    list.Remove();
                }
                else if (choice == 3)
                {
                    // Display all sports
                    list.Display();
                }
                else if (choice == 4)
                {
                    // Exit the program
                    Console.WriteLine("Program ended.");
                }

                // Keep showing the menu until user chooses 4 (Exit)
            } while (choice != 4);
        }
    }
}
