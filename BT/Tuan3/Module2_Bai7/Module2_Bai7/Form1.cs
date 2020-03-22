using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module2_Bai7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtName.Text = "Jack";
            lblHienThi.Text = txtName.Text + "Turn Off The Light, please!";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            picOn.Visible = false;
            picOff.Visible = true;
            lblHienThi.Text = txtName.Text + "Turn On The Light, please!";
        }

        private void picOff_Click(object sender, EventArgs e)
        {
            picOn.Visible = true;
            picOff.Visible = false;
            lblHienThi.Text = txtName.Text + "Turn Off The Light, please!";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
