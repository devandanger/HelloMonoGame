using System;
using Microsoft.Xna.Framework.Input.Touch;
using Microsoft.Xna.Framework;

namespace HelloMonoGame.Input
{
    public static class TouchCollectionExtensions
    {
        public static bool AnyTouch(this TouchCollection touchState)
        {
            foreach (TouchLocation location in touchState)
            {
                if (location.State == TouchLocationState.Pressed || location.State == TouchLocationState.Moved)
                {
                    return true;
                }
            }
            return false;
        }

        public static Tuple<GestureType, Vector2> WasFlicked()
        {
            while (TouchPanel.IsGestureAvailable)
            {
                GestureSample gesture = TouchPanel.ReadGesture();
                switch (gesture.GestureType)
                {
                    case GestureType.Tap:
                        return new Tuple<GestureType, Vector2>(gesture.GestureType, Vector2.Zero);
                    case GestureType.Flick:
                        return new Tuple<GestureType, Vector2>(gesture.GestureType, gesture.Delta);
                }
            }
            return null;
        }
    }
}
