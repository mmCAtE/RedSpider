using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skyfire.RedSpider
{
    public class LoadConfigFromDemo : ILoadConfig
    {
        public void Init(string host, int port, string db, string user, string secret)
        {
        }

        public List<ConfigEntity> LoadConfig()
        {
            List<ConfigEntity> list = new List<ConfigEntity>();
            int zero = 0;
            for (int i = 0; i < 10;i++)
            {
                switch(i)
                {
                    case 0:
                    case 1:
                    case 4:
                    case 5:
                    case 8:
                    case 9:
                    {
                        zero = 0;
                        break;
                    }
                    case 2:
                    case 3:
                    case 6:
                    case 7:
                    {
                        zero = 1;
                        break;
                    }
                }

                ConfigEntity entity = new ConfigEntity();
                entity.DllName = "TestDll" + zero + ".dll";
                entity.ClassName = "TestDll" + zero + ".TestForm" + (i % 2);
                entity.ButtonText = "按钮" + i;
                list.Add(entity);
            }

            return list;
        }
    }
}
