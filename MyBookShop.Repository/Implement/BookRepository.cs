using MyBookShop.Models;
using MyBookShop.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBookShop.Repository.Implement
{
    public class BookRepository : BaseRepository<Book, int>, IBookRepository
    {
        public BookRepository(IDbSession dbSession) : base(dbSession)
        {

        }
    }
}
