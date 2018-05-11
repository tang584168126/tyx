using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyComputer
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void 大图标ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.lvList.View = View.LargeIcon;
        }

        private void 小图标ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.lvList.View = View.SmallIcon;
        }

        private void 列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.lvList.View = View.List;
        }

        private void 详细列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.lvList.View = View.Details;
        }
    }
}
