using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSE2.Classes
{
    public class Enemy : Character
    {
        
        public Enemy(Point position, int hitPoints)
        {
            this.Position = position;
            this.HitPoints = hitPoints;
        }

        public void Attack(Player player)
        {
            
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }

        public override void Draw(Graphics g)
        {
            throw new NotImplementedException();
        }
    }
}
