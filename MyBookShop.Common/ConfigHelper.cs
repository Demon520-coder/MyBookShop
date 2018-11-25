using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBookShop.Common
{
    public class ConfigHelper
    {
        public static string GetAppConfigByKey(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        public static string GetConnectionByKey(string key)
        {
            return ConfigurationManager.ConnectionStrings[key].ConnectionString;
        }
    }
}
