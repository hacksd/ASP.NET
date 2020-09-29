using System;
using System.Collections.Generic;

namespace gameonfinal.Models
{
    public partial class PurchasedGames
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int GameId { get; set; }
        public DateTime DatePurchased { get; set; }

        public Games Game { get; set; }
        public Users User { get; set; }
    }
}
