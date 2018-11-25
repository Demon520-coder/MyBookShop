using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBookShop.Models
{
    public abstract class BaseModel<TKey>
    {
        public TKey Id { get; set; }

        public DateTime CreateTime { get; set; } = DateTime.Now;

        public bool IsDeleted { get; set; } = false;

        public TKey CreateUserId { get; set; }
    }
}
