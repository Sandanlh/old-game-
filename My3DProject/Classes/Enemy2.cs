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
    class Enemy2 : GameObject
    {
        private int health = 100;
        private long lastChange = 0;
        private string richtung = "rechts";
        private long LastShoot = 0;
        public void Sethealth(int h)
        {

            if (h <= 100)
                this.health = h;
        }

        public int Gethealth()
        {
            return this.health;
        }

        public void Shoot2()
        {
            int counter = -2;
            while (counter < 3)
            {
                EnemyShot Shoot2 = new EnemyShot();
                Shoot2.SetModel("KWCube");
                Shoot2.SetPosition(this.Position);
                Shoot2.SetRotation(this.Rotation);
                Shoot2.SetScale(0.09f);
                CurrentWorld.AddGameObject(Shoot2);
                Shoot2.IsCollisionObject = true;

                Shoot2.AddRotationZ(counter * 10, true);

                counter++;
            }
        }


        public override void Act(KeyboardState ks, MouseState ms)
        {
            

            Player currentPlayer = CurrentWorld.GetGameObjectByName<Player>("Player 1");
            if(currentPlayer != null)
            {
                float distance = this.GetDistanceTo(currentPlayer.Position);
                if (distance <= 4)
                {
                    this.TurnTowardsXY(currentPlayer.Position);
                    this.Move(0.03f);
                    long now2 = CurrentWorld.GetCurrentTimeInMilliseconds();
                    if (now2 - LastShoot > 2000)
                    {
                        Shoot2();
                        LastShoot = now2;
                    }
                }
                if (distance <= 6)
                {
                    int GegnerRandom = HelperRandom.GetRandomNumber(1000, 2000);
                    int RandomNumber = HelperRandom.GetRandomNumber(1, 4);
                    World w = this.CurrentWorld;
                    Player P = w.GetGameObjectByName<Player>("Player 1");

                    if (richtung == "rechts")
                    {
                        this.MoveOffset(0.05f, 0, 0);
                        Vector3 CurrentPosition = this.Position;

                        if (CurrentPosition.X >= 8.1)
                        {
                            richtung = "links";
                        }
                    }
                    else if (richtung == "links")
                    {
                        this.MoveOffset(-0.05f, 0, 0);
                        Vector3 CurrentPosition = this.Position;

                        if (CurrentPosition.X <= -8.1)
                        {
                            richtung = "rechts";
                        }
                    }
                    else if (richtung == "oben")
                    {
                        this.MoveOffset(0f, 0.05f, 0);
                        Vector3 CurrentPosition = this.Position;

                        if (CurrentPosition.Y >= 4.5)
                        {
                            richtung = "unten";
                        }
                    }
                    else if (richtung == "unten")
                    {
                        this.MoveOffset(0f, -0.05f, 0);
                        Vector3 CurrentPosition = this.Position;

                        if (CurrentPosition.Y <= -4.5)
                        {
                            richtung = "oben";
                        }
                    }
                    long now = CurrentWorld.GetCurrentTimeInMilliseconds();
                    if (now - lastChange > 1000)
                    {
                        if (RandomNumber == 1)
                        {
                            richtung = "rechts";
                        }
                        else if (RandomNumber == 2)
                        {
                            richtung = "links";
                        }
                        else if (RandomNumber == 3)
                        {
                            richtung = "oben";
                        }
                        else if (RandomNumber == 4)
                        {
                            richtung = "unten";
                        }

                        lastChange = now;
                    }
                }
            }

               
            List<Intersection> Kollision = GetIntersections();
            foreach (Intersection i in Kollision)
            {
                GameObject collider = i.Object;
                if (collider is Enemy)
                {
                    Vector3 mtvCopy = i.MTV;
                    mtvCopy.Z = 0;
                    MoveOffset(mtvCopy);
                    if (richtung == "links")
                    {
                        richtung = "rechts";
                    }
                    else if (richtung == "rechts")
                    {
                        richtung = "links";
                    }
                    else if (richtung == "oben")
                    {
                        richtung = "unten";
                    }
                    else if (richtung == "unten")
                    {
                        richtung = "oben";
                    }
                }
                if (collider is Walls)
                {
                    Vector3 mtvCopy = i.MTV;
                    mtvCopy.Z = 0;
                    MoveOffset(mtvCopy);
                    if (richtung == "links")
                    {
                        richtung = "rechts";
                    }
                    else if (richtung == "rechts")
                    {
                        richtung = "links";
                    }
                    else if (richtung == "oben")
                    {
                        richtung = "unten";
                    }
                    else if (richtung == "unten")
                    {
                        richtung = "oben";
                    }
                }
            }

        }
        }
    }
