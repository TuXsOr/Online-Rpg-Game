using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Classes
{
    [Serializable]
    internal class Entity
    {
        public char displayChar { get; set; } = 'o';
    }

    [Serializable]
    internal class Character : Entity
    {
        public string name { get; set; } = string.Empty;
        public int level { get; set; } = 1;
        public int experience { get; set; } = 0;
        public int money { get; set; } = 0;
        public List<string> inventory { get; set; } = new List<string>();
    }

    [Serializable]
    internal class Tile
    {
        public char displayChar { get; set; } = '.';
        public List<string> towns { get; set; } = new List<string>();
        public List<Entity> entities { get; set; } = new List<Entity>();

    }

    [Serializable]
    internal class World
    {
        public string name { get; set; } = "Dimmadome";
        public string worldDescription { get; set; } = "A default world";
        public Tile[,] world { get; set; } = new Tile[10,10];
    }
}
