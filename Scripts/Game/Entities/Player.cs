using Athormito.Scripts.Engine;
using Microsoft.Xna.Framework.Input;

namespace Athormito.Scripts.Game.Entities
{
    [System.Serializable]
    public sealed class Player : Entity
    {
        public override void Create()
        {
            maxHealth = 100;
            mod = "base";
            texture = "Player";
            base.Create();
        }
        public override void Update()
        {
            if (EngInput.isPressed(Keys.A)) position.X -= 1;
            if (EngInput.isPressed(Keys.D)) position.X += 1;
            if (EngInput.isPressed(Keys.W)) position.Y -= 1;
            if (EngInput.isPressed(Keys.S)) position.Y += 1;
        }
    }
}
