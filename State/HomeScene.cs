using CoelacanthEngine.dexvision;
using CoelacanthEngine.model;
using CoelacanthEngine.state;
using System.Collections.Generic;

namespace TalosChess.State
{
    public class HomeScene : BaseScene
    {
        public HomeScene() : base()
        {
        }

        public override void Initialize()
        {
            throw new System.NotImplementedException();
        }

        protected override List<DxObject> SetDxObjects()
        {
            throw new System.NotImplementedException();
        }

        protected override List<BaseObject> SetGameObjects()
        {
            throw new System.NotImplementedException();
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
