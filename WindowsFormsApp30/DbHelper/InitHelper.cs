using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbHelper
{
    public class InitHelper
    {
        private static InitHelper _init;
        private static ISqlHelper _sqlHelper { get; set; }
        private InitHelper() { }

        public static ISqlHelper GetSqlHelper() {
            return _sqlHelper;
        }

        public static ISqlHelper GetSqlHelper(String url)
        {
            if (_init == null)
            {
                lock (typeof(ISqlHelper))
                {
                    if (_init == null)
                    {
                        _sqlHelper = new SqlHelper(url);
                    }
                }
            }
            return _sqlHelper;
        }
    }
}
