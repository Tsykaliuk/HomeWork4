using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4._3
{
    internal class Mountain : GeographicObject
    {
        public float HighestPoint { get; set; }

        public Mountain(float x, float y, string name, string description, float highestPoint) : base(x, y, name, description)
        {
            HighestPoint = highestPoint;
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Highest point: {HighestPoint} m.");
        }
    }
}
