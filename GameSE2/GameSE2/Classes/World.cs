using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSE2.Classes
{
    public class World
    {
        private bool gameWon;
        private bool gameOver;

        public bool GameWon
        {
            get { return gameWon; }
        }

        public bool GameOver
        {
            get { return gameOver; }
        }

        public World(bool gameWon, bool gameOver)
        {
            this.gameWon = gameWon;
            this.gameOver = gameOver;
        }

        public void Update()
        {
            
        }

        public void Draw(Graphics g)
        {
            
        }
    }
}
