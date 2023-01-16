using TetrisGame.Models;

namespace TetrisGame.Entities
{
    internal class Field
    {
        public List<Square[]> PlayField;

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


        public Field(int height, int width, Figure[] allFigures)
        {
            this.height = height;
            this.width = width;
            PlayField = new List<Square[]>();
            for (int i = 0; i < height; i++)
            {
                PlayField.Add(new Square[width]);
            }
            this.allFigures = allFigures;
        }

        public void CreateFigure()
        {
            int index;
            if (nextFigure == null)
            {
                index = random.Next(allFigures.Length);
                currentFigure = SpawnFigureInMid(allFigures[index].DeepCopy());
            }
            else
            {
                currentFigure = SpawnFigureInMid(nextFigure);
            }

            index = random.Next(allFigures.Length);
            nextFigure = allFigures[index].DeepCopy();
        }


        public void AddFigureToBoard()
        {
            foreach (var c in currentFigure.Coordinates)
            {
                PlayField[c.Y][c.X] = c;
            }
        }


        public void MoveFigureLeft()
        {

            if (IsSaveLeft())
            {
                currentFigure.MoveLeft();
            }
        }

        public void MoveFigureRight()
        {
            if (IsSaveRight())
            {
                currentFigure.MoveRight();
            }
        }

        public void MoveFigureDown()
        {
            if (IsSafeDown())
            {
                currentFigure.MoveDown();
            }
        }

        public bool IsSafeDown()
        {
            foreach (var c in currentFigure.Coordinates)
            {
                if (c.Y >= Height - 1)
                    return false;

                if (c.Y >= 0 && c.Y < Height && PlayField[c.Y + 1][c.X] != null)
                    return false;

                if (c.Y == -1 && PlayField[0][c.X] != null)
                    return false;
            }

            return true;
        }

        public void TryRotateFigure()
        {
            Figure t = currentFigure.DeepCopy();
            t.Rotate();
            if (IsFigureInField(t))
            {
                currentFigure.Rotate();
            }
        }

        public void DeleteFullRows()
        {
            List<int> rowsToDeleting = new List<int>();
            foreach (Square s in CurrentFigure.Coordinates)
            {
                if (!rowsToDeleting.Contains(s.Y))
                {
                    rowsToDeleting.Add(s.Y);
                }
            }

            rowsToDeleting.Sort();

            foreach (var y in rowsToDeleting)
            {
                int count = 0;
                for (int i = 0; i < Width; i++)
                {
                    if (PlayField[y][i] != null)
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (count == PlayField[y].Length)
                {
                    PlayField.RemoveAt(y);
                    PlayField.Insert(0, new Square[Width]);
                }
            }
        }

        private Figure SpawnFigureInMid(Figure figure)
        {
            foreach (var coordinate in figure.Coordinates)
            {
                coordinate.X += FieldMid;
            }

            return figure;
        }

        private bool IsFigureInField(Figure figure)
        {
            foreach (var c in figure.Coordinates)
            {
                if (c.X < 0 || c.X >= Width || c.Y >= Height)
                    return false;

                if (c.Y >= 0 && PlayField[c.Y][c.X] != null)
                    return false;
            }

            return true;
        }

        private bool IsSaveLeft()
        {
            foreach (var c in currentFigure.Coordinates)
            {
                if (c.X < 1)
                    return false;

                if (c.Y >= 0 && c.Y < Height && PlayField[c.Y][c.X - 1] != null)
                    return false;
            }

            return true;
        }
        private bool IsSaveRight()
        {
            foreach (var c in currentFigure.Coordinates)
            {
                if (c.X >= Width - 1)
                    return false;

                if (c.Y >= 0 && c.Y < Height && PlayField[c.Y][c.X + 1] != null)
                    return false;
            }

            return true;
        }
    }
}
