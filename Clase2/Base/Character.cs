using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public class Character
    {
        private int posX = 0;
        private int posY = 0;
        IntPtr image = Engine.LoadImage("assets/player.png");

        public Character(int x, int y) {
            posX = x;
            posY = y;
        }

        public Character()
        {

        }

        public void Render()
        {
            Engine.Draw(image, posX, posY);
        }

        public void Update()
        {
            int speed = 4; // Player´s Speed

            if (Engine.KeyPress(Engine.KEY_LEFT))
            {
                posX -= speed;
            }

            if (Engine.KeyPress(Engine.KEY_RIGHT))
            {
                posX += speed;
            }

            if (Engine.KeyPress(Engine.KEY_UP))
            {
                posY -= speed;
            }

            if (Engine.KeyPress(Engine.KEY_DOWN))
            {
                posY += speed;
            }

            if (Engine.KeyPress(Engine.KEY_A))
            {
                posX -= speed;
            }

            if (Engine.KeyPress(Engine.KEY_D))
            {
                posX += speed;
            }

            if (Engine.KeyPress(Engine.KEY_W))
            {
                posY -= speed;
            }

            if (Engine.KeyPress(Engine.KEY_S))
            {
                posY += speed;
            }

            if (Engine.KeyPress(Engine.KEY_ESC))
            {
                // Hacer algo cuando se presiona ESC
            }

            if (Engine.KeyPress(Engine.KEY_ESP))
            {
                Shoot();
            }
        }


        public void Shoot()
        {
            Program.BulletList.Add(new Bullet(posX+48, posY));
        }
    }
}
