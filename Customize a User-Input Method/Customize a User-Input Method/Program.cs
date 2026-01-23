using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customize_a_User_Input_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create 2x2 array for sports
            PlayerSport[,] sports = new PlayerSport[2, 2];

            Console.WriteLine("ENTER YOUR FAVORITE SPORTS\n");

            //Input sports details
            for (int i = 0; i < sports.GetLength(0); i++)
            {
                for (int j = 0; j < sports.GetLength(1); j++)
                {
                    Console.WriteLine($"Sport [{i + 1},{j + 1}]");
                    sports[i, j] = GetSportInput();
                    Console.WriteLine();
                }
            }

            Console.WriteLine("HERE ARE THE SPORTS YOU LIKE:\n");

            //Display sports details
            for (int i = 0; i < sports.GetLength(0); i++)
            {
                for (int j = 0; j < sports.GetLength(1); j++)
                {
                    sports[i, j].DisplayPlayerDetails();
                }
            }

            Console.ReadLine();//Pause program

        }

        //User input method
        static PlayerSport GetSportInput()
        {
            PlayerSport sport = new PlayerSport();

            Console.Write("Enter sport name: ");
            sport.Name = Console.ReadLine();

            Console.Write("Enter shape type: ");
            sport.ShapeType = Console.ReadLine();

            Console.Write("Enter sport role (Team/Individual): ");
            sport.Role = Console.ReadLine();

            Console.Write("Enter player name: ");
            sport.PlayerName = Console.ReadLine();

            return sport;

        }
    }
}
