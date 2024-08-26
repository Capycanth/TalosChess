using CoelacanthEngine.input;
using CoelacanthEngine.model;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TalosChess.Assets
{
    public class StaticBackground : BaseObject
    {
        public StaticBackground(string name, Rectangle rectangle, Texture2D texture) : base(name, rectangle, texture)
        {
        }

        public override void Update(InputManager input, float deltaMs)
        {
            
        }
    }
}
