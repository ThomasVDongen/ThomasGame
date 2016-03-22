using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSE2.Classes
{
    public abstract class Character
    {
        public Point Position { get; set; }
        public int HitPoints { get; set; }


        public abstract void Update();

        public abstract void Draw(Graphics g);
       
    }
}
