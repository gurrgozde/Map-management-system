using System;
using System.Collections.Generic;

namespace DrawMap.Models.DB
{
    public partial class User
    {
        public int Userid { get; set; }
        public string Username1 { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhotoPath { get; set; }
        public string UserName { get; set; }
    }
}
