using DapperExtensions;
using MyBookShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyBookShop.Service.Interface
{
    public interface ICustomerMessageService
    {
        void Add(CustomerMessage message);

        IEnumerable<CustomerMessage> GetPageList(object where, IList<ISort> sorts, int page, int size);

        IEnumerable<CustomerMessage> GetList(object param);

        CustomerMessage GetMessage(int id);

        IEnumerable<CustomerMessage> GetAll();
    }
}
