using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skyfire.RedSpider
{
    public class RedSpiderFactory
    {
        public static RedSpiderForm CreateRedSpiderForm(SpiderTypes type)
        {
            RedSpiderForm form = null;
            switch(type)
            {
                case SpiderTypes.SINGLE:
                {
                    form = new RedSpiderSingleForm();
                    break;
                }
                case SpiderTypes.MULTI:
                {
                    form = new RedSpiderMultiForm();
                    break;
                }
                case SpiderTypes.MDI:
                {
                    form = new RedSpiderMdiForm();
                    break;
                }
            }

            return form;
        }
    }
}
