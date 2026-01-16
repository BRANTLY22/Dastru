using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordeniza_two_dimensional_array_of_objects
{
    internal class Sports
    {
        public string Name { get; set; }
        public string ShapeType { get; set; }
        public string Role { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine("Sport Name : " + Name);
            Console.WriteLine("Shape Type : " + ShapeType);
            Console.WriteLine("Role       : " + Role);
            Console.WriteLine("-----------------------------");
        }
    }
}
