using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeWork4._3
{
    public abstract class GeographicObject
    {
        public float CoordinateX { get; set; }
        public float CoordinateY { get; set; }
        public string Name  { get; set; }
        public string Description { get; set; }

        public GeographicObject(float x, float y, string name, string description)
        {
            CoordinateX = x;
            CoordinateY = y;
            Name = name;
            Description = description;
        }
        public virtual void GetInfo()
        {
            Console.WriteLine($"Object: {Name}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Coordinates: ({CoordinateX}, {CoordinateY})");
        }
    }
}
