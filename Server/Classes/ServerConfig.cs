using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Classes
{
    // Server configuration class
    public class ServerConfig
    {
        public string serverIP { get; set; } = "127.0.0.1";
        public int serverPort { get; set; } = 80;
        public int networkBufferSize { get; set; } = 1024;
        public int tickRate { get; set; } = 1000;
    }
}
