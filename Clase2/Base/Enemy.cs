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

        
        private Character player;

        public Enemy(int x, int y, Character player)
        {
            posX = x;
            posY = y;
            this.player = player;
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
            
            int speed = 2; 

            if (player != null)
            {
                if (posX < player.PosX)
                    posX += speed;
                else if (posX > player.PosX)
                    posX -= speed;

                if (posY < player.PosY)
                    posY += speed;
                else if (posY > player.PosY)
                    posY -= speed;
            }
        }
    }
}