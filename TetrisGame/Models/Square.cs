using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TetrisGame.Models
{
    internal class Square : ICloneable, IEquatable<Square>
    {
        public int X {  get; set; }
        public int Y { get; set; }


        public Square(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Square() { }
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public bool Equals(Square? other)
        {
            if (other == null) return false;

            return this.X == other.X && this.Y == other.Y;
        }

        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode();
        }
    }
}
