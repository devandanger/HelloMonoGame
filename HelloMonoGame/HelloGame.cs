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
        private Color backGroundColor;

        protected override void Initialize()
        {
            base.Initialize();
            backGroundColor = Color.CornflowerBlue;
            InputComponent inputComponent = new InputComponent(this);
            inputComponent.OnTap += InputComponent_OnTap;
            inputComponent.OnDown += InputComponent_OnDown;
            inputComponent.OnUp += InputComponent_OnUp;
            inputComponent.OnLeft += InputComponent_OnLeft;
            inputComponent.OnRight += InputComponent_OnRight;
            this.Components.Add(inputComponent);
        }

        void InputComponent_OnRight()
        {
            backGroundColor = Color.Red;
        }

        void InputComponent_OnLeft()
        {
            backGroundColor = Color.Lavender;
        }

        void InputComponent_OnUp()
        {
            backGroundColor = Color.Violet;
        }

        void InputComponent_OnDown()
        {
            backGroundColor = Color.DodgerBlue;
        }

        public void InputComponent_OnTap()
        {
            backGroundColor = Color.Green;
        }

        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
            this.DefaultGraphicsDeviceManager.GraphicsDevice.Clear(backGroundColor);
        }
    }
}

