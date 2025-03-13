using System;
using System.Collections.Generic;

using KWEngine2;
using KWEngine2.Collision;
using KWEngine2.GameObjects;
using KWEngine2.Helper;
using KWEngine2.Model;

using OpenTK;
using OpenTK.Input;

namespace My3DProject.Classes
{
    public class Player : GameObject
    {
<<<<<<< Updated upstream
=======
        public void Messern()

        {
            int counter = -10;
            while (counter <= 10)
            {
                Abmessern Messer = new Abmessern();
                Messer.SetModel("KWCube");
                Messer.SetPosition(this.Position);
                Messer.SetRotation(this.Rotation);
                Messer.SetScale(0.6f);
                CurrentWorld.AddGameObject(Messer);
                Messer.IsCollisionObject = true;
                Messer.AddRotationZ(counter * 2, true);
                Messer.Birthtime = GetCurrentTimeInMilliseconds();
                counter++;
            }
        }
        private int health = 100;  
        public void Sethealth(int h)
        {

            if (h <= 100)
                this.health = h;
        }

        public int Gethealth()
        {
            return this.health;
        }
>>>>>>> Stashed changes

        public override void Act(KeyboardState ks, MouseState ms)
        {
<<<<<<< Updated upstream
            
=======
            List<Intersection> intersections = GetIntersections();
            foreach (Intersection k in intersections)
            {
                if (k != null)
                {
                    
                    if (k.Object is Walls)
                    {
                        Vector3 mtv = k.MTV;
                        MoveOffset(mtv);
                    }
                    
                    if (k.Object is Türen)
                    {
                        health = 100;
                        GameWorldMain2 map2 = new GameWorldMain2();
                        CurrentWindow.SetWorld(map2);
                    }
                    if (k.Object is Türen2)
                    {
                        health = 100;
                        GameworldMain3 map3 = new GameworldMain3();
                        CurrentWindow.SetWorld(map3);
                    }
                    if (k.Object is TürWon)
                    {
                        health = 100;
                        GameworldMain4 map4 = new GameworldMain4();
                        CurrentWindow.SetWorld(map4);
                    }
                }
            }
            Vector3 mouseCursor3D = HelperIntersection.GetMouseIntersectionPoint(ms, Plane.Z, 1f);

            // mouseCursor3D.X wäre z.B. 5.5
            // mouseCursor3D.Y wäre z.B. 6.3
            // mouseCursor3D.Z wäre z.B. immer 1

            TurnTowardsXY(mouseCursor3D);
            if (ks[Key.Space] == true)
            {
                if (GetCurrentTimeInMilliseconds() - TeleportZeit > 600)
                {
                    Walls result = HelperIntersection.IsMouseCursorOnAny<Walls>(ms, out Vector3 intersectionPoint);
                    if(result == null)
                    {
                        this.Move(0.8f);

                    }
                    TeleportZeit = GetCurrentTimeInMilliseconds();
                }
            }
            if (ks[Key.W] == true)
            {
                Vector3 CurrentPosition = this.Position;
                this.MoveOffset(0, 0.05f, 0);
            }

            if (ks[Key.S] == true)
            {
                Vector3 CurrentPosition = this.Position;


                this.MoveOffset(0, -0.05f, 0);

            }

            if (ks[Key.A] == true)
            {
                Vector3 CurrentPosition = this.Position;


                this.MoveOffset(-0.05f, 0, 0);

            }

            if (ks[Key.D] == true)
            {
                Vector3 CurrentPosition = this.Position;
                Console.WriteLine(CurrentPosition);

                this.MoveOffset(0.05f, 0, 0);
            }
            if (ms[MouseButton.Left] == true)
            {
                if (GetCurrentTimeInMilliseconds() - SchussZeit > 200)
                {
                    Shot Shoot1 = new Shot();
                    Shoot1.SetModel("KWCube");
                    Shoot1.SetPosition(this.Position);
                    Shoot1.SetRotation(this.Rotation);
                    Shoot1.SetScale(0.09f);
                    CurrentWorld.AddGameObject(Shoot1);
                    Shoot1.IsCollisionObject = true;
                    SchussZeit = GetCurrentTimeInMilliseconds();
                }
            }
            if (ms[MouseButton.Right] == true)
            {
                if (GetCurrentTimeInMilliseconds() - MesserZeit >1500)
                {
                    Messern();
                    MesserZeit = GetCurrentTimeInMilliseconds();
                }
            }

            CurrentWorld.SetCameraPosition(this.Position.X, this.Position.Y, 13);
            CurrentWorld.SetCameraTarget(this.Position);
>>>>>>> Stashed changes
        }

    }
}
