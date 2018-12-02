using DapperExtensions;
using MyBookShop.Models;
using MyBookShop.Repository.Interface;
using MyBookShop.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyBookShop.Service.Implement
{
    public class CustomerMessageService : ICustomerMessageService
    {
        private readonly ICustomerMessageRepository _customerMessageRepository;

        public CustomerMessageService(ICustomerMessageRepository customerMessageRepository)
        {
            this._customerMessageRepository = customerMessageRepository;
        }

        public void Add(CustomerMessage message)
        {
            _customerMessageRepository.Add(message);
        }

        public IEnumerable<CustomerMessage> GetAll()
        {
            return _customerMessageRepository.GetAll();
        }

        public IEnumerable<CustomerMessage> GetList(object param)
        {
            
            return _customerMessageRepository.GetList(param);
        }

        public CustomerMessage GetMessage(int id)
        {
            return _customerMessageRepository.Find(id);
        }

        public IEnumerable<CustomerMessage> GetPageList(object where, IList<ISort> sorts, int page, int size)
        {
            return _customerMessageRepository.GetPageList(where, sorts, page, size);
        }
    }
}
