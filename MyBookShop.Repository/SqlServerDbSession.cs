using MyBookShop.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBookShop.Repository
{
    public class SqlServerDbSession : IDbSession
    {
        public string ConString => ConfigHelper.GetConnectionByKey("ConString");

        public IDbConnection DbCon => new SqlConnection(ConString);
    }
}
