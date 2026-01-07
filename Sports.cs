using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordeniza_Act1
{
    internal class Sports
    {
        // Properties
        public string Name { get; set; }
        public string ShapeType { get; set; }
        public string Role { get; set; }

        // Method to display details
        public void DisplayDetails()
        {
            Console.WriteLine("Sport Name : " + Name);
            Console.WriteLine("Shape Type : " + ShapeType);
            Console.WriteLine("Role       : " + Role);
            Console.WriteLine("***************************");
        }

    }
}
