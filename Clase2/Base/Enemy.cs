using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public class Enemy
    {
        private int posX = 0;
        private int posY = 0;
        IntPtr image = Engine.LoadImage("assets/enemy.png");

        public Enemy(int x, int y)
        {
            posX = x;
            posY = y;
        }

        public Enemy()
        {

        }

        public void Render()
        {
            Engine.Draw(image, posX, posY);
        }

        public void Update()
        {
            posY++;
        }
    }
}
