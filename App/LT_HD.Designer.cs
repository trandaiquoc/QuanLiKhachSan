namespace QLKS
{
    partial class LT_HD
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.b_search = new System.Windows.Forms.Button();
            this.l_MAIN = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.l_mkh = new System.Windows.Forms.Label();
            this.b_xn = new System.Windows.Forms.Button();
            this.cbb_mkh = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(86, 239);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1046, 450);
            this.dgv.TabIndex = 46;
            // 
            // b_search
            // 
            this.b_search.BackColor = System.Drawing.Color.Goldenrod;
            this.b_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_search.FlatAppearance.BorderSize = 0;
            this.b_search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.b_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_search.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.b_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.b_search.Location = new System.Drawing.Point(292, 183);
            this.b_search.Name = "b_search";
            this.b_search.Size = new System.Drawing.Size(200, 50);
            this.b_search.TabIndex = 45;
            this.b_search.Text = "Tìm Kiếm";
            this.b_search.UseVisualStyleBackColor = false;
            this.b_search.Click += new System.EventHandler(this.b_search_Click);
            // 
            // l_MAIN
            // 
            this.l_MAIN.Dock = System.Windows.Forms.DockStyle.Top;
            this.l_MAIN.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.l_MAIN.ForeColor = System.Drawing.Color.Goldenrod;
            this.l_MAIN.Location = new System.Drawing.Point(0, 0);
            this.l_MAIN.Name = "l_MAIN";
            this.l_MAIN.Size = new System.Drawing.Size(1233, 92);
            this.l_MAIN.TabIndex = 44;
            this.l_MAIN.Text = "THANH TOÁN";
            this.l_MAIN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l_mkh
            // 
            this.l_mkh.AutoSize = true;
            this.l_mkh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.l_mkh.ForeColor = System.Drawing.Color.Goldenrod;
            this.l_mkh.Location = new System.Drawing.Point(82, 160);
            this.l_mkh.Name = "l_mkh";
            this.l_mkh.Size = new System.Drawing.Size(150, 28);
            this.l_mkh.TabIndex = 50;
            this.l_mkh.Text = "Mã Khách Hàng";
            this.l_mkh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // b_xn
            // 
            this.b_xn.BackColor = System.Drawing.Color.Goldenrod;
            this.b_xn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_xn.FlatAppearance.BorderSize = 0;
            this.b_xn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.b_xn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_xn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.b_xn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.b_xn.Location = new System.Drawing.Point(932, 708);
            this.b_xn.Name = "b_xn";
            this.b_xn.Size = new System.Drawing.Size(200, 50);
            this.b_xn.TabIndex = 49;
            this.b_xn.Text = "Xác Nhận";
            this.b_xn.UseVisualStyleBackColor = false;
            this.b_xn.Click += new System.EventHandler(this.b_xn_Click);
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
            this.cbb_mkh.Location = new System.Drawing.Point(86, 191);
            this.cbb_mkh.Name = "cbb_mkh";
            this.cbb_mkh.Size = new System.Drawing.Size(200, 36);
            this.cbb_mkh.TabIndex = 51;
            // 
            // LT_HD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1233, 770);
            this.Controls.Add(this.l_mkh);
            this.Controls.Add(this.b_xn);
            this.Controls.Add(this.cbb_mkh);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.b_search);
            this.Controls.Add(this.l_MAIN);
            this.Name = "LT_HD";
            this.Text = "LT_HD";
            this.Load += new System.EventHandler(this.LT_HD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button b_search;
        private System.Windows.Forms.Label l_MAIN;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label l_mkh;
        private System.Windows.Forms.Button b_xn;
        private System.Windows.Forms.ComboBox cbb_mkh;
    }
}