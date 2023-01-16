using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TetrisGame.Models;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace TetrisGame
{
    internal class FiguresJsonParser
    {
        private string file;
        public FiguresJsonParser(string file) 
        {
            this.file = file;
        }

        public IEnumerable<Figure> Deserialize()
        {
            IEnumerable<Figure>? figures;
            try
            {
                string json = File.ReadAllText(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "/" + file);
                figures = JsonSerializer.Deserialize<IEnumerable<Figure>>(json);

            }
            catch 
            {
                MessageBox.Show("Error during deserealization");
                return Array.Empty<Figure>();
            }

            return figures == null ?  Array.Empty<Figure>() : figures.ToArray();
        }

        public void Serialize(IEnumerable<Figure> figures)
        {
            try
            {
                File.WriteAllText(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "/" + file,
                                  JsonSerializer.Serialize<IEnumerable<Figure>>(figures, new JsonSerializerOptions { WriteIndented = true}));
            }
            catch
            {
                MessageBox.Show("Error during serealization");
            }
        }
    }
}
