using MyBookShop.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Dapper;
using DapperExtensions;
using System.Linq;

namespace MyBookShop.Repository
{
    public class BaseRepository<T, TKey> : IRepository<T, TKey> where T : BaseModel<TKey>, new()
    {
        protected IDbSession _dbSession;

        public BaseRepository(IDbSession dbSession)
        {
            _dbSession = dbSession;
            _dbSession.DbCon.Open();
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
                return con.GetList<T>().ToList();
            }
        }

        public IEnumerable<T> GetList(object param)
        {
            using (var con = _dbSession.DbCon)
            {
                
                return con.GetList<T>(param).ToList();
            }
        }

        public IEnumerable<T> GetPageList(object where, IList<ISort> sorts, int page, int size)
        {
            using (var con = _dbSession.DbCon)
            {
                return con.GetPage<T>(where, sorts, page, size);
            }
        }

        public bool Remove(T entity)
        {
            using (var con = _dbSession.DbCon)
            {
                return con.Delete(entity);
            }
        }

        public bool Update(T entity)
        {
            using (var con = _dbSession.DbCon)
            {
                return con.Update(entity);
            }
        }
    }
}
