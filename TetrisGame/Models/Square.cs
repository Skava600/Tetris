using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TetrisGame.Models
{
    internal class Square : ICloneable
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


        public void MoveDown()
        {
            Y++;
        }

        public void MoveRight()
        {
            X++;
        }

        public void MoveLeft()
        {
            X--;
        }
    }
}
