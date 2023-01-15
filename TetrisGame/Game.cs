using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TetrisGame
{
    public partial class Game : Form
    {
        static Field field;
        static PictureBox[,] picField;
        static PictureBox[,] picNextFigure;
        static bool isPlaying = false;
        public Game()
        {
            InitializeComponent();
            int height = int.Parse(Environment.GetEnvironmentVariable("field_height") ?? "20"), 
                width = int.Parse(Environment.GetEnvironmentVariable("field_width") ?? "15");

            gameTableLayoutPanel.ColumnCount = width;
            gameTableLayoutPanel.RowCount = height;

            gameTableLayoutPanel.RowStyles.Clear();
            gameTableLayoutPanel.ColumnStyles.Clear();
            for (int i = 0; i < height; i++)
                gameTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));

            for (int j = 0; j < width; j++)
                gameTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
            string figuresFile = Environment.GetEnvironmentVariable("figures_file") ?? "/figures.json";
            field = new Field(height, width, figuresFile);
            picField = new PictureBox[field.Height, field.Width];
            picNextFigure = new PictureBox[4, 4];
            for (int i = 0; i < field.Height; i++)
            {
                for (int j = 0; j < field.Width; j++)
                {
                    picField[i, j] = new PictureBox();
                    picField[i, j].BackColor = Color.White;
                    gameTableLayoutPanel.Controls.Add(picField[i, j], j, i);
                }
            }

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

        private void startButton_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                gameTimer.Enabled = false;
                isPlaying = false;
            }
            else
            {
                drawTimer.Enabled = false;
                gameTimer.Enabled = true;
                isPlaying = true;
            }
            CleanFieldTable();
            CleanNextFigureTable();
            DrawFigures();
            DrawNextFigureTable();
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
                picNextFigure[figure.Y, figure.X].BackColor = Color.Red;
            }
        }

        private void DeleteFullRows()
        {
            int rowsToDelete = 0;
            int firstRow = 0;
            int lastRow = 0;
            int count = 0;
            for (int i = field.Height - 1; i >= 0; i--)
            {
                for (int j = 0; j < field.Width; j++)
                {
                    if (field.PlayField[i, j] == 1)
                    {
                        count++;
                    }
                }

                if (count == field.Width)
                {
                    lastRow = i;
                    for (int j = 0; j < field.Width; j++)
                        field.PlayField[i, j] = 0;


                    rowsToDelete++;
                }

                count = 0;
            }

        }
       

        private void DrawFigures()
        {
            for (int i = 0; i < field.Height; i++)
                for(int j = 0; j < field.Width; j++)
                {
                    if (field.PlayField[i, j] == 1)
                    {
                        picField[i, j].BackColor = Color.Blue;
                    }
                }

            foreach(var coordinates  in field.CurrentFigure.Coordinates)
            {
                picField[coordinates.Y, coordinates.X].BackColor = Color.Red;
            }
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            if (field.IsGameOver())
            {
                drawTimer.Enabled = false;
                gameTimer.Enabled = false;
                isPlaying = false;

            }
            else
            {
                field.Step();

                if (field.IsFigureIntoBarrier())
                {
                    field.HandleFigureFalling();
                    CleanNextFigureTable();
                    DrawNextFigureTable();
                }
                CleanFieldTable();
                DrawFigures();
            }
        }

        private void drawTimer_Tick(object sender, EventArgs e)
        {
            
            
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (isPlaying)
            {
                switch (e.KeyCode)
                {
                    case Keys.D: field.MoveFigureRight(); break;
                    case Keys.A: field.MoveFigureLeft(); break;
                    case Keys.S: field.MoveFigureDown(); break;
                    default: break;
                }
                CleanFieldTable();
                DrawFigures();
            }
        }
    }
}
