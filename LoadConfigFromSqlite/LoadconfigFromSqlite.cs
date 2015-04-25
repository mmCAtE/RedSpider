using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skyfire.RedSpider
{
    public class LoadconfigFromSqlite : ILoadConfig
    {
        public void Init(String host, int port, String db, String user, String secret)
        {

        }
        public List<ConfigEntity> LoadConfig()
        {
            return null;
        }
    }
}
