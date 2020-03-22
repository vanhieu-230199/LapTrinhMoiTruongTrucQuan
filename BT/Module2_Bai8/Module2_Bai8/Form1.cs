using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module2_Bai8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Button btnRuntime = new Button();
            btnRuntime.Location = new System.Drawing.Point(pnButton.Width / 2 - btnRuntime.Width / 2, pnButton.Controls.Count*btnRuntime.Height);
            btnRuntime.Text = "Element" + pnButton.Controls.Count;
            btnRuntime.Tag = pnButton.Controls.Count;
            btnRuntime.Click += btnRuntime_click;
            pnButton.Controls.Add(btnRuntime);
        }
        private void btnRuntime_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            lblStatus.Text = "Status: Element" + pnButton.Controls.Count + " is clicked.";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Button btnRuntime = new Button();
            pnButton.Controls.RemoveAt(pnButton.Controls.Count - 1);
        }
    }
}
