

using System;
using System.Collections.Generic;
using Tao.Sdl;

namespace MyGame
{

    class Program
    {

        static IntPtr image = Engine.LoadImage("assets/fondo.png");
        static public List<Enemy> EnemyList = new List<Enemy>();
        static public List<Bullet> BulletList = new List<Bullet>();

        static Character player = new Character(350, 350);

        static void Main(string[] args)
        {
            Engine.Initialize();
            CreateEnemies();

            while (true)
            {

                Update();
                Render();

                Sdl.SDL_Delay(20);
            }
        }

        private static void Render()
        {
            Engine.Clear();

            Engine.Draw(image, 0, 25);

            player.Render();
            foreach (Enemy enemy in EnemyList)
            {
                enemy.Render();
            }

            foreach (Bullet bullet in BulletList)
            {
                bullet.Render();
            }

            Engine.Show();
        }

        private static void Update()
        {
            player.Update();
            foreach (Enemy enemy in EnemyList)
            {
                enemy.Update();
            }
            foreach (Bullet bullet in BulletList)
            {
                bullet.Update();
            }
        }

        private static void CreateEnemies()
        {
            EnemyList.Add(new Enemy(0, 0,player));
            EnemyList.Add(new Enemy(200, 0,player));
            
        }



    }

}


