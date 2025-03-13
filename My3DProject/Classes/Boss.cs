using KWEngine2;
using KWEngine2.Collision;
using KWEngine2.GameObjects;
using OpenTK.Input;
using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KWEngine2.Helper;

namespace My3DProject.Classes
{
    class Boss : GameObject
    {
        private int health = 5000;
        private long LastShoot = 0;

        public void Sethealth(int h)
        {

            if (h <= 5000)
                this.health = h;
        }

        public int Gethealth()
        {
            return this.health;
        }

        
        public void Shoot2()
        {
            int counter = -4;
            while (counter < 4)
            {
                EnemyShot Shoot2 = new EnemyShot();
                Shoot2.SetModel("KWCube");
                Shoot2.SetPosition(this.Position);
                Shoot2.SetRotation(this.Rotation);
                Shoot2.SetScale(0.2f);
                CurrentWorld.AddGameObject(Shoot2);
                Shoot2.IsCollisionObject = true;

                Shoot2.AddRotationZ(counter * 10, true);

                counter++;
            }
        }
        public override void Act(KeyboardState ks, MouseState ms)
        {
            Player currentPlayer = CurrentWorld.GetGameObjectByName<Player>("Player 1");
            if (currentPlayer != null)
            {
                this.TurnTowardsXY(currentPlayer.Position);
                long now2 = CurrentWorld.GetCurrentTimeInMilliseconds();
                if (now2 - LastShoot > 2000)
                {
                    Shoot2();
                    LastShoot = now2;
                }

            }
        }
    }
}
