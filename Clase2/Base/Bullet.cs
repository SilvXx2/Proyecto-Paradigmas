using System;

namespace MyGame
{
    internal class Bullet
    {
        Transform transform;
        public Transform Transform { get { return transform; } }
        IntPtr image = Engine.LoadImage("assets/bullet.png");

        public Bullet(Vector2 position)
        {
            transform = new Transform(position);
        }

        private void CheckCollisions()
        {

            for (int i = 0; i < Program.EnemyList.Count; i++)
            {
                Enemy enemy = Program.EnemyList[i];
                float distanceX = Math.Abs((enemy.Transform.Position.x + (enemy.Transform.Scale.x / 2)) - (transform.Position.x + (transform.Scale.x / 2)));
                float distanceY = Math.Abs((enemy.Transform.Position.y + (enemy.Transform.Scale.y / 2)) - (transform.Position.y + (transform.Scale.y / 2)));

                float sumHalfWidth = enemy.Transform.Scale.x / 2 + transform.Scale.x / 2;
                float sumHalfH = enemy.Transform.Scale.y / 2 + transform.Scale.y / 2;

                if (distanceX < sumHalfWidth && distanceY < sumHalfH) // hay colision
                {
                    Program.BulletList.Remove(this);
                    Program.EnemyList.Remove(enemy);
                }
            }
        }


        public void Render()
        {
            Engine.Draw(image, transform.Position.x, transform.Position.y);
        }

        public void Update()
        {
            transform.Translate(new Vector2(0, -10), 5);
        }
    }
}
