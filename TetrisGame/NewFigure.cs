using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TetrisGame.Models;

namespace TetrisGame
{

    public partial class NewFigure : Form
    {
        const int FigureRows = 4;
        const int FigureColumns = 4;
        Figure newFigure = new Figure();
        public NewFigure()
        {
            InitializeComponent();
            for (int i = 0; i < FigureRows; i++)
            {
                for (int j = 0; j <  FigureColumns; j++)
                {
                    Button button = new Button();
                    button.BackColor = Color.White;
                    button.Dock = DockStyle.Fill;;
                    button.Click += (object sender, EventArgs e) =>
                    {
                        var pos = figureTableLayoutPanel.GetCellPosition(button);
                        ChooseCell(sender, e, new Square(pos.Column, pos.Row));
                    };

             

                    figureTableLayoutPanel.Controls.Add(button, j, i);
                }
            }
        }

        private void saveBlockButton_Click(object sender, EventArgs e)
        {
            bool success = true;
            if (string.IsNullOrEmpty(figureNameTextBox.Text))
            {
                MessageBox.Show("Enter the name of new figure.");
                success = false;
            }

            if (newFigure.Coordinates.Count > 8)
            {
                MessageBox.Show("Too many blocks choosed");
                success = false;
            }
            if (newFigure.Coordinates.Count == 0)
            {
                MessageBox.Show("Blocks not choosed.");
            }

            foreach(var coordinate in newFigure.Coordinates)
            {
                if (!newFigure.Coordinates.Any(c => (c.X == coordinate.X && c.Y == coordinate.Y - 1) ||
                                                   (c.X == coordinate.X && c.Y == coordinate.Y + 1) ||
                                                   (c.X == coordinate.X + 1 && c.Y == coordinate.Y) ||
                                                   (c.X == coordinate.X - 1 && c.Y == coordinate.Y) ||
                                                   newFigure.Coordinates.Count == 1))
                                                   
                {
                    MessageBox.Show("All blocks must be close.");
                    success = false;
                }
            }

            if (!newFigure.Coordinates.Any(c =>c.Y == 0))
            {
                MessageBox.Show("First row should contain at least one block.");
                success = false;
            }

            string figuresFile = Environment.GetEnvironmentVariable("figures_file") ?? "/figures.json";
            var parser = new FiguresJsonParser(figuresFile);
            var figures = parser.Deserialize();

            newFigure.Name = figureNameTextBox.Text;

            if (figures.Any(f => f.Name == newFigure.Name))
            {
                MessageBox.Show("Figure with this name exitsts..");
                success = false;
            }

            var set = newFigure.Coordinates.ToHashSet();
            if (figures.Any(f => set.SetEquals(f.Coordinates)))
            {
                MessageBox.Show("Such figure already exists.");
                success = false;
            }

           
            if (!success) return;

            
            figures = figures.Append(newFigure);
            parser.Serialize(figures);
        }


        private void ChooseCell(object sender, EventArgs e, Square square)
        {
            Button button = (Button)sender;
            if (newFigure.Coordinates.Contains(square))
            {
                newFigure.Coordinates.Remove(square);
                button.BackColor = Color.White;
            }
            else
            {
                newFigure.Coordinates.Add(square);
                button.BackColor = Color.Red;
            }

        }
    }
}
