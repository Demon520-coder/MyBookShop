using DapperExtensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBookShop.Models
{
    [Table("TB_CART")]
    [Serializable]
    public class Cart : BaseModel<int>
    {
        
        public int BookId { get; set; }

       
        public int Nums { get; set; }
    }
}
