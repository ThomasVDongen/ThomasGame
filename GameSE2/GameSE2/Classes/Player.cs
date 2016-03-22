using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace GameSE2.Classes
{
    public class Player : Character
    {
        public bool PowerUp { get; set; } 

        public int Strenght { get; set; }
        public List<Item> Inventory { get; set; } 
       
        public Player(bool powerUp, int hipoints, Point point)
        {
            this.HitPoints = hipoints;
            this.Position = point;
            this.PowerUp = powerUp;
        }

       
        public void Interaction(int keycode)
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
