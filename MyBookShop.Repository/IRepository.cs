using DapperExtensions;
using MyBookShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyBookShop.Repository
{
    public interface IRepository<T, TKey> : IDependcy where T : BaseModel<TKey>, new()
    {
        TKey Add(T entity);

        bool Remove(T entity);

        bool Update(T entity);

        IEnumerable<T> GetAll();

        IEnumerable<T> GetList(object param);

        T Find(TKey key);

        IEnumerable<T> GetPageList(object where, IList<ISort> sorts, int page, int size);
    }
}
