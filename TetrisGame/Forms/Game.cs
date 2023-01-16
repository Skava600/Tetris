using TetrisGame.Entities;
using TetrisGame.Models;

namespace TetrisGame
{
    public partial class Game : Form
    {
        static Field field;
        static int height;
        static int width;
        static PictureBox[,] picField;
        static PictureBox[,] picNextFigure;
        static bool isPlaying = false;
        static Figure[] allFigures;
        public Game()
        {
            InitializeComponent();
            InitField();
            InitNextFigureTable();

            StartGame();
            PauseGame();
        }

        private void InitField()
        {
            height = int.Parse(Environment.GetEnvironmentVariable("field_height") ?? "20");
            width = int.Parse(Environment.GetEnvironmentVariable("field_width") ?? "15");

            string figuresFile = Environment.GetEnvironmentVariable("figures_file") ?? "/figures.json";
            allFigures = new FiguresJsonParser(figuresFile).Deserialize().ToArray();
            picField = new PictureBox[height, width];

            gameTableLayoutPanel.ColumnCount = width;
            gameTableLayoutPanel.RowCount = height;

            gameTableLayoutPanel.RowStyles.Clear();
            gameTableLayoutPanel.ColumnStyles.Clear();
            for (int i = 0; i < height; i++)
                gameTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));

            for (int j = 0; j < width; j++)
                gameTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    picField[i, j] = new PictureBox();
                    picField[i, j].BackColor = Color.White;
                    gameTableLayoutPanel.Controls.Add(picField[i, j], j, i);
                }
            }
        }

        private void InitNextFigureTable()
        {
            picNextFigure = new PictureBox[4, 4];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    picNextFigure[i, j] = new PictureBox();
                    picNextFigure[i, j].BackColor = Color.White;
                    nextFigureTableLayoutPanel2.Controls.Add(picNextFigure[i, j], j, i);
                }
            }
        }

      
        private void CleanFieldTable()
        {
            for (int i = 0; i < field.Height; i++)
                for(int j = 0; j < field.Width;j++)
                {
                    picField[i, j].BackColor = Color.White;
                }
        }

        private void CleanNextFigureTable()
        {
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    picNextFigure[i, j].BackColor = Color.White;
        }

        private void DrawNextFigureTable()
        {
            foreach(var figure in field.NextFigure.Coordinates)
            {
                picNextFigure[figure.Y + 4, figure.X].BackColor = Color.Red;
            }
        }

        private void DrawFigures()
        {
            for (int i = 0; i < field.Height; i++)
                for(int j = 0; j < field.Width; j++)
                {
                    if (field.PlayField[i][j] != null)
                    {
                        if (field.PlayField[i][j].Y != i)
                        {
                            field.PlayField[i][j].Y = i;
                        }

                        picField[field.PlayField[i][j].Y, field.PlayField[i][j].X].BackColor = Color.Blue;
                    }
                }

            foreach(var coordinates  in field.CurrentFigure.Coordinates)
            {
                if (coordinates.Y >= 0)
                    picField[coordinates.Y, coordinates.X].BackColor = Color.Red;
            }
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            this.Game_KeyDown(sender, new  KeyEventArgs(Keys.S));

        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (!isPlaying)
            {
                return;
            }

            if (e.KeyCode == Keys.D)
            {
                field.MoveFigureRight();
            }
            else if (e.KeyCode == Keys.A)
            {
                field.MoveFigureLeft();
            }
            else if(e.KeyCode == Keys.S)
            {
                if (!field.IsSafeDown())
                {
                    if (field.CurrentFigure.IsOut())
                    {
                        EndGame();
                        MessageBox.Show("Game over.");
                        return;
                    }
                    else
                    {
                        field.AddFigureToBoard();
                        field.DeleteFullRows();
                        field.CreateFigure();
                        CleanNextFigureTable();
                        DrawNextFigureTable();
                    }
                }
                else
                {
                    field.MoveFigureDown();
                }
            }
            else if (e.KeyCode == Keys.W)
            {
                field.TryRotateFigure();
            }

            CleanFieldTable();
            DrawFigures();
            
        }

        private void StartGame()
        {
            field = new Field(height, width, allFigures);
            gameTimer.Enabled = true;
            isPlaying = true;

            field.CreateFigure();
            CleanFieldTable();
            CleanNextFigureTable();
            DrawFigures();
            DrawNextFigureTable();
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                PauseGame();

                this.pauseButton.IconChar = FontAwesome.Sharp.IconChar.Play;
            }
            else
            {
                ResumeGame();

                this.pauseButton.IconChar = FontAwesome.Sharp.IconChar.Pause;
            }

        }

        private void EndGame()
        {         
            gameTimer.Stop();
            isPlaying = false;
            
            
            StartGame();
            pauseButton_Click(this, null);
        }

        private void PauseGame()
        {
            gameTimer.Enabled = false;
            isPlaying = false;
        }

        private void ResumeGame()
        {
            gameTimer.Enabled = true;
            isPlaying = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            EndGame();
            StartGame();
        }
    }
}
