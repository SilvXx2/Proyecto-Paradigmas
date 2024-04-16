using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public class Enemy
    {
        Transform transform;
       
        // private int posX = 0;
        //private int posY = 0;
        IntPtr image = Engine.LoadImage("assets/enemy.png");

        public Transform Transform { get { return transform; } }   


        private Character player;
        /*public Enemy(int posX, int posY, Character player)
        {
            this.posX = posX;
            this.posY = posY;

            this.player = player;
        }*/
        public Enemy(Vector2 position)
        {
            transform = new Transform(position);    
        }
        public void Render()
        {
            Engine.Draw(image, transform.Position.x, transform.Position.y);
        }

        public void Update()
        {

         /*  int speed = 2;

            if (player != null)
            {
                if (transform.Position.x < player.Transform.Position.x)
                    transform.Position.x += speed;
                else if (transform.Position.x > player.Transform.Position.x)
                    posX -= speed;

                if (posY < player.Transform.Position.y)
                    posY += speed;
                else if (posY > player.Transform.Position.y)
                    posY -= speed;
            } */
        }
    }
}