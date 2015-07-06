#region Using Statements
using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Input.Touch;

#endregion

namespace HelloMonoGame.Input
{
    public delegate void InputDelegate();
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class InputComponent : GameComponent
    {
		
        public event InputDelegate OnTouch;

        public InputComponent(Game game)
            : base(game)
        {
			
        }


        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            TouchCollection touchState = TouchPanel.GetState();
            if (touchState.AnyTouch())
            {
                if (this.OnTouch != null)
                {
                    this.OnTouch();
                }
            }
        }

    }
}

