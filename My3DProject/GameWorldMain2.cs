using KWEngine2;
using KWEngine2.Collision;
using KWEngine2.GameObjects;
using KWEngine2.Helper;
using KWEngine2.Model;
using OpenTK;
using OpenTK.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My3DProject.Classes;

namespace My3DProject
{
    class GameWorldMain2 : GameWorldSchablone
    {
        public override void Act(KeyboardState ks, MouseState ms)
        {
            
        }

        public override void Prepare()
        {

            Player P = new Player();
            this.AddGameObject(P);
            P.Name = "Player 1";
            P.SetModel("KWCube");
            P.IsCollisionObject = true;
            P.SetPosition(0, -4, 0);
            P.SetScale(0.4f);
            P.SetColor(1, 0, 0);
            int health = P.Gethealth();
            String health1 = Convert.ToString(health);


            Walls aw = new Walls();                      //Border
            aw.SetModel("KWCube");
            aw.SetScale(1.5f, 13.5f, 1.5f);
            aw.SetPosition(-10, 0, 0);
            aw.SetTexture(@".\_textures\wall.jpg");
            aw.SetTextureRepeat(1, 6);
            AddGameObject(aw);
            aw.IsCollisionObject = true;

            Walls bw = new Walls();
            bw.SetModel("KWCube");
            bw.SetScale(1.5f, 13.5f, 1.5f);
            bw.SetPosition(10, 0, 0);
            bw.SetTexture(@".\_textures\wall.jpg");
            bw.SetTextureRepeat(1, 6);
            AddGameObject(bw);
            bw.IsCollisionObject = true;

            Walls cw = new Walls();
            cw.SetModel("KWCube");
            cw.SetScale(20.5f, 1.5f, 1.5f);
            cw.SetPosition(0, 6, 0);
            cw.SetTexture(@".\_textures\wall.jpg");
            cw.SetTextureRepeat(10, 1);
            AddGameObject(cw);
            cw.IsCollisionObject = true;

            Walls dw = new Walls();
            dw.SetModel("KWCube");
            dw.SetScale(20.5f, 1.5f, 1.5f);
            dw.SetPosition(0, -6, 0);
            dw.SetTexture(@".\_textures\wall.jpg");
            dw.SetTextureRepeat(10, 1);
            AddGameObject(dw);
            dw.IsCollisionObject = true;

            Walls ew = new Walls();
            ew.SetModel("KWCube");
            ew.SetScale(11, 1.5f, 1.5f);
            ew.SetPosition(0, 0, 0);
            ew.SetTexture(@".\_textures\wall.jpg");
            ew.SetTextureRepeat(10, 1);
            AddGameObject(ew);
            ew.IsCollisionObject = true;

            Walls fw = new Walls();
            fw.SetModel("KWCube");
            fw.SetScale(1.5f, 6f, 1.5f);
            fw.SetPosition(0, -3, 0);
            fw.SetTexture(@".\_textures\wall.jpg");
            fw.SetTextureRepeat(1, 10);
            AddGameObject(fw);
            fw.IsCollisionObject = true;

            Walls gw = new Walls(); // hier
            gw.SetModel("KWCube");
            gw.SetScale(1.5f, 4, 1.5f);
            gw.SetPosition(-0, 1.8f, 0);
            gw.SetTexture(@".\_textures\wall.jpg");
            gw.SetTextureRepeat(2, 1);
            AddGameObject(gw);
            gw.IsCollisionObject = true;

            Enemy E = new Enemy();
            // E.SetModel("Gegner");
            E.SetModel("KWCube");
            E.SetPosition(-6.1f, 2.27f, 0);
            this.AddGameObject(E);
            E.Name = "Enemy 1";
            E.IsCollisionObject = true;
            E.SetScale(0.4f);

            Enemy E1 = new Enemy();
            // E.SetModel("Gegner");
            E1.SetModel("KWCube");
            E1.SetPosition(-7.1f, 2.27f, 0);
            this.AddGameObject(E1);
            E1.Name = "Enemy 1";
            E1.IsCollisionObject = true;
            E1.SetScale(0.4f);

            Enemy2 E2 = new Enemy2();
            E2.SetModel("KWCube");
            E2.SetPosition(-7.1f, -0.27f, 0);
            this.AddGameObject(E2);
            E2.Name = "Enemy 2";
            E2.IsCollisionObject = true;
            E2.SetScale(0.4f);

            Enemy2 E3 = new Enemy2();
            E3.SetModel("KWCube");
            E3.SetPosition(2, 2.4f, 0);
            this.AddGameObject(E3);
            E3.Name = "Enemy 2";
            E3.IsCollisionObject = true;
            E3.SetScale(0.4f);

            Enemy E4 = new Enemy();
            E4.SetModel("KWCube");
            E4.SetPosition(4, 2.4f, 0);
            this.AddGameObject(E4);
            E4.Name = "Enemy 1";
            E4.IsCollisionObject = true;
            E4.SetScale(0.4f);

            Enemy E5 = new Enemy();
            E5.SetModel("KWCube");
            E5.SetPosition(4, 3.4f, 0);
            this.AddGameObject(E5);
            E5.Name = "Enemy 1";
            E5.IsCollisionObject = true;
            E5.SetScale(0.4f);

            Enemy E6 = new Enemy();
            E6.SetModel("KWCube");
            E6.SetPosition(5.2f, -2.5f, 0);
            this.AddGameObject(E6);
            E6.Name = "Enemy 1";
            E6.IsCollisionObject = true;
            E6.SetScale(0.4f);

            Enemy E7 = new Enemy();
            E7.SetModel("KWCube");
            E7.SetPosition(6.2f, -2.5f, 0);
            this.AddGameObject(E7);
            E7.Name = "Enemy 1";
            E7.IsCollisionObject = true;
            E7.SetScale(0.4f);

            Enemy2 E8 = new Enemy2();
            E8.SetModel("KWCube");
            E8.SetPosition(6.2f, -1.4f, 0);
            this.AddGameObject(E8);
            E8.Name = "Enemy 2";
            E8.IsCollisionObject = true;
            E8.SetScale(0.4f);

            Türen2 T2 = new Türen2();
            T2.SetModel("KWCube");
            T2.SetScale(1, 0.5f, 1);
            T2.SetPosition(2.1f, -2.5f, 0);
            T2.SetColor(0, 1, 0);
            AddGameObject(T2);
            T2.IsCollisionObject = true;

            this.SetCameraPosition(0, 0, 30);
            HUDObject hh = new HUDObject(HUDObjectType.Text, 500, 10);
            hh.Name = "health Anzeige";
            hh.CharacterSpreadFactor = 26f;
            hh.SetText("Health: " + health1);
            AddHUDObject(hh);

            int textlaenge = "Game Over".Length;

            HUDObject h = new HUDObject(HUDObjectType.Text, 0, 0);
            h.Name = "GameOver Text";
            h.CharacterSpreadFactor = 26f;
            h.SetPosition(1280 / 2 - textlaenge * h.CharacterSpreadFactor / 2, 720 / 2);
            AddHUDObject(h);
        }
    }
}
