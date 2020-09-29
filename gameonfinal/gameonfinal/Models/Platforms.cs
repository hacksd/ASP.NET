using System;
using System.Collections.Generic;

namespace gameonfinal.Models
{
    public partial class Platforms
    {
        public Platforms()
        {
            Games = new HashSet<Games>();
        }

        public int PlatformId { get; set; }
        public string Title { get; set; }

        public ICollection<Games> Games { get; set; }
    }
}
