using System;
using System.Collections.Generic;

namespace gameonfinal.Models
{
    public partial class Users
    {
        public Users()
        {
            PurchasedGames = new HashSet<PurchasedGames>();
            Reviews = new HashSet<Reviews>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime Dateaccountcreated { get; set; }
        public string Displayname { get; set; }
        public string UserAccountId { get; set; }
        public string PhotoPath { get; set; }

        public ICollection<PurchasedGames> PurchasedGames { get; set; }
        public ICollection<Reviews> Reviews { get; set; }
    }
}
