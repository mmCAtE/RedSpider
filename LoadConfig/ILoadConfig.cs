using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skyfire.RedSpider
{
    public interface ILoadConfig
    {
        void Init(String host, int port, String db, String user, String secret);
        List<ConfigEntity> LoadConfig();
    }
}
