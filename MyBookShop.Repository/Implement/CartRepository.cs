using MyBookShop.Models;
using MyBookShop.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBookShop.Repository.Implement
{
    public class CartRepository : BaseRepository<Cart, int>, ICartRepository
    {
        public CartRepository(IDbSession dbSession) : base(dbSession)
        {

        }
    }
}
