using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieBookingSytem.Core.Domain;

namespace MovieBookingSytem.Core.Repositories
{
    public interface IMovieScheduleRepository:IRepository<MovieSchedule>
    {
        IEnumerable<MovieSchedule> GetMovieScheduleList(int id);
    }
}
