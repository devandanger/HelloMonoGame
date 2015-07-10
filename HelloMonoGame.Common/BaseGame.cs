#region Using Statements
using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.Input;
using HelloMonoGame.Components.InputComponent;

#endregion

namespace HelloMonoGame.Common
{
    public class BaseGame : Game
    {
        protected GraphicsDeviceManager DefaultGraphicsDeviceManager { get; set; }

        protected IAsyncResult SignedInGamerResult { get; set; }

        public BaseGame()
        {
            this.DefaultGraphicsDeviceManager = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";              
            this.DefaultGraphicsDeviceManager.IsFullScreen = true;  
        }

        protected override void Update(GameTime gameTime)
        {
            // For Mobile devices, this logic will close the Game when the Back button is pressed
            // Exit() is obsolete on iOS
            #if !__IOS__
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
                Keyboard.GetState().IsKeyDown(Keys.Escape))
            {
                Exit();
            }
            #endif
            // TODO: Add your update logic here         
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            this.DefaultGraphicsDeviceManager.GraphicsDevice.Clear(Color.CornflowerBlue);
            base.Draw(gameTime);
        }
    }
}

