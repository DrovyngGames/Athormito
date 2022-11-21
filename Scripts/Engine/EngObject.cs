using Microsoft.Xna.Framework;

namespace Athormito.Scripts.Engine
{
    public class EngObject
    {
        public string id;

        public string texture;

        public bool animated;
        public int animIndex;

        public Vector2 position;
        public Vector2 size;

        public virtual void Create()
        {

        }
        public virtual void Update()
        {

        }
    }
}
