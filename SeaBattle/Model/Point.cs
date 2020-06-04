using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Sea_Battle
{
    class Point : IEquatable<Point>
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x,int y)
        {
            this.X = x;
            this.Y = y;
        }

        public bool Equals([AllowNull] Point other)
        {
            if (other==null)
            {
                return false;
            }
            else if(this.X == other.X && this.Y == other.Y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
