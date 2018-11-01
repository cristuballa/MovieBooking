using System;
using System.ComponentModel.DataAnnotations;

namespace MovieBookingSytem.Core.Domain
{
    // MovieSchedule class prototype
    public class MovieSchedule
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int MovieId { get; set; }
        [Required]
        public int CinemaId { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public DateTime TimeFrom { get; set; }
        public DateTime TimeTo { get; set; }
        public float Price { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string RowLetter { get; set; }
        [Required]
        public int SeatPerRow { get; set; }
        public string TakenSeats { get; set; }
        public string Cinema { get; set; }

    }
}
