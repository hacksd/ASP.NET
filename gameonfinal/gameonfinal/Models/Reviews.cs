using System;
using System.Collections.Generic;

namespace gameonfinal.Models
{
    public partial class Reviews
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int GameId { get; set; }
        public string Review { get; set; }
        public DateTime Reviewdate { get; set; }

        public Games Game { get; set; }
        public Users User { get; set; }
    }
}
