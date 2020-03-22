using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module2_Bai10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            switch(e.Button)
            {
                case MouseButtons.Left:
                    System.Diagnostics.Process.Start("https://www.youtube.com/");
                    break;
                case MouseButtons.Right:
                    MessageBox.Show("Right Click");
                    break;
                case MouseButtons.Middle:
                    MessageBox.Show("Middle Click", "Title", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                    break;
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    System.Diagnostics.Process.Start("C:\\Windows\\system32\\calc.exe");
                    break;
                case MouseButtons.Right:
                    MessageBox.Show("Right Click");
                    break;
                case MouseButtons.Middle:
                    MessageBox.Show("Middle Click", "Title", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                    break;
            }
        }
        private LinkLabel linkTeo;

        private void Form1_Load(object sender, EventArgs e)
        {
            linkTeo = new LinkLabel();
            //set location for linklabel
            linkTeo.Location = new System.Drawing.Point(100, 100);
            //Set the text for linklabel
            linkTeo.Text = "http://hieu.wordpress.com";
            //Add the controls to the form
            this.Controls.Add(linkTeo);
            //Add an event at runtime
            linkTeo.LinkClicked += linkTeo_Clicked;
        }
        private void linkTeo_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (sender is LinkLabel)
                MessageBox.Show(((LinkLabel)sender).Text);
            MessageBox.Show("Add event at runtime");
        }

    }
}
