using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SquidGame
{
    public class SquidGame : Game
    {
        public const int WIDTH = 800;
        public const int HEIGHT = 600;

        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D _squid, _squad;

        SpriteFont _font;

        public SquidGame()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferWidth = WIDTH;
            _graphics.PreferredBackBufferHeight = HEIGHT;
            _graphics.ApplyChanges();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            _squid = this.Content.Load<Texture2D>("Sprite/Character/Squid");
            _squad = this.Content.Load<Texture2D>("Sprite/Character/Squadman_01");
            _font = this.Content.Load<SpriteFont>("Font/GameFont");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.LightPink);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            // Drawing.
            _spriteBatch.Draw(_squad, new Vector2(0, 100), null, Color.DeepPink, 0f, Vector2.Zero, 3f, SpriteEffects.None, 0f);
            _spriteBatch.Draw(_squid, new Vector2(100, 100), null, Color.DeepPink, 0f, Vector2.Zero, 0.1f, SpriteEffects.None, 0f);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
