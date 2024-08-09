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
                textures: new List<string> { "Textures/start_button" },
                fonts: new List<string> { },
                songs: new List<string> { },
                sounds: new List<string> { }
                );
            return Manifest;
        }
    }
}
