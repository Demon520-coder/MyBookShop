using DapperExtensions.Mapper;
using MyBookShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBookShop.Models.TableMap
{
    public class CartMap : ClassMapper<Cart>
    {
        public CartMap()
        {
            base.Table("TB_CART");
            AutoMap();
        }
    }
}
