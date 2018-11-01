using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using MovieBookingSytem.Core.Domain;
using MovieBookingSytem.Core.Repositories;
namespace MovieBookingSytem.Persistence.Repositories
{
   public class MovieRepository : Repository<Movie>, IMovieRepository
    {

        public MovieRepository(MovieBookingContext context)
            : base(context)
        {

        }

        //Get List of Movie 
        public IEnumerable<Movie> GetMoviesList(string keyword)
        {
            return MovieBookingContext.Movies.SqlQuery("MoviesListGet @Keyword",
                new SqlParameter("Keyword", SqlDbType.Text) { Value = keyword }).ToList();

        }
        //Get DbContext
        public MovieBookingContext MovieBookingContext
        {
            get { return Context as MovieBookingContext; }
        }

    }



}
