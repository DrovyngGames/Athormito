using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Athormito.Scripts.Loaders
{
    public static class TextureLoader
    {
        private static Dictionary<string, Texture2D> _loadedTextures = new Dictionary<string, Texture2D>();
        public static Texture2D GetTexture(string mod, string texture)
        {
            string name = mod + "/" + texture;
            if (!_loadedTextures.ContainsKey(name))
            {
                _loadedTextures.Add(name, Texture2D.FromFile(Main.instance.GraphicsDevice, "mods/" + mod + "/graphics/" + texture + ".png"));
            }
            return _loadedTextures[name];
        }
    }
}
