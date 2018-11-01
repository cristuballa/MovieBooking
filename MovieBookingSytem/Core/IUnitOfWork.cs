using System;
using System.Threading.Tasks;
using MovieBookingSytem.Core.Repositories;

namespace MovieBookingSytem.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IMovieRepository Movies { get; }
        ICinemaRepository Cinemas { get; }
        IMovieScheduleRepository MovieSchedules { get; }
        int Complete();

    }
}
