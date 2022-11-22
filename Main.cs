using Athormito.Scripts.Engine;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Athormito
{
    public class Main : Game
    {
        public static Main instance;

        public const double UpdateTime = 1d / 60d;
        public double timeToUpdate;
        public double timeToDraw;

        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        public Main()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            instance = this;

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }
        public void EngineUpdate()
        {
            EngInput.Update();
        }
        public void EngineDraw()
        {
            GraphicsDevice.Clear(Color.Gray);
        }
        protected override void Update(GameTime gameTime)
        {
            timeToUpdate += gameTime.ElapsedGameTime.Seconds;
            if (timeToUpdate >= UpdateTime)
            {
                EngineUpdate();
                timeToUpdate = 0;
            }
            base.Update(gameTime);
        }
        protected override void Draw(GameTime gameTime)
        {
            timeToDraw += gameTime.ElapsedGameTime.Seconds;
            if (timeToDraw >= UpdateTime)
            {
                EngineDraw();
                timeToDraw = 0;
            }
            base.Draw(gameTime);
        }
    }
}
