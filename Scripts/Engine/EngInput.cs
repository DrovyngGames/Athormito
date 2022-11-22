using Microsoft.Xna.Framework.Input;

namespace Athormito.Scripts.Engine
{
    public static class EngInput
    {
        private static KeyboardState lastState = new KeyboardState();
        private static KeyboardState curState = new KeyboardState();
        public static void Update()
        {
            lastState = curState;
            curState = Keyboard.GetState();
        }
        public static bool isPress(Keys key)
        {
            return curState.IsKeyDown(key) && lastState.IsKeyUp(key);
        }
        public static bool isPressed(Keys key)
        {
            return curState.IsKeyDown(key);
        }
        public static bool isRelease(Keys key)
        {
            return curState.IsKeyUp(key) && lastState.IsKeyDown(key);
        }
    }
}
