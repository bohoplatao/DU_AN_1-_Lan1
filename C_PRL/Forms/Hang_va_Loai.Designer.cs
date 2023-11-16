namespace C_PRL.Forms
{
    partial class Hang_va_Loai
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
            this.bt_TheLoai = new System.Windows.Forms.Button();
            this.bt_HangSX = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // bt_TheLoai
            // 
            this.bt_TheLoai.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_TheLoai.Location = new System.Drawing.Point(427, 88);
            this.bt_TheLoai.Name = "bt_TheLoai";
            this.bt_TheLoai.Size = new System.Drawing.Size(356, 63);
            this.bt_TheLoai.TabIndex = 12;
            this.bt_TheLoai.Text = "Thể Loại";
            this.bt_TheLoai.UseVisualStyleBackColor = true;
            this.bt_TheLoai.Click += new System.EventHandler(this.bt_TheLoai_Click);
            // 
            // bt_HangSX
            // 
            this.bt_HangSX.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_HangSX.Location = new System.Drawing.Point(55, 88);
            this.bt_HangSX.Name = "bt_HangSX";
            this.bt_HangSX.Size = new System.Drawing.Size(356, 63);
            this.bt_HangSX.TabIndex = 11;
            this.bt_HangSX.Text = "Nhà Cung Cấp";
            this.bt_HangSX.UseVisualStyleBackColor = true;
            this.bt_HangSX.Click += new System.EventHandler(this.bt_HangSX_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(177, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(488, 54);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nhà Cung Cấp - Thể Loại";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(7, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 499);
            this.panel1.TabIndex = 13;
            // 
            // Hang_va_Loai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 660);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_TheLoai);
            this.Controls.Add(this.bt_HangSX);
            this.Controls.Add(this.label1);
            this.Name = "Hang_va_Loai";
            this.Text = "Hang_va_Loai";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button bt_TheLoai;
        private Button bt_HangSX;
        private Label label1;
        private Panel panel1;
    }
}