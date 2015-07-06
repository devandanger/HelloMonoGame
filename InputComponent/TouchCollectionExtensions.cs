using System;
using Microsoft.Xna.Framework.Input.Touch;

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
    }
}

