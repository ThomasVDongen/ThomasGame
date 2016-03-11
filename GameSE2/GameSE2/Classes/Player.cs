using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSE2.Classes
{
    public class Player
    {
        public Point PositionPoint { get; set; }
        public bool PowerUp { get; set; } 
        public int HitPoints { get; set; }

        public Player(Point positionPoint, bool powerUp, int hitPoints)
        {
            PositionPoint = positionPoint;
            PowerUp = powerUp;
            HitPoints = hitPoints;
        }

        public void Update()
        {
            
        }

        public void Draw(Graphics g)
        {
            
        }

        public void Interaction(int keycode)
        {
            
        }
    }
}
