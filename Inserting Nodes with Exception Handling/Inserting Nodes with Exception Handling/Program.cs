using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inserting_Nodes_with_Exception_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Name: Brantly Ordeniza
            //Section: IT401A
            //Activity: Inserting Nodes with Exception Handling

            //Create a LinkedList to store names
            LinkedList<string> classmates = new LinkedList<string>();
            //Clear the console screen
            Console.Clear();
            try
            {
                //Ask the user how many names to enter
                Console.Write("Enter the number of classmates, friends, teacher 5 to 10 only: ");
                int count = int.Parse(Console.ReadLine());

                //Validate the number of nodes (must be between 5 and 10)
                if (count < 5 || count > 10)
                {
                    Console.WriteLine("Invalid number. Minimum of 5 and maximum of 10 nodes only.");
                    return;
                }

                //Loop to input names and add them to the LinkedList
                for (int i = 0; i < count; i++)
                {
                    try
                    {
                        //Ask for the last name
                        Console.Write($"Enter last name of classmate, friend, or teacher {i + 1}: ");
                        string name = Console.ReadLine();

                        //Add the name to the end of the LinkedList
                        classmates.AddLast(name);
                    }
                    catch (Exception)
                    {
                        //Handle errors while inserting data
                        Console.WriteLine("Error while inserting data.");
                    }
                }

                //Clear the console before displaying the list
                Console.Clear();

                //Display all names in the LinkedList
                Console.WriteLine("List of Classmates, Friends, Teacher:");
                foreach (string name in classmates)
                {
                    Console.WriteLine(name + " ");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a number only.");
                Console.ReadKey(); //optional: let user see the message
                return;
            }
            catch (Exception)
            {
                //Handle any unexpected errors
                Console.WriteLine("An unexpected error occurred.");
            }

            //Clear the console before showing the sorted list
            Console.Clear();

            //Display the LinkedList (CFT = Classmates, Friends, Teacher)
            Console.WriteLine("My CFT are (sorted):");
            foreach (string CFT in classmates)
            {

                Console.Write(CFT + " -> ");
            }

            //Indicate the end of the LinkedList
            Console.WriteLine("null");

            //Wait for a key press before closing
            Console.ReadKey();
        }
    }
}
