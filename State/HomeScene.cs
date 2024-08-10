using CoelacanthEngine.audio;
using CoelacanthEngine.cache;
using CoelacanthEngine.dexvision;
using CoelacanthEngine.dexvision.complex;
using CoelacanthEngine.model;
using CoelacanthEngine.state;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace TalosChess.State
{
    public class HomeScene : BaseScene
    {
        private DxButtonCollection collection;
        private readonly GraphicsDevice device;

        public int TransitionToId { get; private set; }

        public HomeScene(GraphicsDevice device) : base()
        {
            this.device = device;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
            collection.Draw(spriteBatch);
        }

        public override void Update(float deltaMs)
        {
            base.Update(deltaMs);
            collection.Update(Input, deltaMs);
        }

        protected override List<DxObject> SetDxObjects()
        {
            collection =
                new DxButtonCollection(device, ButtonCollectionDirection.VERTICAL, 300, 100, 15,
                    new ButtonManifest(
                        ResourceCache.Instance.GetResource<Texture2D>("default_button"),
                        new DxObjectInfo(new Rectangle(0, 0, device.Viewport.Width, device.Viewport.Height)),
                        () => { TransitionToId = 1; },
                        "Play",
                        ResourceCache.Instance.GetResource<SpriteFont>("Talos_Greek_14"),
                        Color.White,
                        ResourceCache.Instance.GetResource<Texture2D>("default_button_hover"))
                );

            return new List<DxObject>(0);
        }

        protected override List<BaseObject> SetGameObjects()
        {
            return new List<BaseObject>(0);
        }

        protected override ResourceManifest SetManifest()
        {
            Manifest = new ResourceManifest(
                //textures: new List<string> { "default_button", "default_button_hover" },
                fonts: new List<string> { "Talos_Greek_14" },
                songs: LoaderPackage.SongsPlaylist
                //sounds: new List<string> { "button_click" }
                );
            return Manifest;
        }
    }
}
