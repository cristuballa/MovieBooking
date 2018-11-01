using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using MovieBookingSytem.Core.Repositories;

namespace MovieBookingSytem.Persistence.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly MovieBookingContext Context;

        public Repository(MovieBookingContext context)
        {
            Context = context;
        }
        //Get specific TEntity object using specific Id
        public TEntity Get(int id)
        {
            return Context.Set<TEntity>().Find(id);
        }

        //Get All TEntity object from the context
        public IEnumerable<TEntity> GetAll()
        {

            return Context.Set<TEntity>().ToList();

        }
       // Add TEntity object 
        public void Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
        }
        // Remove TEntity object 
        public void Remove(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
        }

       //Allow to call stored procedure from sql database
        public DbRawSqlQuery<T> SqlQuery<T>(string sql, params object[] parameters)
        {
            return Context.Database.SqlQuery<T>(sql, parameters);
        }



    }
}
