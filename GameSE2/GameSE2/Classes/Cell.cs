using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSE2.Classes
{
    public class Cell
    {
        public Point Index { get; set; }

        public Point Position { get; set; }

        public CellType Type { get; set; }

        public Cell(Point index, Point position, CellType type)
        {
            Index = index;
            Position = position;
            Type = type;
        }

        public void Draw(Graphics g)
        {
            
        }
    }

    public enum CellType
    {
        Normal, Goal, Wall
    }
}
