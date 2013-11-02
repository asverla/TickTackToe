using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Mvc;

namespace TickTackServer.Controllers
{
    public class GameController : Controller
    {
        // 
        public ActionResult token()
        {
            System.Guid _token = Guid.NewGuid();

            return Content(_token.ToString());
        }

        // GET api/test
        public ActionResult GetGameState(string token)
        {
            return Content("Gamestate");
        }

    }
}
