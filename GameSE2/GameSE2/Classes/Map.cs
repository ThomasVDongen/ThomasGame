using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GameSE2.Classes
{
    public class Map
    {
        public Size MapSize { get; set; }
        public Size CellSize { get; set; }
        public Size CellCount { get; set; }
        public Point GoalPosition { get; set; }

        public Map(Size mapSize, Size cellSize, Size cellCount, Point goalPosition)
        {
            MapSize = mapSize;
            CellSize = cellSize;
            CellCount = cellCount;
            GoalPosition = goalPosition;
        }

        public void Draw(Graphics g)
        {

        }
    }
}
