﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Classes.Account
{
    [Serializable]
    internal class UserAccount
    {
        public string username {  get; set; } = string.Empty;
        public string password { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public List<string> characters { get; set; } = new List<string>();
        public List<string> flags { get; set; } = new List<string>();
    }
}
