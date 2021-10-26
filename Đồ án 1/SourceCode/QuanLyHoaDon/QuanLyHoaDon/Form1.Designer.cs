
namespace QuanLyHoaDon
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonThongKe = new System.Windows.Forms.Button();
            this.buttonXemHD = new System.Windows.Forms.Button();
            this.buttonThemHD = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 27);
            this.panel1.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(190, 20);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Phần mềm quản lý hóa đơn";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel2.Controls.Add(this.buttonThongKe);
            this.panel2.Controls.Add(this.buttonXemHD);
            this.panel2.Controls.Add(this.buttonThemHD);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(862, 60);
            this.panel2.TabIndex = 1;
            // 
            // buttonThongKe
            // 
            this.buttonThongKe.Location = new System.Drawing.Point(553, 7);
            this.buttonThongKe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonThongKe.Name = "buttonThongKe";
            this.buttonThongKe.Size = new System.Drawing.Size(184, 45);
            this.buttonThongKe.TabIndex = 2;
            this.buttonThongKe.Text = "Thống Kê";
            this.buttonThongKe.UseVisualStyleBackColor = true;
            this.buttonThongKe.Click += new System.EventHandler(this.buttonThongKe_Click);
            // 
            // buttonXemHD
            // 
            this.buttonXemHD.Location = new System.Drawing.Point(66, 8);
            this.buttonXemHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonXemHD.Name = "buttonXemHD";
            this.buttonXemHD.Size = new System.Drawing.Size(175, 45);
            this.buttonXemHD.TabIndex = 1;
            this.buttonXemHD.Text = "Xem Hóa Đơn";
            this.buttonXemHD.UseVisualStyleBackColor = true;
            this.buttonXemHD.Click += new System.EventHandler(this.buttonXemHD_Click);
            // 
            // buttonThemHD
            // 
            this.buttonThemHD.Location = new System.Drawing.Point(310, 8);
            this.buttonThemHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonThemHD.Name = "buttonThemHD";
            this.buttonThemHD.Size = new System.Drawing.Size(184, 45);
            this.buttonThemHD.TabIndex = 0;
            this.buttonThemHD.Text = "Thêm Hóa Đơn";
            this.buttonThemHD.UseVisualStyleBackColor = true;
            this.buttonThemHD.Click += new System.EventHandler(this.buttonThemHD_Click);
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 87);
            this.panelMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(862, 653);
            this.panelMain.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 740);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonXemHD;
        private System.Windows.Forms.Button buttonThemHD;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonThongKe;
    }
}

