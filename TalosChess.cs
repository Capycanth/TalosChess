using CoelacanthEngine.cache;
using CoelacanthEngine.config;
using CoelacanthEngine.input;
using CoelacanthEngine.state;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using TalosChess.State;

namespace TalosChess
{
    public class TalosChess : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private SceneManager _sceneManager;
        private InputManager _input;

        public TalosChess()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            CoelacanthSettings.Initialize("TalosChess");
            ResourceCache.Initialize(Content);
            _input = new InputManager(64);
            _sceneManager = new SceneManager();
            _sceneManager.AddScene(0, new HomeScene());

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            _sceneManager.LoadPermScene(0, new LoadingScene(GraphicsDevice));
            _sceneManager.LoadSceneAsync(0);


            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            _input.Update(gameTime.ElapsedGameTime.Milliseconds);
            if (_input.GetPressDuration(Keys.Escape) > 500 && _input.GetPressDuration(Keys.LeftControl) > 500)
                Exit();

            _sceneManager.Update(gameTime.ElapsedGameTime.Milliseconds);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();
            _sceneManager.Draw(_spriteBatch);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}