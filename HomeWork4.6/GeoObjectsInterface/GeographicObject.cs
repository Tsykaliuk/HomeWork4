using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoObjectsInterface
{
    internal interface GeographicObject
    {
        float CoordinateX { get; set; }
        float CoordinateY { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        void GetInfo();
    }
}
