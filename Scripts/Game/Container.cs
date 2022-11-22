namespace Athormito.Scripts.Game
{
    [System.Serializable]
    public sealed class Container
    {
        public Item[,] items;
        public byte width;
        public byte height;
        public Container(byte Width, byte Height)
        {
            width = Width;
            height = Height;
            items = new Item[width, height];
        }
    }
}
