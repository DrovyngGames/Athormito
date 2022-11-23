using Athormito.Scripts.Engine;
using Athormito.Scripts.Game;
using Athormito.Scripts.Loaders;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Athormito
{
    public class Main : Game
    {
        public static Main instance;
        public static World curWorld;
        public static string curPlayer;

        public const double UpdateTime = 1d / 60d;
        public double timeToUpdate;
        public double timeToDraw;

        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        public Main()
        {
            _graphics = new GraphicsDeviceManager(this);
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            instance = this;

            _graphics.PreferredBackBufferWidth = 1280;
            _graphics.PreferredBackBufferHeight = 720;
            _graphics.IsFullScreen = false;
            _graphics.ApplyChanges();

            curWorld = new World();
            var plr = new Scripts.Game.Entities.Player();
            plr.position.X = 640;
            plr.position.Y = 360;
            plr.Create();
            curWorld.players.Add("test", plr);
            curPlayer = "test";

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
            if (curWorld != null)
            {
                curWorld.Update();
                if (curPlayer != null)
                {
                    curWorld.players[curPlayer].Update();
                }
            }
        }
        public void EngineDraw()
        {
            GraphicsDevice.Clear(Color.Gray);

            _spriteBatch.Begin();

            foreach (var player in curWorld.players.Values)
            {
                DrawObject(player, "entities");
            }

            _spriteBatch.End();
        }
        public void DrawObject(EngObject obj, string directory)
        {
            var texture = TextureLoader.GetTexture(obj.mod, directory + "/" + obj.texture);
            _spriteBatch.Draw(texture, obj.position, null, Color.White, 0, new Vector2(texture.Width, texture.Height) / 2, 1, SpriteEffects.None, 0);
        }
        protected override void Update(GameTime gameTime)
        {
            timeToUpdate += gameTime.ElapsedGameTime.TotalSeconds;
            if (timeToUpdate >= UpdateTime)
            {
                EngineUpdate();
                timeToUpdate = 0;
                base.Update(gameTime);
            }
        }
        protected override void Draw(GameTime gameTime)
        {
            timeToDraw += gameTime.ElapsedGameTime.TotalSeconds;
            if (timeToDraw >= UpdateTime)
            {
                EngineDraw();
                timeToDraw = 0;
                base.Draw(gameTime);
            }
        }
    }
}
