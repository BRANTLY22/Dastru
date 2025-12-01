using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dastru_first_ACTIVITY
{
    internal class Program
    {
        static void Main(string[] args)
        {
             int num, num1; //stores the number
 string user;   //stores user's choice (y/n)

 while (true) //repeat until user wants to exit
 {
     Console.WriteLine("This program will determine what type of number and display its range.");
     Console.WriteLine();

     Console.Write("Please enter a number: ");
     string input = Console.ReadLine(); //get input from user

     int i = 0;
     bool numeric = true; //assume input is a number

     if (string.IsNullOrEmpty(input)) //empty input is not valid
     {
         numeric = false;
     }

     while (i < input.Length) //check every character
     {
         if (input[i] < '0' || input[i] > '9')// if not a digit
         {
             numeric = false;
             break;
         }
         i++;
     }

     if (!numeric) //if input is not a number
     {
         Console.WriteLine("Please re-try to enter a numeric value.");
         Console.WriteLine();

         Console.Write("Do you want to try again (y/n)? ");
         user = Console.ReadLine();

         if (user == "y") //user wants to try again
         {
             Console.Clear();
             continue;
         }
         else if (user == "n") //user wants to exit
         {
             Console.Clear();
             Console.WriteLine("Thank you for using this program.");
             Console.ReadKey();
             return;
         }

         continue; //go back to start
     }

     num = Convert.ToInt32(input); //convert to number
     num1 = num % 2; //check even or odd

     if (num1 == 0) //even number
     {
         Console.Write($"{num} is an even number.");
         Console.WriteLine();
         Console.WriteLine();
         Console.WriteLine("This is the range of numbers based from the number entered.");

         while (num > 0) //show even numbers down to 0
         {
             Console.Write(num + " ");
             num = num - 2;
         }

         Console.WriteLine();
         Console.WriteLine();

         Console.Write("Do you want to try again (y/n)? ");
         user = Console.ReadLine();

         if (user == "y") //user tries again
         {
             Console.Clear();
         }
         else if (user == "n") //user exits
         {
             Console.Clear();
             Console.WriteLine("Thank you for using this program");
             Console.ReadKey();
             return;
         }
     }
     else if (num1 == 1) //odd number
     {
         Console.WriteLine("Sorry, I cannot provide the range of numbers based from the number you entered.");
         Console.WriteLine();

         Console.Write("Do you want to try again (y/n)? ");
         user = Console.ReadLine();

         if (user == "y") //user tries again
         {
             Console.Clear();
         }
         else if (user == "n") //user exits
         {
             Console.Clear();
             Console.WriteLine("Thank you for using this program");
             Console.ReadKey();
             return;
         }
     }

     Console.ReadKey(); //wait before next loop
        }
    }
    
}
