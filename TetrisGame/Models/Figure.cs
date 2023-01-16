using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Globalization;
using System.CodeDom.Compiler;

namespace TetrisGame.Models
{

    internal class Figure
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("coordinates")]
        public List<Square> Coordinates { get; set; } = new List<Square>();

        public Figure DeepCopy()
        {
            var figure = new Figure();
            figure.Name = this.Name;
            figure.Coordinates = this.Coordinates.Select(item => (Square)item.Clone()).ToList();
            return figure;
        }

        public void MoveDown()
        {
            foreach(var c in Coordinates)
            {
                c.MoveDown();
            }
        }

        public void MoveRight()
        {
            foreach(var c in Coordinates)
            {
                c.MoveRight();
            }
        }

        public void MoveLeft()
        {
            foreach (var c in Coordinates)
            {
                c.MoveLeft();
            }
        }

        public void Rotate()
        {
            int maxY = this.Coordinates.Max(c => c.Y);
            int minY = this.Coordinates.Min(c => c.Y);
            int maxX = this.Coordinates.Max(c => c.X);
            int minX = this.Coordinates.Min(c => c.X);
            int i = 0;
            while (maxY - minY != 3)
            {
                if (i % 2 == 1)
                    maxY++;
                else 
                    minY--;
                i++;
            }

            i = 0;

            while (maxX - minX != 3)
            {
                if (i % 2 == 1)
                    maxX++;
                else
                    minX--;
                i++;
            }

            Square UpLeftAngle = new Square(minX, minY);

            int size = 4;
            int[,] matrix = new int[size, size];

            foreach(var c in Coordinates)
            {
                matrix[c.Y - UpLeftAngle.Y, c.X - UpLeftAngle.X] = 1;
            }

            for (i = 0; i < (size + 1) / 2; i++)
            {
                for (int j = 0; j < size / 2; j++)
                {
                    int temp = matrix[size - j - 1, i];
                    matrix[size - 1 - j, i] = matrix[size - 1 - i, size - 1 - j];
                    matrix[size - 1 - i, size - 1 - j] = matrix[j, size - 1 - i];
                    matrix[j, size - 1 - i] = matrix[i, j];
                    matrix[i, j] = temp;
                }
            }

            this.Coordinates = new List<Square>();
            for (i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (matrix[i, j] == 1)
                    {
                        Coordinates.Add(new Square(j + UpLeftAngle.X, i + UpLeftAngle.Y));
                    }
                }
            }
        }

        public bool IsOut()
        {
            foreach(var c in Coordinates)
            {
                if (c.Y < 0)
                    return true;
            }

            return false;
        }
    }
}
