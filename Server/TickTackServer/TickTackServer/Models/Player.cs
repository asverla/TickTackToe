using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace TickTackServer.Models
{
    public class Player
    {
        [Key]
        public int ID { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Username { get; set; }

        [Required, MinLength(8, ErrorMessage = "Password must contain a minimum of 8 characters.")]
        public string Password { get; set; }


        public int Ranking { get; set; }

        public Guid token { get; set; }
    }
}