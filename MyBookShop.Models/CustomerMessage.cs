using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBookShop.Models
{
    public class CustomerMessage : BaseModel<int>
    {
        public string CustomerName { get; set; }

        public string Title { get; set; }

        public string Email { get; set; }

        public string Msg { get; set; }
    }
}
