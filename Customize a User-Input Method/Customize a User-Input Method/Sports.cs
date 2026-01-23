using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customize_a_User_Input_Method
{
    internal class Sports
    {
        public string Name { get; set; }
        public string ShapeType { get; set; }
        public string Role { get; set; }


        //Show sport details
        public void DisplayDetails()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Sport Name : " + Name);
            Console.WriteLine("Shape Type : " + ShapeType);
            Console.WriteLine("Sport Role : " + Role);
        }
    }
    internal class PlayerSport : Sports
    {
        public string PlayerName { get; set; }

        //Show sport and player details
        public void DisplayPlayerDetails()
        {
            DisplayDetails();
            Console.WriteLine("Player Name : " + PlayerName);
            Console.WriteLine("-----------------------------");
        }
    }
}
    
