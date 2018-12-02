using MyBookShop.Models;
using MyBookShop.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBookShop.Repository.Implement
{
    public class CustomerMessageRepository : BaseRepository<CustomerMessage, int>, ICustomerMessageRepository
    {
        public CustomerMessageRepository(IDbSession dbSession) : base(dbSession)
        {

        }
    }
}
