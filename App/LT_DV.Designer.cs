namespace QLKS
{
    partial class LT_DV
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
            this.l_dv = new System.Windows.Forms.Label();
            this.l_mkh = new System.Windows.Forms.Label();
            this.cbb_mkh = new System.Windows.Forms.ComboBox();
            this.b_d = new System.Windows.Forms.Button();
            this.l_MAIN = new System.Windows.Forms.Label();
            this.cbb_dv = new System.Windows.Forms.ComboBox();
            this.panel_body = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // l_dv
            // 
            this.l_dv.AutoSize = true;
            this.l_dv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.l_dv.ForeColor = System.Drawing.Color.Goldenrod;
            this.l_dv.Location = new System.Drawing.Point(29, 205);
            this.l_dv.Name = "l_dv";
            this.l_dv.Size = new System.Drawing.Size(79, 28);
            this.l_dv.TabIndex = 88;
            this.l_dv.Text = "Dịch Vụ";
            this.l_dv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l_mkh
            // 
            this.l_mkh.AutoSize = true;
            this.l_mkh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.l_mkh.ForeColor = System.Drawing.Color.Goldenrod;
            this.l_mkh.Location = new System.Drawing.Point(29, 138);
            this.l_mkh.Name = "l_mkh";
            this.l_mkh.Size = new System.Drawing.Size(150, 28);
            this.l_mkh.TabIndex = 84;
            this.l_mkh.Text = "Mã Khách Hàng";
            this.l_mkh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbb_mkh
            // 
            this.cbb_mkh.BackColor = System.Drawing.Color.White;
            this.cbb_mkh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb_mkh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbb_mkh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cbb_mkh.FormattingEnabled = true;
            this.cbb_mkh.Items.AddRange(new object[] {
            "MOMO",
            "BANKING"});
            this.cbb_mkh.Location = new System.Drawing.Point(185, 141);
            this.cbb_mkh.Name = "cbb_mkh";
            this.cbb_mkh.Size = new System.Drawing.Size(200, 36);
            this.cbb_mkh.TabIndex = 85;
            // 
            // b_d
            // 
            this.b_d.BackColor = System.Drawing.Color.Goldenrod;
            this.b_d.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_d.FlatAppearance.BorderSize = 0;
            this.b_d.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.b_d.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_d.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.b_d.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.b_d.Location = new System.Drawing.Point(185, 263);
            this.b_d.Name = "b_d";
            this.b_d.Size = new System.Drawing.Size(200, 50);
            this.b_d.TabIndex = 82;
            this.b_d.Text = "Đặt";
            this.b_d.UseVisualStyleBackColor = false;
            this.b_d.Click += new System.EventHandler(this.b_d_Click);
            // 
            // l_MAIN
            // 
            this.l_MAIN.Dock = System.Windows.Forms.DockStyle.Top;
            this.l_MAIN.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.l_MAIN.ForeColor = System.Drawing.Color.Goldenrod;
            this.l_MAIN.Location = new System.Drawing.Point(0, 0);
            this.l_MAIN.Name = "l_MAIN";
            this.l_MAIN.Size = new System.Drawing.Size(1233, 92);
            this.l_MAIN.TabIndex = 81;
            this.l_MAIN.Text = "DỊCH VỤ";
            this.l_MAIN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbb_dv
            // 
            this.cbb_dv.BackColor = System.Drawing.SystemColors.Window;
            this.cbb_dv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_dv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb_dv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbb_dv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cbb_dv.FormattingEnabled = true;
            this.cbb_dv.Items.AddRange(new object[] {
            "Dịch Vụ Thông Thường",
            "Dịch Vụ Tour"});
            this.cbb_dv.Location = new System.Drawing.Point(185, 197);
            this.cbb_dv.Name = "cbb_dv";
            this.cbb_dv.Size = new System.Drawing.Size(200, 36);
            this.cbb_dv.TabIndex = 89;
            // 
            // panel_body
            // 
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_body.Location = new System.Drawing.Point(466, 92);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(767, 678);
            this.panel_body.TabIndex = 90;
            // 
            // LT_DV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1233, 770);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.cbb_dv);
            this.Controls.Add(this.l_dv);
            this.Controls.Add(this.l_mkh);
            this.Controls.Add(this.cbb_mkh);
            this.Controls.Add(this.b_d);
            this.Controls.Add(this.l_MAIN);
            this.Name = "LT_DV";
            this.Text = "LT_DV";
            this.Load += new System.EventHandler(this.LT_DV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label l_dv;
        private System.Windows.Forms.Label l_mkh;
        private System.Windows.Forms.ComboBox cbb_mkh;
        private System.Windows.Forms.Button b_d;
        private System.Windows.Forms.Label l_MAIN;
        private System.Windows.Forms.ComboBox cbb_dv;
        private System.Windows.Forms.Panel panel_body;
    }
}