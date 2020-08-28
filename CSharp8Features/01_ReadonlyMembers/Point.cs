using System;
using System.Collections.Generic;
using System.Text;

namespace _01_ReadonlyMembers
{
    struct Point
    {
        public Point(decimal x, decimal y)
        {
            CoordX = x;
            CoordY = y;
        }

        public decimal CoordX { get; set; }

        public decimal CoordY { get; set; }

        public readonly override string ToString()
        {
            //CoordX = 123; // This will break the code;

            return $"X: {CoordX}; Y: {CoordY};";
        }
    }
}
