using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGameLibrary;

namespace TestGame;

public class Game1 : Core
{
    // Engine Texture
    private Texture2D _logo;

    public Game1() : base("Test Game", 1280, 720, false)
    {
        
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();
    }

    protected override void LoadContent()
    {
        // TODO: use this.Content to load your game content here

        _logo = Content.Load<Texture2D>("images/logo");
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
        GraphicsDevice.Clear(Color.CornflowerBlue);

        // Begin sprite batch preparation for rendering.
        SpriteBatch.Begin();

        // Draw Logo
        SpriteBatch.Draw(_logo, Vector2.Zero, Color.White);

        // End sprite batch when finished.
        SpriteBatch.End();

        base.Draw(gameTime);
    }
}