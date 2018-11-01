using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using MovieBookingSytem.Core.Domain;
using MovieBookingSytem.Core.Repositories;

namespace MovieBookingSytem.Persistence.Repositories
{
    public class CinemaRepository: Repository<Cinema>, ICinemaRepository
    {
        public CinemaRepository(MovieBookingContext context)
            : base(context)
        {

        }
        //Get List of Cinema 
        public IEnumerable<Cinema> GetCinemaList(string keyword)
        {
            return MOvieBookingContext.Cinemas.SqlQuery("CinemaListGet @Keyword",
                new SqlParameter("Keyword", SqlDbType.Text) { Value = keyword }).ToList();
        }
        //Get DbContext
        public MovieBookingContext MOvieBookingContext
        {
            get { return Context as MovieBookingContext; }
        }
    }
}
