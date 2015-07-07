#region Using Statements
using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Input.Touch;

#endregion

namespace HelloMonoGame.Components.InputComponent
{
    public delegate void InputDelegate();
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class InputComponent : GameComponent
    {
		
        public event InputDelegate OnTap;
        public event InputDelegate OnUp;
        public event InputDelegate OnDown;
        public event InputDelegate OnLeft;
        public event InputDelegate OnRight;

        public InputComponent(Game game)
            : base(game)
        {
            TouchPanel.EnabledGestures = 
                GestureType.Tap |
            GestureType.Flick;
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            Tuple<GestureType, Vector2> flickedResult = TouchCollectionExtensions.WasFlicked();
            if (flickedResult != null)
            {
                if (flickedResult.Item1 == GestureType.Tap)
                    this.OnTap();
                else
                {
                    Vector2 flickSpeed = flickedResult.Item2;
                    if (flickSpeed.Y > 0)
                    {
                        this.OnUp();
                    }
                    else if (flickSpeed.Y < 0)
                    {
                        this.OnDown();
                    }
                    else if (flickSpeed.X > 0)
                    {
                        this.OnLeft();
                    }
                    else
                    {
                        this.OnRight();
                    }
                }
            }
        }

    }
}

