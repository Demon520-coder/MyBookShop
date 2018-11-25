using MyBookShop.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Dapper;
using DapperExtensions;
namespace MyBookShop.Repository
{
    public class BaseRepository<T, TKey> : IRepository<T, TKey> where T : BaseModel<TKey>, new()
    {
        protected IDbSession _dbSession;

        public BaseRepository(IDbSession dbSession)
        {
            _dbSession = dbSession;
        }

        public TKey Add(T entity)
        {
            using (var con = _dbSession.DbCon)
            {
                return con.Insert<T>(entity);
            }
        }

        public T Find(TKey key)
        {
            using (var con = _dbSession.DbCon)
            {
                return con.Get<T>(key);
            }
        }

        public IEnumerable<T> GetAll()
        {
            using (var con = _dbSession.DbCon)
            {
                return con.GetList<T>();
            }
        }

        public IEnumerable<T> GetList<TOrder>(Expression<Func<T, bool>> where, Expression<Func<T, TOrder>> orderLamda)
        {
            using (var con = _dbSession.DbCon)
            {
              return con.GetList<T>(where);
            }
        }

        public bool Remove(T entity)
        {
            using (var con=_dbSession.DbCon)
            {
                return con.Delete(entity);
            }
        }

        public bool Update(T entity)
        {
            using (var con=_dbSession.DbCon)
            {
               return con.Update(entity);
            }
        }
    }
}
