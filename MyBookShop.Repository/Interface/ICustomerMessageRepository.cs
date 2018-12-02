using MyBookShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBookShop.Repository.Interface
{
    public interface ICustomerMessageRepository : IRepository<CustomerMessage, int>
    {
    }
}
