using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TickTackServer.Models
{
    public class Game
    {

        public int ID { get; set; }
        public Guid GameGUID { get; set; }

        public Player Player1 { get; set; }
        public Player Player2 { get; set; }

        public string GemeData { get; set; }
    }
}