namespace QLKS
{
    partial class DDV
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
            this.l_MAIN = new System.Windows.Forms.Label();
            this.b_dat = new System.Windows.Forms.Button();
            this.b_huy = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // l_MAIN
            // 
            this.l_MAIN.Dock = System.Windows.Forms.DockStyle.Top;
            this.l_MAIN.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.l_MAIN.ForeColor = System.Drawing.Color.Goldenrod;
            this.l_MAIN.Location = new System.Drawing.Point(0, 0);
            this.l_MAIN.Name = "l_MAIN";
            this.l_MAIN.Size = new System.Drawing.Size(1233, 92);
            this.l_MAIN.TabIndex = 2;
            this.l_MAIN.Text = "ĐẶT DỊCH VỤ";
            this.l_MAIN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // b_dat
            // 
            this.b_dat.BackColor = System.Drawing.Color.Goldenrod;
            this.b_dat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_dat.FlatAppearance.BorderSize = 0;
            this.b_dat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.b_dat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_dat.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.b_dat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.b_dat.Location = new System.Drawing.Point(776, 505);
            this.b_dat.Name = "b_dat";
            this.b_dat.Size = new System.Drawing.Size(200, 50);
            this.b_dat.TabIndex = 37;
            this.b_dat.Text = "Đặt";
            this.b_dat.UseVisualStyleBackColor = false;
            this.b_dat.Click += new System.EventHandler(this.b_dat_Click);
            // 
            // b_huy
            // 
            this.b_huy.BackColor = System.Drawing.Color.Goldenrod;
            this.b_huy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_huy.FlatAppearance.BorderSize = 0;
            this.b_huy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.b_huy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_huy.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.b_huy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.b_huy.Location = new System.Drawing.Point(212, 505);
            this.b_huy.Name = "b_huy";
            this.b_huy.Size = new System.Drawing.Size(200, 50);
            this.b_huy.TabIndex = 36;
            this.b_huy.Text = "Hủy";
            this.b_huy.UseVisualStyleBackColor = false;
            this.b_huy.Click += new System.EventHandler(this.b_huy_Click);
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(212, 122);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(764, 316);
            this.dgv.TabIndex = 38;
            // 
            // DDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1233, 770);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.b_dat);
            this.Controls.Add(this.b_huy);
            this.Controls.Add(this.l_MAIN);
            this.Name = "DDV";
            this.Text = "DDV";
            this.Load += new System.EventHandler(this.DDV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label l_MAIN;
        private System.Windows.Forms.Button b_dat;
        private System.Windows.Forms.Button b_huy;
        private System.Windows.Forms.DataGridView dgv;
    }
}