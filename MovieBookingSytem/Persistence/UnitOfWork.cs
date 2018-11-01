using MovieBookingSytem.Core;
using MovieBookingSytem.Core.Repositories;
using MovieBookingSytem.Persistence.Repositories;
using System.Data.Entity.Validation;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MovieBookingSytem.Persistence

{
    public class UnitOfWork:IUnitOfWork
    {

        private readonly MovieBookingContext _context;

        public UnitOfWork(MovieBookingContext context)
        {
            //Dependency Injection
            _context = context;
            //create an instance of the repositories
            Movies = new MovieRepository(_context);
            Cinemas = new CinemaRepository(_context);
            MovieSchedules = new MovieScheduleRepository(_context);
        }

        public IMovieRepository Movies { get; private set; }
        public ICinemaRepository Cinemas { get; private set; }
        public IMovieScheduleRepository MovieSchedules { get; private set; }

        //Save object to the databse and validation
        public int Complete()
        {
            try
            {
                 return  _context.SaveChanges();
               
            }
            catch (DbEntityValidationException ex)
            {
                // Retrieve the error messages as a list of strings.
                var errorMessages = ex.EntityValidationErrors.SelectMany(x => x.ValidationErrors).Select(x => x.ErrorMessage);

                // Join the list to a single string.
                var fullErrorMessage = string.Join("; ", errorMessages);

                // Combine the original exception message with the new one.
                var exceptionMessage = string.Concat(ex.Message, " The validation error/s: ", fullErrorMessage);

                // Throw a new DbEntityValidationException with the improved exception message.
                MessageBox.Show(exceptionMessage);

                return 0;
                
            }
        }

        public void Dispose()
        {
            //Dispose DBContext
            _context.Dispose();
        }


    }
}