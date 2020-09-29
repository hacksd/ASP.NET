using System;
using System.Collections.Generic;

namespace gameonfinal.Models
{
    public partial class Games
    {
        public Games()
        {
            PurchasedGames = new HashSet<PurchasedGames>();
            Reviews = new HashSet<Reviews>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Releasedate { get; set; }
        public int PlatFormId { get; set; }
        public int GametypeId { get; set; }
        public string PhotoCover { get; set; }

        public GameType Gametype { get; set; }
        public Platforms PlatForm { get; set; }
        public ICollection<PurchasedGames> PurchasedGames { get; set; }
        public ICollection<Reviews> Reviews { get; set; }
    }
}
