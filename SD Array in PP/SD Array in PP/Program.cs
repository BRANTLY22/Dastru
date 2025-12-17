using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SD_Array_in_PP
{
    internal class Program

    {

        //Name: Brantly Ordeniza
//Section: IT401A
//PROBLEM:Single Dimensional Array in Procedural Programming
static void Main(string[] args)
{
    //Create an array to store 5 SPORTS names
    string[] sports = new string [5];  //Fixed: Added  to specify array size

    Console.WriteLine("Enter your 5 Idol Sports: ");

    //Loop through the array to get input from the user
    for (int i = 0; i < sports.Length; i++)
    {
        //Read the user's input and store it in the array
        sports[i] = Console.ReadLine();

        //Check if the user entered nothing or just spaces
        if (string.IsNullOrEmpty(sports[i]))
        {
            Console.WriteLine("Plsss Enter your Idol sports ");
        }
    }

    //Add a blank line
    Console.WriteLine();

    //Change the text color to blue
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Here are the Sports you like");

    //Loop through each SPORTS in the array and display it
    foreach (string spor in sports)
    {
        //Check if the SPORTS name is not empty
        if (!string.IsNullOrEmpty(spor))
        {
            //Display the SPORTS name
            Console.WriteLine(spor);
        }
        else
        {
            //Display a message if the entry was empty
            Console.WriteLine("Please enter something..");
        }
    }

    //Wait for the user to press a key before closing
    Console.ReadKey();
           
    }
    
}
