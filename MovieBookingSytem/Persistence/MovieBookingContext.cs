using System.Data.Entity;
using MovieBookingSytem.Core.Domain;

namespace MovieBookingSytem.Persistence
{
   public class MovieBookingContext : DbContext
    {


        public MovieBookingContext()
            :base("name=MovieBookingContext")
        {
            Configuration.LazyLoadingEnabled = false;
        }

        //set DbSet of class Movie to Movies
        public virtual DbSet<Movie> Movies { get; set; }
        //set DbSet of class Cinema to Cinemas
        public virtual DbSet<Cinema> Cinemas { get; set; }
        //set DbSet of class MovieSchedule to MovieSchedules
        public virtual DbSet<MovieSchedule> MovieSchedules { get; set; }
        public virtual DbSet<Watchlist> Watchlist { get; set; }


    }
}
