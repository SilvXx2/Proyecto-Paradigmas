using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public class Character
    {
        public int PosX { get; private set; } = 0;
        public int PosY { get; private set; } = 0;
        IntPtr image = Engine.LoadImage("assets/player.png");

        public Character(int x, int y) {
            PosX = x;
            PosY = y;
        }

        public Character()
        {

        }

        public void Render()
        {
            Engine.Draw(image, PosX, PosY);
        }

        public void Update()
        {
            int speed = 4; 

            if (Engine.KeyPress(Engine.KEY_LEFT))
            {
                PosX -= speed;
            }

            if (Engine.KeyPress(Engine.KEY_RIGHT))
            {
                PosX += speed;
            }

            if (Engine.KeyPress(Engine.KEY_UP))
            {
                PosY -= speed;
            }

            if (Engine.KeyPress(Engine.KEY_DOWN))
            {
                PosY += speed;
            }

            if (Engine.KeyPress(Engine.KEY_A))
            {
                PosX -= speed;
            }

            if (Engine.KeyPress(Engine.KEY_D))
            {
                PosX += speed;
            }

            if (Engine.KeyPress(Engine.KEY_W))
            {
                PosY -= speed;
            }

            if (Engine.KeyPress(Engine.KEY_S))
            {
                PosY += speed;
            }

            if (Engine.KeyPress(Engine.KEY_ESC))
            {
                
            }

            if (Engine.KeyPress(Engine.KEY_ESP))
            {
                Shoot();
            }
        }


        public void Shoot()
        {
            Program.BulletList.Add(new Bullet(PosX+48, PosY));
        }
    }
}
