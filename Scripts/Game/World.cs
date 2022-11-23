using System;
using System.Collections.Generic;

namespace Athormito.Scripts.Game
{
    [Serializable]
    public sealed class World
    {
        public DateTime gameTime;
        public double timeOfDay;
        public Dictionary<(int, int), Chunk> chunks = new Dictionary<(int, int), Chunk>();
        public Dictionary<string, Entities.Player> players = new Dictionary<string, Entities.Player>();
        public void Update()
        {
            foreach (var chunk in chunks.Values)
            {
                chunk.Update();
            }
        }
    }
}
