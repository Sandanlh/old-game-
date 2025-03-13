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
    class GameworldMain4 : GameWorldSchablone
    {
        public override void Act(KeyboardState ks, MouseState ms)
        {
            
        }

        public override void Prepare()
        {
            int textlaenge = "Game Won, congratz!".Length;

            HUDObject Won = new HUDObject(HUDObjectType.Text, 500, 10);
            Won.Name = "health Anzeige";
            Won.CharacterSpreadFactor = 26f;
            Won.SetText("Game Won, congratz!");
            Won.SetPosition(1280 / 2 - textlaenge * Won.CharacterSpreadFactor / 2, 720 / 2);
            AddHUDObject(Won);
        }
    }
}
