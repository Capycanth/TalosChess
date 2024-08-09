using CoelacanthEngine.cache;
using CoelacanthEngine.state;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TalosChess.State
{
    public class LoadingScene : BasePermScene
    {
        private SpriteFont _font;
        private GraphicsDevice device;
        private readonly string _description = "loading...";

        public LoadingScene(GraphicsDevice device) : base()
        {
            this.device = device;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(_font, _description, new Vector2(100f, device.Viewport.Height - 100f), Color.White);
        }

        public override void LoadContent()
        {
            _font = ResourceCache.Instance.GetResource<SpriteFont>("Talos_Greek_20");

            // Don't need two copies, so get rid of cache
            ResourceCache.Instance.Unload();
        }
    }
}
