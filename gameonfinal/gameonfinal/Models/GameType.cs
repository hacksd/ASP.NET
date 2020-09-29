using System;
using System.Collections.Generic;

namespace gameonfinal.Models
{
    public partial class GameType
    {
        public GameType()
        {
            Games = new HashSet<Games>();
        }

        public int GametypeId { get; set; }
        public string GameType1 { get; set; }

        public ICollection<Games> Games { get; set; }
    }
}
