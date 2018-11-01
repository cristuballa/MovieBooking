using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using MovieBookingSytem.Core.Domain;
using MovieBookingSytem.Core.Repositories;

namespace MovieBookingSytem.Persistence.Repositories
{
   public class MovieScheduleRepository : Repository<MovieSchedule>, IMovieScheduleRepository
    {
        public MovieScheduleRepository(MovieBookingContext context)
            :base(context)
        {
            
        }
        //Get List of Schedule
        public IEnumerable<MovieSchedule> GetMovieScheduleList(int id )
        {

            return MovieBookingContext.MovieSchedules.SqlQuery("MovieScheduleList @MovieId",
                new SqlParameter("MovieId", SqlDbType.Int) { Value = id }).ToList();


            //return (from p in MovieBookingContext.MovieSchedules.Include("Cinema")
            //        where p.MovieId == id
            //        orderby p.Id
            //        select p).ToList();

        }
        //Get DbContext
        public MovieBookingContext MovieBookingContext
        {
            get { return Context as MovieBookingContext; }
        }


    }
}
