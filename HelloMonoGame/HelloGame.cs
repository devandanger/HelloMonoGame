#region Using Statements
using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Input.Touch;
using HelloMonoGame.Input;

#endregion

namespace HelloMonoGame
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class HelloGame : BaseGame
    {
        private bool whichOne;

        protected override void Initialize()
        {
            base.Initialize();
            InputComponent inputComponent = new InputComponent(this);
            inputComponent.OnTouch += OnInput;
            this.Components.Add(inputComponent);
        }

        public void OnInput()
        {
            whichOne = !whichOne;
        }

        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);

            if (whichOne)
            {
                this.DefaultGraphicsDeviceManager.GraphicsDevice.Clear(Color.Green);
            }
            else
            {
                this.DefaultGraphicsDeviceManager.GraphicsDevice.Clear(Color.Red);
            }
        }
    }
}

