﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Skyfire.RedSpider;

namespace Test
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            ILoadConfig loader = ConfigLoadFactory.CreateLoadConfigObject(LoadTypes.DEMO);
            loader.Init("", 0, "", "", "");
            List<ConfigEntity> configList = loader.LoadConfig();

            RedSpiderForm form = RedSpiderFactory.CreateRedSpiderForm(SpiderTypes.SINGLE);
            form.RedSpiderInit(configList);
            form.ShowDialog();
        }
    }
}
