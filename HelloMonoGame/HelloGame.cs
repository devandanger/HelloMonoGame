#region Using Statements
using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Input.Touch;
using HelloMonoGame.Components.InputComponent;
using HelloMonoGame.Common;
using UIKit;
using Microsoft.Xna.Framework.GamerServices;

#endregion

namespace HelloMonoGame
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class HelloGame : BaseGame
    {
        private Color backGroundColor;

        protected override void Initialize()
        {
            base.Initialize();
            backGroundColor = Color.Gray;
            InputComponent inputComponent = new InputComponent(this);
            inputComponent.OnTap += InputComponent_OnTap;
            inputComponent.OnDown += InputComponent_OnDown;
            inputComponent.OnUp += InputComponent_OnUp;
            inputComponent.OnLeft += InputComponent_OnLeft;
            inputComponent.OnRight += InputComponent_OnRight;
            this.Components.Add(inputComponent);


            AsyncCallback asyncCallback = new AsyncCallback(AuthenticationResult);
            SignedInGamer signedInGamer = new SignedInGamer();
            signedInGamer.BeginAuthentication(asyncCallback, null);
            if (signedInGamer.IsSignedInToLive)
            {
                System.Console.WriteLine("Connected to live");
            }
            else
            {
                System.Console.WriteLine("Not connected to live");
            }
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

        static void AuthenticationResult(IAsyncResult result)
        {
            System.Console.WriteLine(result.AsyncState);
        }
    }
}

