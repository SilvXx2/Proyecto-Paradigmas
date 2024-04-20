using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public class CharacterController
    {
        private int speed = 5;
        private Transform transform;
        private DateTime timeLastShoot;
        private float timeBetweenShoots = 1;
        private Vector2 direction = new Vector2(0, -1); // Por defecto, el personaje mira hacia arriba


        public CharacterController(Transform transform)
        {
            this.transform = transform;
        }

        public void GetInputs()
        {
            if (Engine.KeyPress(Engine.KEY_LEFT) || Engine.KeyPress(Engine.KEY_A))
            {
                direction = new Vector2(-1, 0);
                transform.Translate(direction, speed);
            }
            else if (Engine.KeyPress(Engine.KEY_RIGHT) || Engine.KeyPress(Engine.KEY_D))
            {
                direction = new Vector2(1, 0);
                transform.Translate(direction, speed);
            }

            if (Engine.KeyPress(Engine.KEY_UP) || Engine.KeyPress(Engine.KEY_W))
            {
                direction = new Vector2(0, -1);
                transform.Translate(direction, speed);
            }
            else if (Engine.KeyPress(Engine.KEY_DOWN) || Engine.KeyPress(Engine.KEY_S))
            {
                direction = new Vector2(0, 1);
                transform.Translate(direction, speed);
            }

            if (Engine.KeyPress(Engine.KEY_ESP))
            {
                Shoot(direction); // Pasa la dirección al método Shoot
            }

            if (Engine.KeyPress(Engine.KEY_ESC)) { }
        }

        public void Shoot(Vector2 direction)
        {
            DateTime currentTime = DateTime.Now;
            if ((currentTime - timeLastShoot).TotalSeconds >= timeBetweenShoots)
            {
                // Calcula la posición inicial del disparo basándote en la dirección actual
                int posX = transform.Position.x + (direction.x * 48); // 48 es un valor arbitrario, ajusta según el tamaño del personaje
                int posY = transform.Position.y + (direction.y * 48); // 48 es un valor arbitrario, ajusta según el tamaño del personaje
                Program.BulletList.Add(new Bullet(new Vector2(posX, posY)));
                timeLastShoot = currentTime;
            }
        }

    }
}
