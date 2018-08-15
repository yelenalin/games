using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace games.Models
{
    public class Typelink
    {
        public List<game_type> gametype { get; set; }
        public List<gamelist> gamelist { get; set; }
    }
}