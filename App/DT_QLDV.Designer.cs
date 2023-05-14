namespace QLKS
{
    partial class DT_QLDV
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
            this.tb_dv = new System.Windows.Forms.TextBox();
            this.l_dv = new System.Windows.Forms.Label();
            this.b_t = new System.Windows.Forms.Button();
            this.tb_sltd = new System.Windows.Forms.TextBox();
            this.l_sltd = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.l_MAIN = new System.Windows.Forms.Label();
            this.tb_dd = new System.Windows.Forms.TextBox();
            this.l_dd = new System.Windows.Forms.Label();
            this.tb_g = new System.Windows.Forms.TextBox();
            this.l_g = new System.Windows.Forms.Label();
            this.tb_t = new System.Windows.Forms.TextBox();
            this.l_t = new System.Windows.Forms.Label();
            this.tb_lhd = new System.Windows.Forms.TextBox();
            this.l_lhd = new System.Windows.Forms.Label();
            this.b_x = new System.Windows.Forms.Button();
            this.b_s = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_dv
            // 
            this.tb_dv.BackColor = System.Drawing.Color.White;
            this.tb_dv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_dv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_dv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tb_dv.Location = new System.Drawing.Point(159, 127);
            this.tb_dv.Name = "tb_dv";
            this.tb_dv.Size = new System.Drawing.Size(180, 34);
            this.tb_dv.TabIndex = 68;
            // 
            // l_dv
            // 
            this.l_dv.AutoSize = true;
            this.l_dv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.l_dv.ForeColor = System.Drawing.Color.Goldenrod;
            this.l_dv.Location = new System.Drawing.Point(59, 135);
            this.l_dv.Name = "l_dv";
            this.l_dv.Size = new System.Drawing.Size(79, 28);
            this.l_dv.TabIndex = 67;
            this.l_dv.Text = "Dịch Vụ";
            this.l_dv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // b_t
            // 
            this.b_t.BackColor = System.Drawing.Color.Goldenrod;
            this.b_t.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_t.FlatAppearance.BorderSize = 0;
            this.b_t.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.b_t.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_t.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.b_t.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.b_t.Location = new System.Drawing.Point(962, 105);
            this.b_t.Name = "b_t";
            this.b_t.Size = new System.Drawing.Size(200, 50);
            this.b_t.TabIndex = 66;
            this.b_t.Text = "Thêm";
            this.b_t.UseVisualStyleBackColor = false;
            this.b_t.Click += new System.EventHandler(this.b_t_Click);
            // 
            // tb_sltd
            // 
            this.tb_sltd.BackColor = System.Drawing.Color.White;
            this.tb_sltd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_sltd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_sltd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tb_sltd.Location = new System.Drawing.Point(554, 133);
            this.tb_sltd.Name = "tb_sltd";
            this.tb_sltd.Size = new System.Drawing.Size(180, 34);
            this.tb_sltd.TabIndex = 65;
            // 
            // l_sltd
            // 
            this.l_sltd.AutoSize = true;
            this.l_sltd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.l_sltd.ForeColor = System.Drawing.Color.Goldenrod;
            this.l_sltd.Location = new System.Drawing.Point(391, 133);
            this.l_sltd.Name = "l_sltd";
            this.l_sltd.Size = new System.Drawing.Size(157, 28);
            this.l_sltd.TabIndex = 64;
            this.l_sltd.Text = "Số Lượng Tối Đa";
            this.l_sltd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv.Location = new System.Drawing.Point(0, 363);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1233, 407);
            this.dgv.TabIndex = 63;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // l_MAIN
            // 
            this.l_MAIN.Dock = System.Windows.Forms.DockStyle.Top;
            this.l_MAIN.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.l_MAIN.ForeColor = System.Drawing.Color.Goldenrod;
            this.l_MAIN.Location = new System.Drawing.Point(0, 0);
            this.l_MAIN.Name = "l_MAIN";
            this.l_MAIN.Size = new System.Drawing.Size(1233, 92);
            this.l_MAIN.TabIndex = 62;
            this.l_MAIN.Text = "QUẢN LÝ DỊCH VỤ";
            this.l_MAIN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_dd
            // 
            this.tb_dd.BackColor = System.Drawing.Color.White;
            this.tb_dd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_dd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_dd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tb_dd.Location = new System.Drawing.Point(159, 240);
            this.tb_dd.Name = "tb_dd";
            this.tb_dd.Size = new System.Drawing.Size(180, 34);
            this.tb_dd.TabIndex = 70;
            // 
            // l_dd
            // 
            this.l_dd.AutoSize = true;
            this.l_dd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.l_dd.ForeColor = System.Drawing.Color.Goldenrod;
            this.l_dd.Location = new System.Drawing.Point(59, 246);
            this.l_dd.Name = "l_dd";
            this.l_dd.Size = new System.Drawing.Size(92, 28);
            this.l_dd.TabIndex = 69;
            this.l_dd.Text = "Địa Điểm";
            this.l_dd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_g
            // 
            this.tb_g.BackColor = System.Drawing.Color.White;
            this.tb_g.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_g.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_g.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tb_g.Location = new System.Drawing.Point(554, 184);
            this.tb_g.Name = "tb_g";
            this.tb_g.Size = new System.Drawing.Size(180, 34);
            this.tb_g.TabIndex = 72;
            // 
            // l_g
            // 
            this.l_g.AutoSize = true;
            this.l_g.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.l_g.ForeColor = System.Drawing.Color.Goldenrod;
            this.l_g.Location = new System.Drawing.Point(391, 190);
            this.l_g.Name = "l_g";
            this.l_g.Size = new System.Drawing.Size(41, 28);
            this.l_g.TabIndex = 71;
            this.l_g.Text = "Giá";
            this.l_g.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_t
            // 
            this.tb_t.BackColor = System.Drawing.Color.White;
            this.tb_t.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_t.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_t.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tb_t.Location = new System.Drawing.Point(159, 184);
            this.tb_t.Name = "tb_t";
            this.tb_t.Size = new System.Drawing.Size(180, 34);
            this.tb_t.TabIndex = 74;
            // 
            // l_t
            // 
            this.l_t.AutoSize = true;
            this.l_t.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.l_t.ForeColor = System.Drawing.Color.Goldenrod;
            this.l_t.Location = new System.Drawing.Point(59, 190);
            this.l_t.Name = "l_t";
            this.l_t.Size = new System.Drawing.Size(41, 28);
            this.l_t.TabIndex = 73;
            this.l_t.Text = "Tên";
            this.l_t.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_lhd
            // 
            this.tb_lhd.BackColor = System.Drawing.Color.White;
            this.tb_lhd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_lhd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_lhd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tb_lhd.Location = new System.Drawing.Point(554, 246);
            this.tb_lhd.Name = "tb_lhd";
            this.tb_lhd.Size = new System.Drawing.Size(180, 34);
            this.tb_lhd.TabIndex = 76;
            // 
            // l_lhd
            // 
            this.l_lhd.AutoSize = true;
            this.l_lhd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.l_lhd.ForeColor = System.Drawing.Color.Goldenrod;
            this.l_lhd.Location = new System.Drawing.Point(400, 246);
            this.l_lhd.Name = "l_lhd";
            this.l_lhd.Size = new System.Drawing.Size(148, 28);
            this.l_lhd.TabIndex = 75;
            this.l_lhd.Text = "Lịch Hoạt Động";
            this.l_lhd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // b_x
            // 
            this.b_x.BackColor = System.Drawing.Color.Goldenrod;
            this.b_x.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_x.FlatAppearance.BorderSize = 0;
            this.b_x.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.b_x.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_x.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.b_x.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.b_x.Location = new System.Drawing.Point(962, 168);
            this.b_x.Name = "b_x";
            this.b_x.Size = new System.Drawing.Size(200, 50);
            this.b_x.TabIndex = 77;
            this.b_x.Text = "Xóa";
            this.b_x.UseVisualStyleBackColor = false;
            this.b_x.Click += new System.EventHandler(this.b_x_Click);
            // 
            // b_s
            // 
            this.b_s.BackColor = System.Drawing.Color.Goldenrod;
            this.b_s.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_s.FlatAppearance.BorderSize = 0;
            this.b_s.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.b_s.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_s.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.b_s.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.b_s.Location = new System.Drawing.Point(962, 234);
            this.b_s.Name = "b_s";
            this.b_s.Size = new System.Drawing.Size(200, 50);
            this.b_s.TabIndex = 78;
            this.b_s.Text = "Sửa";
            this.b_s.UseVisualStyleBackColor = false;
            this.b_s.Click += new System.EventHandler(this.b_s_Click);
            // 
            // DT_QLDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1233, 770);
            this.Controls.Add(this.b_s);
            this.Controls.Add(this.b_x);
            this.Controls.Add(this.tb_lhd);
            this.Controls.Add(this.l_lhd);
            this.Controls.Add(this.tb_t);
            this.Controls.Add(this.l_t);
            this.Controls.Add(this.tb_g);
            this.Controls.Add(this.l_g);
            this.Controls.Add(this.tb_dd);
            this.Controls.Add(this.l_dd);
            this.Controls.Add(this.tb_dv);
            this.Controls.Add(this.l_dv);
            this.Controls.Add(this.b_t);
            this.Controls.Add(this.tb_sltd);
            this.Controls.Add(this.l_sltd);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.l_MAIN);
            this.Name = "DT_QLDV";
            this.Text = "DT_QLDV";
            this.Load += new System.EventHandler(this.DT_QLDV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_dv;
        private System.Windows.Forms.Label l_dv;
        private System.Windows.Forms.Button b_t;
        private System.Windows.Forms.TextBox tb_sltd;
        private System.Windows.Forms.Label l_sltd;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label l_MAIN;
        private System.Windows.Forms.TextBox tb_dd;
        private System.Windows.Forms.Label l_dd;
        private System.Windows.Forms.TextBox tb_g;
        private System.Windows.Forms.Label l_g;
        private System.Windows.Forms.TextBox tb_t;
        private System.Windows.Forms.Label l_t;
        private System.Windows.Forms.TextBox tb_lhd;
        private System.Windows.Forms.Label l_lhd;
        private System.Windows.Forms.Button b_x;
        private System.Windows.Forms.Button b_s;
    }
}