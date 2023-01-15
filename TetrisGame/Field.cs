using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TetrisGame.Models;

namespace TetrisGame
{
    internal class Field
    {
        public int[,] PlayField;
        public Figure CurrentFigure { get => currentFigure; }
        public Figure NextFigure { get => nextFigure; }
        public int Height { get => height; }
        public int Width { get => width; }
        public int FieldMid { get => (width - 4) / 2; }
        private Random random = new Random();

        private Figure currentFigure;
        private Figure nextFigure;
        private Figure[] allFigures = new Figure[0];
        private readonly int height;
        private readonly int width;
       

        public Field(int height, int width, string figuresFile)
        {
            this.height = height;
            this.width = width;
            PlayField = new int[height, width];
            allFigures = (new FiguresJsonParser(figuresFile).Deserialize()).ToArray();
            currentFigure = SpawnFigureInMid(CreateFigure());  
            nextFigure = CreateFigure();
        }


        public Figure CreateFigure()
        {
            int index = random.Next(allFigures.Length);
            return allFigures[index].DeepCopy();
        }


        public bool IsGameOver()
        {
            foreach(var square in nextFigure.Coordinates)
            {
                if (PlayField[square.Y, square.X + FieldMid] == 1)
                    return true;
            }

            return false;
        }

        public void MoveFigureLeft()
        {
            foreach (var coordinates in currentFigure.Coordinates)
                coordinates.X--;

            if(IsFigureIntoBarrier())
            {
                foreach (var coordinates in currentFigure.Coordinates)
                    coordinates.X++;
            }
        }

        public void MoveFigureRight()
        {
            foreach (var coordinates in currentFigure.Coordinates)
                coordinates.X++;

            if (IsFigureIntoBarrier())
            {
                foreach (var coordinates in currentFigure.Coordinates)
                    coordinates.X--;
            }
        }

        public void MoveFigureDown()
        {
            foreach (var coordinates in currentFigure.Coordinates)
                coordinates.Y++;

            if (IsFigureIntoBarrier())
            {
                foreach (var coordinates in currentFigure.Coordinates)
                    coordinates.Y--;
            }
        }

        public bool IsFigureIntoBarrier()
        {
            foreach(var coordinates in currentFigure.Coordinates)
            {
                if (coordinates.Y >= height || coordinates.X>= width ||
                    coordinates.X < 0 || 
                    PlayField[coordinates.Y, coordinates.X] == 1)
                    return true;
            }

            return false;
        }

        public void HandleFigureFalling()
        {
            foreach (var coordinates in currentFigure.Coordinates)
            {
                PlayField[--coordinates.Y, coordinates.X] = 1;
            }

            currentFigure = SpawnFigureInMid(nextFigure);
            nextFigure = CreateFigure();
        }

        public void Step()
        {
            foreach(var square in currentFigure.Coordinates)
            {
                square.Y++;
            }
        }

        public void DeleteRow()
        {

        }

        private  Figure SpawnFigureInMid(Figure figure)
        {
            foreach (var coordinate in figure.Coordinates)
            {
                coordinate.X += FieldMid;
            }

            return figure;
        }
    }
}
