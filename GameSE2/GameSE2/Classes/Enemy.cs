using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSE2.Classes
{
    public class Enemy
    {
        public Point Position { get; set; }
        public int HitPoints { get; set; }

        public Enemy(Point position, int hitPoints)
        {
            Position = position;
            HitPoints = hitPoints;
        }

        public void Update()
        {
                    
        }

        public void Draw(Graphics g)
        {
            
        }

        public void Attack(Player player)
        {
            
        }
    }
}
