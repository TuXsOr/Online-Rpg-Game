﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Classes
{
    // Server configuration class
    public class ServerConfig
    {
        public string serverIP { get; set; } = "0.0.0.0";
        public int serverPort { get; set; } = 8080;
        public int networkBufferSize { get; set; } = 1024;
        public int tickRate { get; set; } = 1000;
        public int startingMoney { get; set; } = 0;
        public List<string> startingItems { get; set; } = new List<string>();
        public string serverDataPath { get; set; } = $"{Directory.GetCurrentDirectory()}\\Data";
        public string worldName { get; set; } = "Default";
    }
}
