using System;
using System.Collections.Generic;

using KWEngine2;
using KWEngine2.Collision;
using KWEngine2.GameObjects;
using KWEngine2.Helper;
using KWEngine2.Model;

using OpenTK;
using OpenTK.Input;

using My3DProject.Classes;

namespace My3DProject
{
    class GameWorldMain : World
    {

        public override void Act(KeyboardState kb, MouseState ms)
        {
<<<<<<< Updated upstream
           
=======

            
>>>>>>> Stashed changes
        }
       
        public override void Prepare()
        {
<<<<<<< Updated upstream
            FOV = 45;
            SetCameraPosition(0, 0, 30f);

            SetTextureBackground(@".\textures\space_background.dds", 2, 2);

            DebugShowCoordinateSystem = true;
            DebugShowCoordinateSystemGrid = GridType.GridXY;
=======
            
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

            Enemy E = new Enemy();
            // E.SetModel("Gegner");
            E.SetModel("KWCube");
            E.SetPosition(4,-4 , 0);
            this.AddGameObject(E);
            E.Name = "Enemy 1";
            E.IsCollisionObject = true;
            E.SetScale(0.4f);

            Enemy E1 = new Enemy();
            // E.SetModel("Gegner");
            E1.SetModel("KWCube");
            E1.SetPosition(5, -4, 0);
            this.AddGameObject(E1);
            E1.Name = "Enemy 1";
            E1.IsCollisionObject = true;
            E1.SetScale(0.4f);

            Enemy2 E2 = new Enemy2();
            E2.SetModel("KWCube");
            E2.SetPosition(-7.1f,-1.1f , 0);
            this.AddGameObject(E2);
            E2.Name = "Enemy 2";
            E2.IsCollisionObject = true;
            E2.SetScale(0.4f);

            Enemy2 E3 = new Enemy2();
            E3.SetModel("KWCube");
            E3.SetPosition(3.2f, -0.072f, 0);
            this.AddGameObject(E3);
            E3.Name = "Enemy 2";
            E3.IsCollisionObject = true;
            E3.SetScale(0.4f);

            Enemy E4 = new Enemy();
            // E.SetModel("Gegner");
            E4.SetModel("KWCube");
            E4.SetPosition(-4, 3.3f, 0);
            this.AddGameObject(E4);
            E4.Name = "Enemy 1";
            E4.IsCollisionObject = true;
            E4.SetScale(0.4f);

            Enemy2 E5 = new Enemy2();
            E5.SetModel("KWCube");
            E5.SetPosition(-3, 3.3f, 0);
            this.AddGameObject(E5);
            E5.Name = "Enemy 2";
            E5.IsCollisionObject = true;
            E5.SetScale(0.4f);

            // Level Modelieren:



            Walls aw = new Walls();                      //Border
            aw.SetModel("KWCube");
            aw.SetScale(1.5f, 13.5f, 1.5f);
            aw.SetPosition(-10, 0, 0);
            //aw.SetColor(1, 0, 0);
            aw.SetTexture(@".\_textures\wall.jpg");
            aw.SetTextureRepeat(1, 6);
            AddGameObject(aw);
            aw.IsCollisionObject = true;

            Walls bw = new Walls();
            bw.SetModel("KWCube");
            bw.SetScale(1.5f, 13.5f, 1.5f);
            bw.SetPosition(10, 0, 0);
            //bw.SetColor(1, 0, 1);
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


            Walls ew = new Walls();              // Räume
            ew.SetModel("KWCube");
            ew.SetScale(5, 1.5f, 1.5f);
            ew.SetPosition(-7, 1, 0);
            ew.SetTexture(@".\_textures\wall.jpg");
            ew.SetTextureRepeat(2, 1);
            AddGameObject(ew);
            ew.IsCollisionObject = true;

            Walls fw = new Walls();
            fw.SetModel("KWCube");
            fw.SetScale(1.5f, 5, 1.5f);
            fw.SetPosition(-4.5f, -1.2f, 0);
            fw.SetTexture(@".\_textures\wall.jpg");
            fw.SetTextureRepeat(1, 2);
            AddGameObject(fw);
            fw.IsCollisionObject = true;

            Walls gw = new Walls(); // hier
            gw.SetModel("KWCube");
            gw.SetScale(5, 1.5f, 1.5f);
            gw.SetPosition(0.5f, -1.5f, 0);
            gw.SetTexture(@".\_textures\wall.jpg");
            gw.SetTextureRepeat(2, 1);
            AddGameObject(gw);
            gw.IsCollisionObject = true;

            Walls hw = new Walls();
            hw.SetModel("KWCube");
            hw.SetScale(1.5f, 5, 1.5f);
            hw.SetPosition(2.25f, -3.5f, 0);
            hw.SetTexture(@".\_textures\wall.jpg");
            hw.SetTextureRepeat(1, 2);
            AddGameObject(hw);
            hw.IsCollisionObject = true;

            Walls iw = new Walls();
            iw.SetModel("KWCube");
            iw.SetScale(5, 1.5f, 1.5f);
            iw.SetPosition(-2, 1.05f, 0);
            iw.SetTexture(@".\_textures\wall.jpg");
            iw.SetTextureRepeat(2, 1);
            AddGameObject(iw);
            iw.IsCollisionObject = true;

            Walls jw = new Walls();
            jw.SetModel("KWCube");
            jw.SetScale(1.5f, 2, 1.5f);
            jw.SetPosition(0.5f, 1.8f, 0);
            jw.SetTexture(@".\_textures\wall.jpg");
            jw.SetTextureRepeat(1, 1);
            AddGameObject(jw);
            jw.IsCollisionObject = true;

            Walls kw = new Walls();
            kw.SetModel("KWCube");
            kw.SetScale(1.5f, 2, 1.5f);
            kw.SetPosition(0.5f, 5.5f, 0);
            kw.SetTexture(@".\_textures\wall.jpg");
            kw.SetTextureRepeat(1, 1);
            AddGameObject(kw);
            kw.IsCollisionObject = true;

            Walls lw = new Walls();
            lw.SetModel("KWCube");
            lw.SetScale(5, 1.5f, 1.5f);
            lw.SetPosition(3, 1.05f, 0);
            lw.SetTexture(@".\_textures\wall.jpg");
            lw.SetTextureRepeat(2, 1);
            AddGameObject(lw);
            lw.IsCollisionObject = true;

            Walls mw = new Walls();
            mw.SetModel("KWCube");
            mw.SetScale(2, 1.5f, 1.5f);
            mw.SetPosition(8.5f, 1.05f, 0);
            mw.SetTexture(@".\_textures\wall.jpg");
            mw.SetTextureRepeat(1, 1);
            AddGameObject(mw);
            mw.IsCollisionObject = true;
            
            Türen T1 = new Türen();
            T1.SetModel("KWCube");
            T1.SetScale(1, 0.5f, 1);
            T1.SetPosition(-7.3f, 3.5f, 0);
            T1.SetColor(0, 1, 0);
            AddGameObject(T1);
            T1.IsCollisionObject = true;

            this.SetCameraPosition(0, 0, 30);


            int textlaenge = "Game Over".Length;

            HUDObject h = new HUDObject(HUDObjectType.Text, 0, 0);
            h.Name = "GameOver Text";
            h.CharacterSpreadFactor = 26f;
            h.SetPosition(1280 / 2 - textlaenge * h.CharacterSpreadFactor / 2, 720 / 2);
            

            AddHUDObject(h);

            HUDObject hh = new HUDObject(HUDObjectType.Text, 500, 10);
            hh.Name = "health Anzeige";
            hh.CharacterSpreadFactor = 26f;
            hh.SetText("Health: "+ health1);
            AddHUDObject(hh);
>>>>>>> Stashed changes
        }

    }
}
