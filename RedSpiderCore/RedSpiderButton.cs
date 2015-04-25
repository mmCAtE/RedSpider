using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skyfire.RedSpider
{
    public partial class RedSpiderButton : Button
    {
        public String DllName { get; set; }
        public String ClassName { get; set; }

        public RedSpiderButton()
        {
            InitializeComponent();
        }
    }
}
