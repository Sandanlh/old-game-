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
    class Abmessern : GameObject
    {
        public long Birthtime = 0;

        public override void Act(KeyboardState ks, MouseState ms)
        {
                this.Move(0.5f);

            if(GetCurrentTimeInMilliseconds() - Birthtime > 100)
            {
                CurrentWorld.RemoveGameObject(this);
            }
            Intersection i = this.GetIntersection();
            if (i != null)
            {
                if (i.Object is Boss)
                {
                    Boss B = (Boss)i.Object;
                    int hB = B.Gethealth();
                    B.Sethealth(hB - 10);
                    
                    this.CurrentWorld.RemoveGameObject(this);
                    if (B.Gethealth() <= 0)
                    {
                        this.CurrentWorld.RemoveGameObject(B);
                        Explosion ex = new Explosion(this.Position, 128, 0.1f, 4, 1, ExplosionType.Star, new Vector4(1, 0, 0, 1));
                        CurrentWorld.AddGameObject(ex);

                    }
                    int s = B.Gethealth();
                    String health1 = Convert.ToString(s);
                    HUDObject HB2 = CurrentWorld.GetHUDObjectByName("health B Anzeige");
                    HB2.SetText("Boss: " + health1);
                }
                if (i.Object is Enemy)
                {
                    Enemy e = (Enemy)i.Object;
                    int he = e.Gethealth();
                    e.Sethealth(he - 25);
                    this.CurrentWorld.RemoveGameObject(this);
                    if (e.Gethealth() <= 0)
                    {
                        this.CurrentWorld.RemoveGameObject(e);
                       
 
                    }
                }
                if (i.Object is Enemy2)
                {
                    Enemy2 e2 = (Enemy2)i.Object;
                    int he2 = e2.Gethealth();
                    e2.Sethealth(he2 - 25);
                    this.CurrentWorld.RemoveGameObject(this);
                    if (e2.Gethealth() <= 0)
                    {
                        this.CurrentWorld.RemoveGameObject(e2);
                        GameObject collider = i.Object;
                        if (i.Object is Walls)
                        {

                            this.CurrentWorld.RemoveGameObject(this);
                        }

                    }
                }
                if (i.Object is Walls)
                {
                    Walls w = (Walls)i.Object;
                    this.CurrentWorld.RemoveGameObject(this);
                }
            }
        }

    }
}
