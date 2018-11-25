using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBookShop.Repository
{
    public interface IDbSession
    {
        string ConString { get; }

        IDbConnection DbCon { get; }
    }
}
