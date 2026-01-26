using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inserting_Nodes_to_the_Linked_List
{
    internal class Program
    {
        //Name: Brantly Ordeniza
        //Secrtion: IT401A
        //Course: Dastru
        //Problem: Choose one type of collection for your linked list (minimum number of nodes: 5; maximum number of nodes: 10)
        //Names of your Classmates(ask the first name only)
        //Names of your Favorite Teacher(ask the last name only)
        //Names of your friends(ask for the first name only)
        //Write a program in a procedural approach that will insert nodes from the content type you have chosen on the above list using the appropriate method and loop structure and display all the content of the linked list.
        //When developing your code, make sure you identify the parts of your code structure by using comments, and at the beginning of your code, you must comment on your complete name and the given problem you are solving.
        static void Main(string[] args)
        {
            //Declare a LinkedList to store classmates' first names
            LinkedList<string> classmates = new LinkedList<string>();
            Console.Clear();
            Console.Write("Enter the number of classmates, Frieds, Teacher 5 to 10 only: ");
            int count = int.Parse(Console.ReadLine());
            //Validate number of nodes
            if (count < 5 || count > 10)
            {
                Console.WriteLine("Invalid number.minimum number of 5 nodes.");
                return;
            }
            //Input loop to insert nodes
            for (int i = 1; i <= count; i++) 
            {
                Console.Write($"Enter last name of classmate, Friends, Teacher #{i}: ");
                string name = Console.ReadLine();

               //Insert node at the end of the LinkedList
                classmates.AddLast(name);
            }
            Console.Clear();
            //Display all contents of the LinkedList
            Console.WriteLine("\nList of Classmates, Friends, Teacher:");
            foreach (string name in classmates)
            {
                Console.WriteLine(name + " ");
            }
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
