namespace Game.Classes
{
    [Serializable]
    public class Entity
    {
        public char displayChar { get; set; } = 'o';
        public int posX { get; set; } = 0;
        public int posY { get; set; } = 0;
    }

    [Serializable]
    public class Character : Entity
    {
        public string name { get; set; } = string.Empty;
        public int level { get; set; } = 1;
        public int experience { get; set; } = 0;
        public string[] equipment { get; set; } = new string[0];
        public int money { get; set; } = 0;
        public List<string> inventory { get; set; } = new List<string>();
    }

    [Serializable]
    public class Tile
    {
        public char displayChar { get; set; } = '.';
        public List<string> towns { get; set; } = new List<string>();
        public List<string> flags { get; set; } = new List<string>();
    }

    [Serializable]
    public class World
    {
        public string name { get; set; } = "Dimmadome";
        public string worldDescription { get; set; } = "A default world";
        public Tile[,] worldTiles { get; set; } = new Tile[10, 10];
        public List<Entity> entities { get; set; } = new List<Entity>();
    }
}
