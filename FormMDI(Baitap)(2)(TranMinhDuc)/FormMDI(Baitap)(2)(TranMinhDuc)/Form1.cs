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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "admin" && txtPass.Text == "4444") 
            {
                label2.Text = "";
                Trangchu tc = new Trangchu();
                tc.Show();
                this.Hide();
            }else
            {
                label2.Text = "Tài khoản hoặc pass bị lỗi";
            }
        }
    }
}
