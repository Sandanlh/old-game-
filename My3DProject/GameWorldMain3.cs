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
    class GameworldMain3 : GameWorldSchablone
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
            P.SetPosition(0, -3, 0);
            P.SetScale(0.4f);
            P.SetColor(1, 0, 0);
            int health = P.Gethealth();
            String health1 = Convert.ToString(health);

            Boss B = new Boss();
            B.Name = "Boss1";
            B.SetModel("KWCube");
            B.IsCollisionObject = true;
            B.SetPosition(0, 0, 0);
            B.SetScale(1);
            B.SetColor(1, 0, 1);
            AddGameObject(B);
            int HB = B.Gethealth();
            String HB1 = Convert.ToString(health);

            Walls aw = new Walls();                      
            aw.SetModel("KWCube");
            aw.SetScale(1.5f, 12, 1.5f);
            aw.SetPosition(-5, 0, 0);
            aw.SetTexture(@".\_textures\wall.jpg");
            aw.SetTextureRepeat(1, 6);
            AddGameObject(aw);
            aw.IsCollisionObject = true;

            Walls bw = new Walls();
            bw.SetModel("KWCube");
            bw.SetScale(1.5f, 12, 1.5f);
            bw.SetPosition(5, 0, 0);
            bw.SetTexture(@".\_textures\wall.jpg");
            bw.SetTextureRepeat(1, 6);
            AddGameObject(bw);
            bw.IsCollisionObject = true;

            Walls cw = new Walls();
            cw.SetModel("KWCube");
            cw.SetScale(19, 1.5f, 1.5f);
            cw.SetPosition(0, 4, 0);
            cw.SetTexture(@".\_textures\wall.jpg");
            cw.SetTextureRepeat(10, 1);
            AddGameObject(cw);
            cw.IsCollisionObject = true;

            Walls dw = new Walls();
            dw.SetModel("KWCube");
            dw.SetScale(19, 1.5f, 1.5f);
            dw.SetPosition(0, -4, 0);
            dw.SetTexture(@".\_textures\wall.jpg");
            dw.SetTextureRepeat(10, 1);
            AddGameObject(dw);
            dw.IsCollisionObject = true;
            this.SetCameraPosition(0, 0, 30);

            
            HUDObject hh = new HUDObject(HUDObjectType.Text, 500, 10);
            hh.Name = "health Anzeige";
            hh.CharacterSpreadFactor = 26f;
            hh.SetText("Health: " + health1);
            AddHUDObject(hh);

            HUDObject HB2 = new HUDObject(HUDObjectType.Text, 500, 10);
            HB2.Name = "health B Anzeige";
            HB2.CharacterSpreadFactor = 26f;
            HB2.SetText("Boss: " + HB1);
            HB2.SetPosition(500,500);
            AddHUDObject(HB2);

            TürWon TW = new TürWon();
            TW.SetModel("KWCube");
            TW.SetScale(0.5f, 0.5f, 0.5f);
            TW.SetPosition(0, -0, 0);
            TW.SetColor(0, 1, 0);
            AddGameObject(TW);
            TW.IsCollisionObject = true;

            int textlaenge = "Game Over".Length;

            HUDObject h = new HUDObject(HUDObjectType.Text, 0, 0);
            h.Name = "GameOver Text";
            h.CharacterSpreadFactor = 26f;
            h.SetPosition(1280 / 2 - textlaenge * h.CharacterSpreadFactor / 2, 720 / 2);
            AddHUDObject(h);
        }
    }
}
