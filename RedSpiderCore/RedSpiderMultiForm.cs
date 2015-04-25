using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skyfire.RedSpider
{
    public partial class RedSpiderMultiForm : RedSpiderForm
    {
        private List<ConfigEntity> _list;
        public RedSpiderMultiForm()
        {
            InitializeComponent();
        }

        public override void RedSpiderInit(List<ConfigEntity> config)
        {
            if(config != null)
            {
                _list = config;
                for (int i = 0; i < _list.Count; i++)
                {
                    RedSpiderButton btn = new RedSpiderButton();
                    btn.Text = _list[i].ButtonText;
                    btn.DllName = _list[i].DllName;
                    btn.ClassName = _list[i].ClassName;
                    btn.Click += btn_Click;
                    flpButton.Controls.Add(btn);
                }
            }
        }

        void btn_Click(object sender, EventArgs e)
        {
            RedSpiderButton btn = (RedSpiderButton)sender;
            Assembly assembly = Assembly.LoadFrom(btn.DllName);
            Type type = assembly.GetType(btn.ClassName);
            Object obj = Activator.CreateInstance(type, null);
            Form form = (Form)obj;
            form.TopLevel = false;
            form.Parent = pnlContent;
            //form.Dock = DockStyle.Fill;
            //form.ControlBox = false;
            form.Show();
        }
    }
}
