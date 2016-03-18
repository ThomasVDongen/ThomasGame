using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSE2.Classes
{
    public class Character
    {
        public Point Position { get; set; }
        public int HitPoints { get; set; }

        public Character(Point point, int hitpoints)
        {
            Position = point;
            HitPoints = hitpoints;
        }

        public Character()
        {
            
        }
        public void Update()
        {

        }

        public void Draw(Graphics g)
        {

        }
    }
}
