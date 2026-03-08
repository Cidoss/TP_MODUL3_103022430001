using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_MODUL3_103022430001
{
    public partial class KalkulatorForm : Form
    {
        int angkaPertama = 0;
        int hasil = 0;
        public KalkulatorForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            viewOutput.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            viewOutput.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            viewOutput.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            viewOutput.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            viewOutput.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            viewOutput.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            viewOutput.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            viewOutput.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            viewOutput.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            viewOutput.Text += "0";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            hasil += int.Parse(viewOutput.Text);
            viewOutput.Text = "";
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            hasil += int.Parse(viewOutput.Text);
            viewOutput.Text = hasil.ToString();
            hasil = 0;
        }
    }
}
