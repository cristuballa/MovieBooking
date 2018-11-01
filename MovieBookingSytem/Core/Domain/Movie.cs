using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace MovieBookingSytem.Core.Domain
{
    public enum Genre
    {
        Scifi,
        Drama,
        Adventure
    }
    // Movie prototype
   public class Movie
    {

        [Key]
        public int Id { get; set; }

 
        [Required(AllowEmptyStrings = false, ErrorMessage = "Title is required2.")]
        [MaxLength(100, ErrorMessage = "String length is 100")]
        public string Title { get; set; }


        [MaxLength(300, ErrorMessage = "String length is 100")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Description is required")]
        public string Description { get; set; }

        public byte[] Poster { get; set; }

        public DateTime ReleaseDate { get; set; }


        [Required(ErrorMessage = "Genre is required")]
        public  Genre Genre { get; set; }


        [Range(1, 100, ErrorMessage = "IMDB Rating[1-100]")]
        public float ImdbRating { get; set; }


        [Range(1, 100, ErrorMessage = "Rotten Tomatoes Rating[1-100]")]
        public float RottenTomatoesRating { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "PGRating is required")]
        public string PgRating { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "Trailer is required")]
        public string  Trailer { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "Director is required")]
        public string Director { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "Casts is required")]
        public string Casts { get; set; }
       
        public List<MovieSchedule> MovieSchedules { get; set; }

        [Required(ErrorMessage = "Duration is required")]
        public int Duration { get; set; }

        public Movie()
        {
            MovieSchedules=new List<MovieSchedule>();
        }
    }


}
