namespace Module2_Bai7
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.picOn = new System.Windows.Forms.PictureBox();
            this.picOff = new System.Windows.Forms.PictureBox();
            this.lblHienThi = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOff)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtName.Location = new System.Drawing.Point(73, 24);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(193, 27);
            this.txtName.TabIndex = 1;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picOn
            // 
            this.picOn.Image = global::Module2_Bai7.Properties.Resources.unnamed;
            this.picOn.Location = new System.Drawing.Point(111, 81);
            this.picOn.Name = "picOn";
            this.picOn.Size = new System.Drawing.Size(126, 143);
            this.picOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOn.TabIndex = 3;
            this.picOn.TabStop = false;
            this.toolTip1.SetToolTip(this.picOn, "Click me to Turn Off The Light");
            this.picOn.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // picOff
            // 
            this.picOff.Image = global::Module2_Bai7.Properties.Resources.den_350;
            this.picOff.Location = new System.Drawing.Point(111, 81);
            this.picOff.Name = "picOff";
            this.picOff.Size = new System.Drawing.Size(126, 143);
            this.picOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOff.TabIndex = 2;
            this.picOff.TabStop = false;
            this.toolTip1.SetToolTip(this.picOff, "Click me to Turn On The Light");
            this.picOff.Visible = false;
            this.picOff.Click += new System.EventHandler(this.picOff_Click);
            // 
            // lblHienThi
            // 
            this.lblHienThi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHienThi.Location = new System.Drawing.Point(45, 241);
            this.lblHienThi.Name = "lblHienThi";
            this.lblHienThi.Size = new System.Drawing.Size(268, 28);
            this.lblHienThi.TabIndex = 4;
            this.lblHienThi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblHienThi, "Click Me");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Designed by: Hieu";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(274, 284);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 39);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 324);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHienThi);
            this.Controls.Add(this.picOn);
            this.Controls.Add(this.picOff);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.PictureBox picOff;
        private System.Windows.Forms.PictureBox picOn;
        private System.Windows.Forms.Label lblHienThi;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
    }
}

