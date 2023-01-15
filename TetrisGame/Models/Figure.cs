using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Globalization;

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
    }
}
