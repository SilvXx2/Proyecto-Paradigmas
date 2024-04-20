using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public class Enemy
    {
        Transform transform;
        public Transform Transform { get { return transform; } }
        //private int posX = 0;
        //private int posY = 0;
        IntPtr image = Engine.LoadImage("assets/enemy.png");

        
        private Character player;
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

            transform.Translate(new Vector2(0, 10), 5);

        }
    }
}