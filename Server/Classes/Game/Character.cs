using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Classes.Game
{
    [Serializable]
    internal class Character
    {
        public string name { get; set; } = string.Empty;
        public int level { get; set; } = 1;
        public int experience { get; set; } = 0;
        public int money { get; set; } = 0;
        public List<string> inventory { get; set; } = new List<string>();
    }
}
