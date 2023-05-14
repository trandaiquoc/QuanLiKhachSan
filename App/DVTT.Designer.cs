namespace QLKS
{
    partial class DVTT
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
            this.b_dat = new System.Windows.Forms.Button();
            this.tb_lhd = new System.Windows.Forms.TextBox();
            this.l_hd = new System.Windows.Forms.Label();
            this.tb_dv = new System.Windows.Forms.TextBox();
            this.l_dv = new System.Windows.Forms.Label();
            this.b_xn = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
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
            this.b_dat.Location = new System.Drawing.Point(384, 445);
            this.b_dat.Name = "b_dat";
            this.b_dat.Size = new System.Drawing.Size(200, 50);
            this.b_dat.TabIndex = 21;
            this.b_dat.Text = "Đặt";
            this.b_dat.UseVisualStyleBackColor = false;
            this.b_dat.Click += new System.EventHandler(this.b_dat_Click);
            // 
            // tb_lhd
            // 
            this.tb_lhd.BackColor = System.Drawing.Color.White;
            this.tb_lhd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_lhd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_lhd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tb_lhd.Location = new System.Drawing.Point(167, 531);
            this.tb_lhd.Name = "tb_lhd";
            this.tb_lhd.Size = new System.Drawing.Size(180, 34);
            this.tb_lhd.TabIndex = 50;
            // 
            // l_hd
            // 
            this.l_hd.AutoSize = true;
            this.l_hd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.l_hd.ForeColor = System.Drawing.Color.Goldenrod;
            this.l_hd.Location = new System.Drawing.Point(13, 537);
            this.l_hd.Name = "l_hd";
            this.l_hd.Size = new System.Drawing.Size(148, 28);
            this.l_hd.TabIndex = 49;
            this.l_hd.Text = "Lịch Hoạt Động";
            this.l_hd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_dv
            // 
            this.tb_dv.BackColor = System.Drawing.Color.White;
            this.tb_dv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_dv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_dv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tb_dv.Location = new System.Drawing.Point(167, 454);
            this.tb_dv.Name = "tb_dv";
            this.tb_dv.Size = new System.Drawing.Size(180, 34);
            this.tb_dv.TabIndex = 48;
            // 
            // l_dv
            // 
            this.l_dv.AutoSize = true;
            this.l_dv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.l_dv.ForeColor = System.Drawing.Color.Goldenrod;
            this.l_dv.Location = new System.Drawing.Point(13, 456);
            this.l_dv.Name = "l_dv";
            this.l_dv.Size = new System.Drawing.Size(79, 28);
            this.l_dv.TabIndex = 47;
            this.l_dv.Text = "Dịch Vụ";
            this.l_dv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.b_xn.Location = new System.Drawing.Point(384, 522);
            this.b_xn.Name = "b_xn";
            this.b_xn.Size = new System.Drawing.Size(200, 50);
            this.b_xn.TabIndex = 51;
            this.b_xn.Text = "Xác nhận đơn";
            this.b_xn.UseVisualStyleBackColor = false;
            this.b_xn.Click += new System.EventHandler(this.b_xn_Click);
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(596, 317);
            this.dgv.TabIndex = 52;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // DVTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(596, 631);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.b_xn);
            this.Controls.Add(this.tb_lhd);
            this.Controls.Add(this.l_hd);
            this.Controls.Add(this.tb_dv);
            this.Controls.Add(this.l_dv);
            this.Controls.Add(this.b_dat);
            this.Name = "DVTT";
            this.Text = "DVTT";
            this.Load += new System.EventHandler(this.DVTT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button b_dat;
        private System.Windows.Forms.TextBox tb_lhd;
        private System.Windows.Forms.Label l_hd;
        private System.Windows.Forms.TextBox tb_dv;
        private System.Windows.Forms.Label l_dv;
        private System.Windows.Forms.Button b_xn;
        private System.Windows.Forms.DataGridView dgv;
    }
}