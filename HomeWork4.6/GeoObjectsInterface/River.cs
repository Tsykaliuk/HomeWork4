using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoObjectsInterface
{
    public class River : GeographicObject
    {
        public float CoordinateX { get; set; }
        public float CoordinateY { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Speed { get; set; }
        public float Length { get; set; }

        public River(float x, float y, string name, string description, float speed, float length)
        {
            CoordinateX = x;
            CoordinateY = y;
            Name = name;
            Description = description;
            Speed = speed;
            Length = length;
        }

        public void GetInfo()
        {
            Console.WriteLine($"River: {Name}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Coordinates: ({CoordinateX}, {CoordinateY})");
            Console.WriteLine($"River speed: {Speed} cm/s");
            Console.WriteLine($"River length: {Length} km");
        }
    }
}