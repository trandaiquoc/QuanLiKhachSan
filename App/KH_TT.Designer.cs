namespace QLKS
{
    partial class KH_TT
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.b_thanhtoan = new System.Windows.Forms.Button();
            this.l_httt = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cbb_httt = new System.Windows.Forms.ComboBox();
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
            this.l_MAIN.TabIndex = 1;
            this.l_MAIN.Text = "THANH TOÁN";
            this.l_MAIN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(55, 147);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(616, 567);
            this.dgv.TabIndex = 41;
            // 
            // b_thanhtoan
            // 
            this.b_thanhtoan.BackColor = System.Drawing.Color.Goldenrod;
            this.b_thanhtoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_thanhtoan.FlatAppearance.BorderSize = 0;
            this.b_thanhtoan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.b_thanhtoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_thanhtoan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.b_thanhtoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.b_thanhtoan.Location = new System.Drawing.Point(878, 440);
            this.b_thanhtoan.Name = "b_thanhtoan";
            this.b_thanhtoan.Size = new System.Drawing.Size(200, 50);
            this.b_thanhtoan.TabIndex = 40;
            this.b_thanhtoan.Text = "Thanh Toán";
            this.b_thanhtoan.UseVisualStyleBackColor = false;
            this.b_thanhtoan.Click += new System.EventHandler(this.b_thanhtoan_Click);
            // 
            // l_httt
            // 
            this.l_httt.AutoSize = true;
            this.l_httt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.l_httt.ForeColor = System.Drawing.Color.Goldenrod;
            this.l_httt.Location = new System.Drawing.Point(874, 367);
            this.l_httt.Name = "l_httt";
            this.l_httt.Size = new System.Drawing.Size(204, 28);
            this.l_httt.TabIndex = 42;
            this.l_httt.Text = "Hình Thức Thanh Toán";
            this.l_httt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbb_httt
            // 
            this.cbb_httt.BackColor = System.Drawing.Color.White;
            this.cbb_httt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb_httt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbb_httt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cbb_httt.FormattingEnabled = true;
            this.cbb_httt.Items.AddRange(new object[] {
            "MOMO",
            "BANKING"});
            this.cbb_httt.Location = new System.Drawing.Point(878, 398);
            this.cbb_httt.Name = "cbb_httt";
            this.cbb_httt.Size = new System.Drawing.Size(200, 36);
            this.cbb_httt.TabIndex = 43;
            // 
            // KH_TT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1233, 770);
            this.Controls.Add(this.cbb_httt);
            this.Controls.Add(this.l_httt);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.b_thanhtoan);
            this.Controls.Add(this.l_MAIN);
            this.Name = "KH_TT";
            this.Text = "KH_TT";
            this.Load += new System.EventHandler(this.KH_TT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_MAIN;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button b_thanhtoan;
        private System.Windows.Forms.Label l_httt;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cbb_httt;
    }
}