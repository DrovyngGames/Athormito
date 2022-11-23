using System.Collections.Generic;

namespace Athormito.Scripts.Game
{
    [System.Serializable]
    public sealed class Chunk
    {
        public List<Entity> entities;
        public void Update()
        {
            foreach (var entity in entities)
            {
                entity.Update();
            }
        }
    }
}
