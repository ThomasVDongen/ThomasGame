using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameSE2.Interfaces;

namespace GameSE2.Classes
{
    public class Item :ICarryable
    {
        public string Name { get; set; }
        public Vector Position { get; set; }

        public Item(Vector position, int weight, string name)
        {
            Position = position;
            Weight = weight;
            Name = name;
        }

        public void Draw(Graphics g)
        {
            
        }

        public int Weight { get; }
    }
}
