using System;
using System.ComponentModel.DataAnnotations;

namespace MovieBookingSytem.Core.Domain
{
    public class Watchlist
    {
        [Key]
        public int WatchlistId { get; set; }
        public int MovieId { get; set; }
    }
}
