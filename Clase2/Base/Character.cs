using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public class Character
    {
        private Transform transform;
        private CharacterController controller;
        IntPtr image = Engine.LoadImage("assets/player.png");
        private AnimatorController idle;
        private AnimatorController run;
        private AnimatorController currentAnimation;

        public Transform Transform { get { return transform; } }    
        public Character(Vector2 position)
        {
            transform = new Transform(position);
            controller = new CharacterController(transform);
            CreateAnimations();
            currentAnimation = idle;
        }

        public void Render()
        {
            transform.Position = new Vector2(200, 200);
            Engine.Draw(image, transform.Position.x, transform.Position.y);
        }

        public void Update()
        {
            controller.GetInputs();


        }

        public void Shoot()
        {
            //    Program.BulletList.Add(new Bullet(posX+48, posY));
        }

        private void CreateAnimations()
        {
            List<IntPtr> idleTextures = new List<IntPtr>();
            for (int i = 0; i < 4; i++)
            {
                IntPtr frame = Engine.LoadImage($"assets/Ship/Idle/{i}.png");
                idleTextures.Add(frame);
            }
            idle = new AnimatorController("Idle", idleTextures, 0.1f, true);
            currentAnimation = idle;
        }
    }
}
