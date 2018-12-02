using MyBookShop.Models;
using MyBookShop.Repository.Interface;
using MyBookShop.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBookShop.Service.Implement
{
    public class CartService : ICartService
    {
        private readonly ICartRepository _cartRepository;
            
        public CartService(ICartRepository cartRepository)
        {
            this._cartRepository = cartRepository;
        }
        public void Add(Cart cart)
        {
            _cartRepository.Add(cart);
        }
    }
}
