using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skyfire.RedSpider
{
    public class ConfigLoadFactory
    {
        public static ILoadConfig CreateLoadConfigObject(LoadTypes type)
        {
            ILoadConfig ilc = null;
            switch(type)
            {
                case LoadTypes.DYNAMIC:
                {
                    break;
                }
                case LoadTypes.DEMO:
                {
                    ilc = new LoadConfigFromDemo();
                    break;
                }
                case LoadTypes.SQLITE:
                {
                    ilc = new LoadconfigFromSqlite();
                    break;
                }
            }
            return ilc;
        }
    }
}
