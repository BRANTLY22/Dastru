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
        static void Main(string[] args)
        {
            string[] sports = new string[5];

            Console.WriteLine("Please enter 5 fav Sports:");

            for (int i = 0; i < sports.Length; i++)
            {
                string input;
                do
                {
                    input = Console.ReadLine();

                    if (string.IsNullOrEmpty(input))
                    {
                        Console.WriteLine("Input cannot be empty");
                    }
                } while (string.IsNullOrEmpty(input));

                sports[i] = input;
            }
            Array.Sort(sports);

            Console.WriteLine("\nHere are the Sports you like:");
            foreach (string sport in sports)
            {
                Console.WriteLine(sport);
            }

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        } 
           
    }
    
}
