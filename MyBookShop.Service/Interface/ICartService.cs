using MyBookShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBookShop.Service.Interface
{
    public interface ICartService
    { 
        void Add(Cart cart);
    }
}
