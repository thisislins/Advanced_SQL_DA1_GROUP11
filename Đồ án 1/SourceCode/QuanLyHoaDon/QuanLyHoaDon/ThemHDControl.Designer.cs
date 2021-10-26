
namespace QuanLyHoaDon
{
    partial class ThemHDControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMaKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerNgay = new System.Windows.Forms.DateTimePicker();
            this.buttonTaoHD = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMaHD = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(237, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(269, 38);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Thêm hóa đơn mới";
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(92, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã khách hàng:";
            // 
            // textBoxMaKH
            // 
            this.textBoxMaKH.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMaKH.Location = new System.Drawing.Point(92, 171);
            this.textBoxMaKH.Name = "textBoxMaKH";
            this.textBoxMaKH.Size = new System.Drawing.Size(492, 39);
            this.textBoxMaKH.TabIndex = 2;
            this.textBoxMaKH.TextChanged += new System.EventHandler(this.textBoxMaKH_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(92, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày lập hóa đơn:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateTimePickerNgay
            // 
            this.dateTimePickerNgay.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgay.Location = new System.Drawing.Point(92, 276);
            this.dateTimePickerNgay.MaxDate = new System.DateTime(2021, 10, 26, 0, 0, 0, 0);
            this.dateTimePickerNgay.MinDate = new System.DateTime(2020, 5, 1, 0, 0, 0, 0);
            this.dateTimePickerNgay.Name = "dateTimePickerNgay";
            this.dateTimePickerNgay.Size = new System.Drawing.Size(492, 39);
            this.dateTimePickerNgay.TabIndex = 4;
            this.dateTimePickerNgay.Value = new System.DateTime(2021, 10, 26, 0, 0, 0, 0);
            // 
            // buttonTaoHD
            // 
            this.buttonTaoHD.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonTaoHD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonTaoHD.Location = new System.Drawing.Point(285, 336);
            this.buttonTaoHD.Name = "buttonTaoHD";
            this.buttonTaoHD.Size = new System.Drawing.Size(146, 44);
            this.buttonTaoHD.TabIndex = 5;
            this.buttonTaoHD.Text = "Tạo hóa đơn";
            this.buttonTaoHD.UseVisualStyleBackColor = false;
            this.buttonTaoHD.Click += new System.EventHandler(this.buttonTaoHD_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(92, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã hóa đơn:";
            // 
            // textBoxMaHD
            // 
            this.textBoxMaHD.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMaHD.Location = new System.Drawing.Point(92, 82);
            this.textBoxMaHD.Name = "textBoxMaHD";
            this.textBoxMaHD.Size = new System.Drawing.Size(492, 39);
            this.textBoxMaHD.TabIndex = 7;
            // 
            // ThemHDControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonTaoHD);
            this.Controls.Add(this.textBoxMaHD);
            this.Controls.Add(this.dateTimePickerNgay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxMaKH);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ThemHDControl";
            this.Size = new System.Drawing.Size(760, 613);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMaKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgay;
        private System.Windows.Forms.Button buttonTaoHD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMaHD;
    }
}
