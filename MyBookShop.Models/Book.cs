using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBookShop.Models
{
    public class Book : BaseModel<int>
    {
        public string BookName { get; set; }

        public string ISBN { get; set; }

        public string Author { get; set; }

        public decimal Price { get; set; }

        public string Publisher { get; set; }

        public string PublishDate { get; set; }
    }
}
