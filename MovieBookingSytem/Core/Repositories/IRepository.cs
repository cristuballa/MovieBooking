using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq.Expressions;

namespace MovieBookingSytem.Core.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Get(int id);

        IEnumerable<TEntity> GetAll();


        DbRawSqlQuery<T> SqlQuery<T>(string sql, params object[] parameters);
   

        void Add(TEntity entity);


        void Remove(TEntity entity);



    }
}
