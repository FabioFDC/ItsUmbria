using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Game.Models;

namespace Game.Controllers
{
    public class GameController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<Lobby> listaLobby = await Manager.GetListLobby();
            return View(listaLobby);
        }

        public async Task<IActionResult> Lobby(int id)
        {
            Lobby Lobbyx = await Manager.GetLobbyStatus(id);
            return View(Lobbyx);
        }

        public bool createHero(HeroCreation hc)
        {
            bool b = await Manager.JoinHero(hc);
            return b;
        }
    }
}