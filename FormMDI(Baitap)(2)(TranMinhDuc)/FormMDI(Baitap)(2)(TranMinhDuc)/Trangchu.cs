using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMDI_Baitap__2__TranMinhDuc_
{
    public partial class Trangchu : Form
    {
        public Trangchu()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nhanvien nv = new Nhanvien();
            nv.MdiParent = this;
            nv.Show();
        }

        private void phòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Phongban pb = new Phongban();
            pb.MdiParent = this;
            pb.Show();
        }
    }
}
