using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KTRAFE.Controllers
{
    public class LobbyController : Controller
    {
        // GET: Lobby
        public ActionResult MainLobby()
        {
            return View();
        }
    }
}