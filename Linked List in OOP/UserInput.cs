using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List_in_OOP
{
    internal class UserInput
    {
        // Method to get a string input from the user
        public static string GetString(string message)
        {
            string input;

            // Repeat until user enters something (not empty or whitespace)
            do
            {
                Console.Write(message);         // Show message to user
                input = Console.ReadLine();     // Read input from console

            } while (string.IsNullOrWhiteSpace(input)); // Keep asking if input is empty

            return input; // Return the valid input
        }
        // Method to get an integer input from the user within a range
        public static int GetInt(string message, int min, int max)
        {
            int value;      // Variable to store the number
            bool isValid;   // Flag to check if input is valid
            do
            {
                Console.Write(message);        // Show message to user
                string input = Console.ReadLine(); // Read input

                // Try to convert input to integer
                isValid = int.TryParse(input, out value);

                if (!isValid)
                {
                    // Input is not a number
                    Console.WriteLine("Please enter a valid number.");
                }
                else if (value < min || value > max)
                {
                    // Number is out of range
                    Console.WriteLine($"Please enter a number between {min} and {max}.");
                    isValid = false; // Mark as invalid to repeat
                }

            } while (!isValid); // Repeat until input is valid

            return value; // Return the valid number
        }
    }
}
