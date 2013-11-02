using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TickTackServer.Models;

namespace TickTackServer.Controllers
{
    public class PlayerController : Controller
    {

        TickTackToeContext _context = new TickTackToeContext();

        public ActionResult GetPlayers()
        {
            var players = _context.Players.ToList();
            string _result = string.Empty;

            foreach (var p in players)
            {
                _result += p.Username + "<br /> ";
            }
            return Content(_result);
        }

        public ActionResult CreatePlayer(string email, string username, string password)
        {
            try
            {
                _context.Players.Add(new Player() { Email = email, Password = password, Username = username });
                _context.SaveChanges();

                return Content("1");
            }
            catch (Exception)
            {
                return Content("0");
            }

        }
    }
}
