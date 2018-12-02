using DapperExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBookShop.Service.Sorts
{
    public class CustomerMessageSort : ISort
    {
        public string PropertyName
        {
            get;
            set;
        }
        public bool Ascending { get; set; }
    }
}
