using System;
using System.Collections.Generic;
using MovieBookingSytem.Core.Domain;

namespace MovieBookingSytem.Core.Repositories
{
   public interface ICinemaRepository:IRepository<Cinema>
   {
       IEnumerable<Cinema> GetCinemaList(String keyword);
   }
}
