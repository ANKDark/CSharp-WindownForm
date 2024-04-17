using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkbox_Radiobutton_Baitap_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtShow_TextChanged(object sender, EventArgs e)
        {


        }

        private void chkboxItalic_CheckedChanged(object sender, EventArgs e)
        {
            FontStyle style = FontStyle.Regular;

            if (chkboxBold.Checked)
                style |= FontStyle.Bold;
            if (chkboxItalic.Checked)
                style |= FontStyle.Italic;
            if (chkboxUnderline.Checked)
                style |= FontStyle.Underline;

            txtShow.Font = new Font(txtShow.Font, style);
        }

        private void chkboxUnderline_CheckedChanged(object sender, EventArgs e)
        {
            FontStyle style = FontStyle.Regular;

            if (chkboxBold.Checked)
                style |= FontStyle.Bold;
            if (chkboxItalic.Checked)
                style |= FontStyle.Italic;
            if (chkboxUnderline.Checked)
                style |= FontStyle.Underline;

            txtShow.Font = new Font(txtShow.Font, style);
        }

        private void chkboxBold_CheckedChanged(object sender, EventArgs e)
        {
            FontStyle style = FontStyle.Regular;

            if (chkboxBold.Checked)
                style |= FontStyle.Bold;
            if (chkboxItalic.Checked)
                style |= FontStyle.Italic;
            if (chkboxUnderline.Checked)
                style |= FontStyle.Underline;

            txtShow.Font = new Font(txtShow.Font, style);
        }

        private void txtShow_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void rdbtnRed_CheckedChanged(object sender, EventArgs e)
        {
            txtShow.ForeColor = Color.Red;
        }

        private void rdbtnBlue_CheckedChanged(object sender, EventArgs e)
        {
            txtShow.ForeColor = Color.Blue;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            txtShow.ForeColor = Color.Green;
        }
    }
}
