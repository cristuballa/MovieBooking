using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieBookingSytem.Core.Domain;

namespace MovieBookingSytem.ViewModels
{
    public class MovieScheduleViewModel
    {
        public Movie Movie { get; set; }
        public MovieSchedule MovieSchedule { get; set; }
        public Cinema Cinema { get; set; }

    }
}
