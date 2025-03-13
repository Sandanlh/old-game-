using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KWEngine2;
using KWEngine2.Collision;
using KWEngine2.GameObjects;
using OpenTK;
using OpenTK.Input;

namespace My3DProject.Classes
{
    class EnemyShot: GameObject
    {
        public override void Act(KeyboardState ks, MouseState ms)
        {
            this.Move(0.07f);
            Intersection i = GetIntersection();
            if (i != null)
            {
                GameObject collider = i.Object;
                if (collider is Walls)
                {
                    CurrentWorld.RemoveGameObject(this);
                    Explosion ex = new Explosion(this.Position, 128, 0.1f, 4, 1, ExplosionType.Star, new Vector4(1, 0, 0, 1));
                    CurrentWorld.AddGameObject(ex);
                }

            }
            Intersection o = this.GetIntersection();
            if (o != null)
            {
                if (i.Object is Player)
                {
                    Player p = (Player)i.Object;
                    int h = p.Gethealth();
                    p.Sethealth(h - 20);
                    CurrentWorld.RemoveGameObject(this);
                    if (p.Gethealth() <= 0)
                    {
                        this.CurrentWorld.RemoveGameObject(p);
                        this.CurrentWorld.GetHUDObjectByName("GameOver Text").SetText("Game Over");
                    }
                    int s = p.Gethealth();
                    String health1 = Convert.ToString(s);
                    HUDObject hh = CurrentWorld.GetHUDObjectByName("health Anzeige");
                    hh.SetText("Health: " + health1);
                }
            }
        }
    }
}
    