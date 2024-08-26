using CoelacanthEngine.cache;
using CoelacanthEngine.dexvision.primitive;
using CoelacanthEngine.state;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TalosChess.State
{
    public class LoadingScene : BasePermScene
    {
        private SpriteFont _font;
        private readonly GraphicsDevice device;
        private DxStaticString loadingString;

        public LoadingScene(GraphicsDevice device) : base()
        {
            this.device = device;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            this.loadingString.Draw(spriteBatch);
        }

        public override void LoadContent()
        {
            _font = ResourceCache.Instance.GetResource<SpriteFont>("Fonts/Talos_Greek_20");
            this.loadingString = new DxStaticString(device, _font, "loading...", new Rectangle(50, device.Viewport.Height - 100, 400, 100), Color.White);

            // Don't need two copies, so get rid of cache
            //ResourceCache.Instance.Unload();
        }
    }
}
