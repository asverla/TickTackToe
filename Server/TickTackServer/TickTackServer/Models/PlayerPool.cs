using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TickTackServer.Models
{
    public class PlayerPool
    {
        public int ID { get; set; }
        public Player PlayerID { get; set; }
        public string Setting { get; set; }
    }
}