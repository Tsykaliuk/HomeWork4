using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4._3
{
    public class River : GeographicObject
    {
        public float Speed { get; set; }
        public float Length { get; set; }

        public River(float x, float y, string name, string description, float speed, float length) : base(x, y, name, description)
        {
            Speed = speed;
            Length = length;
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"River speed: {Speed} cm/s");
            Console.WriteLine($"River length: {Length} km");
        }
    }
}
