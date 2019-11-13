using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Game.Config
{
    public enum WeaponType
    {
        Melee,
        Gun,
        AssaultRifle,
        SniperRifle
    }
    public enum TeamColor
    {
        Red,
        Blue
    }
    public enum HeroClass
    {
        Tank,
        Damage,
        Support
    }

    public static class Urls
    {
        public const string BaseUrl = "https://onlinegameapi.azurewebsites.net";
        public const string ListLobbyUrl = "/api/lobby/list";
        public const string StatusLobbyUrl = "/api/lobby/status/{0}";
        public const string JoinLobbyUrl = "/api/lobby/join/{0}/{1}";
    }
}
