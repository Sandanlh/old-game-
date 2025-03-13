using KWEngine2;

namespace My3DProject
{
    class GameWindow : GLWindow
    {
        public GameWindow()
            : base(1280, 720, OpenTK.GameWindowFlags.Default, 0, true)
        {
            Title = "My 3D project title";
            SetWorld(new GameWorldMain());
        }
    }
}
