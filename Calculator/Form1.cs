using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double luutru, luutru2;
        string pheptinh;
        public Form1()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtShow.Text = txtShow.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtShow.Text = txtShow.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtShow.Text = txtShow.Text + "3";
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            txtShow.Text = txtShow.Text + "4";
        }
        private void btn5_Click_1(object sender, EventArgs e)
        {
            txtShow.Text = txtShow.Text + "5";
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            txtShow.Text = txtShow.Text + "6";
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            txtShow.Text = txtShow.Text + "7";
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            txtShow.Text = txtShow.Text + "8";
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            txtShow.Text = txtShow.Text + "9";
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            txtShow.Text = txtShow.Text + "0";
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            if (luutru == 0)
            {
                luutru = double.Parse(txtShow.Text);
            }
            pheptinh = "Cong";
            txtShow.Text = "";
        }
        private void btnPhay_Click(object sender, EventArgs e)
        {
            txtShow.Text = txtShow.Text + ",";
        }
        private void btnclear_Click(object sender, EventArgs e)
        {
            txtShow.Clear();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            if (luutru == 0)
            {
                luutru = double.Parse(txtShow.Text);
            }
            pheptinh = "Tru";
            txtShow.Text = "";
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            if (luutru == 0)
            {
                luutru = double.Parse(txtShow.Text);
            }
            pheptinh = "Nhan";
            txtShow.Text = "";
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            if (luutru == 0)
            {
                luutru = double.Parse(txtShow.Text);
            }
            pheptinh = "Chia";
            txtShow.Text = "";
        }

        private void btnPhantram_Click(object sender, EventArgs e)
        {
            if (luutru == 0)
            {
                luutru = double.Parse(txtShow.Text);
            }
            pheptinh = "%";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtShow.Text = txtShow.Text.Remove(txtShow.Text.Length - 1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtShow_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnbang_Click(object sender, EventArgs e)
        {
            if (pheptinh == "Cong")
            {
                luutru2 = luutru + double.Parse(txtShow.Text);
                txtShow.Text = luutru2.ToString("0.##");
                pheptinh = "";
            }else if (pheptinh == "Tru")
            {
                luutru2 = luutru - double.Parse(txtShow.Text);
                txtShow.Text = luutru2.ToString("0.##");
                pheptinh = "";
            }else if (pheptinh == "Nhan")
            {
                luutru2 = luutru * double.Parse(txtShow.Text);
                txtShow.Text = luutru2.ToString("0.##");
                pheptinh = "";
            }else if (pheptinh == "Chia")
            {
                if (txtShow.Text == "0")
                {
                    txtShow.Text = "Error";
                }else
                {
                    luutru2 = luutru / double.Parse(txtShow.Text);
                    txtShow.Text = luutru2.ToString("0.##");
                    pheptinh = "";
                }
            }else if (pheptinh == "%")
            {
                luutru2 =  double.Parse(txtShow.Text) / 100;
                txtShow.Text = luutru2.ToString("0.##");
                pheptinh = "";
            }
        }
    }
}
