using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoObjectsInterface
{
    internal class Mountain : GeographicObject
    {
        public float CoordinateX { get; set; }
        public float CoordinateY { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float HighestPoint { get; set; }

        public Mountain(float x, float y, string name, string description, float highestPoint)
        {
            CoordinateX = x;
            CoordinateY = y;
            Name = name;
            Description = description;
            HighestPoint = highestPoint;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Mountain: {Name}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Coordinates: ({CoordinateX}, {CoordinateY})");
            Console.WriteLine($"Highest point: {HighestPoint} m");
        }
    }
}
