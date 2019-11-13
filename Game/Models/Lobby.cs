using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Game.Models
{
    public class Lobby
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public List<Hero> Members { get; set; }
        public Team TeamRed { get; set; }
        public Team TeamBlue { get; set; }
        public Team CurrenTeam { get; set; }
    }

    public class Team
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public Dictionary<string, Hero> Members { get; set; }
        public int Frags { get; set; }
    }
}
