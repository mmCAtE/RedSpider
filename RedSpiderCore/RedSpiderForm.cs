using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skyfire.RedSpider
{
    public class RedSpiderForm : Form
    {
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // RedSpiderForm
            // 
            this.ClientSize = new System.Drawing.Size(274, 229);
            this.Name = "RedSpiderForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
        }

        public virtual void RedSpiderInit(List<ConfigEntity> config)
        {

        }
    }
}
