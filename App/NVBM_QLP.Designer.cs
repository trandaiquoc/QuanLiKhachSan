namespace QLKS
{
    partial class NVBM_QLP
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
            this.b_ht = new System.Windows.Forms.Button();
            this.tb_md = new System.Windows.Forms.TextBox();
            this.l_md = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.l_MAIN = new System.Windows.Forms.Label();
            this.tb_ten = new System.Windows.Forms.TextBox();
            this.l_kh = new System.Windows.Forms.Label();
            this.tb_p = new System.Windows.Forms.TextBox();
            this.l_p = new System.Windows.Forms.Label();
            this.tb_qd = new System.Windows.Forms.TextBox();
            this.l_qd = new System.Windows.Forms.Label();
            this.cb_vchl = new System.Windows.Forms.CheckBox();
            this.tb_vs = new System.Windows.Forms.TextBox();
            this.l_vs = new System.Windows.Forms.Label();
            this.l_s = new System.Windows.Forms.Label();
            this.cbb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // b_ht
            // 
            this.b_ht.BackColor = System.Drawing.Color.Goldenrod;
            this.b_ht.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_ht.FlatAppearance.BorderSize = 0;
            this.b_ht.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.b_ht.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_ht.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.b_ht.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.b_ht.Location = new System.Drawing.Point(831, 222);
            this.b_ht.Name = "b_ht";
            this.b_ht.Size = new System.Drawing.Size(200, 50);
            this.b_ht.TabIndex = 71;
            this.b_ht.Text = "Hoàn Thành ";
            this.b_ht.UseVisualStyleBackColor = false;
            this.b_ht.Click += new System.EventHandler(this.b_ht_Click);
            // 
            // tb_md
            // 
            this.tb_md.BackColor = System.Drawing.Color.White;
            this.tb_md.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_md.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_md.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tb_md.Location = new System.Drawing.Point(173, 96);
            this.tb_md.Name = "tb_md";
            this.tb_md.Size = new System.Drawing.Size(180, 34);
            this.tb_md.TabIndex = 70;
            // 
            // l_md
            // 
            this.l_md.AutoSize = true;
            this.l_md.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.l_md.ForeColor = System.Drawing.Color.Goldenrod;
            this.l_md.Location = new System.Drawing.Point(73, 102);
            this.l_md.Name = "l_md";
            this.l_md.Size = new System.Drawing.Size(93, 28);
            this.l_md.TabIndex = 69;
            this.l_md.Text = "Mã Phiếu";
            this.l_md.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.dgv.TabIndex = 68;
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
            this.l_MAIN.TabIndex = 67;
            this.l_MAIN.Text = "QUẢN LÝ PHIẾU";
            this.l_MAIN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_ten
            // 
            this.tb_ten.BackColor = System.Drawing.Color.White;
            this.tb_ten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_ten.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_ten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tb_ten.Location = new System.Drawing.Point(173, 136);
            this.tb_ten.Name = "tb_ten";
            this.tb_ten.Size = new System.Drawing.Size(180, 34);
            this.tb_ten.TabIndex = 73;
            // 
            // l_kh
            // 
            this.l_kh.AutoSize = true;
            this.l_kh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.l_kh.ForeColor = System.Drawing.Color.Goldenrod;
            this.l_kh.Location = new System.Drawing.Point(73, 142);
            this.l_kh.Name = "l_kh";
            this.l_kh.Size = new System.Drawing.Size(72, 28);
            this.l_kh.TabIndex = 72;
            this.l_kh.Text = "Tên KH";
            this.l_kh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_p
            // 
            this.tb_p.BackColor = System.Drawing.Color.White;
            this.tb_p.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_p.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_p.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tb_p.Location = new System.Drawing.Point(173, 176);
            this.tb_p.Name = "tb_p";
            this.tb_p.Size = new System.Drawing.Size(180, 34);
            this.tb_p.TabIndex = 75;
            // 
            // l_p
            // 
            this.l_p.AutoSize = true;
            this.l_p.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.l_p.ForeColor = System.Drawing.Color.Goldenrod;
            this.l_p.Location = new System.Drawing.Point(73, 182);
            this.l_p.Name = "l_p";
            this.l_p.Size = new System.Drawing.Size(69, 28);
            this.l_p.TabIndex = 74;
            this.l_p.Text = "Phòng";
            this.l_p.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_qd
            // 
            this.tb_qd.BackColor = System.Drawing.Color.White;
            this.tb_qd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_qd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_qd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tb_qd.Location = new System.Drawing.Point(173, 216);
            this.tb_qd.Name = "tb_qd";
            this.tb_qd.Size = new System.Drawing.Size(180, 34);
            this.tb_qd.TabIndex = 77;
            // 
            // l_qd
            // 
            this.l_qd.AutoSize = true;
            this.l_qd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.l_qd.ForeColor = System.Drawing.Color.Goldenrod;
            this.l_qd.Location = new System.Drawing.Point(73, 222);
            this.l_qd.Name = "l_qd";
            this.l_qd.Size = new System.Drawing.Size(89, 28);
            this.l_qd.TabIndex = 76;
            this.l_qd.Text = "Qui Định";
            this.l_qd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_vchl
            // 
            this.cb_vchl.AutoSize = true;
            this.cb_vchl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cb_vchl.ForeColor = System.Drawing.Color.Goldenrod;
            this.cb_vchl.Location = new System.Drawing.Point(831, 180);
            this.cb_vchl.Name = "cb_vchl";
            this.cb_vchl.Size = new System.Drawing.Size(211, 32);
            this.cb_vchl.TabIndex = 78;
            this.cb_vchl.Text = "Vận Chuyển Hành Lý";
            this.cb_vchl.UseVisualStyleBackColor = true;
            // 
            // tb_vs
            // 
            this.tb_vs.BackColor = System.Drawing.Color.White;
            this.tb_vs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_vs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_vs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tb_vs.Location = new System.Drawing.Point(173, 256);
            this.tb_vs.Name = "tb_vs";
            this.tb_vs.Size = new System.Drawing.Size(180, 34);
            this.tb_vs.TabIndex = 80;
            // 
            // l_vs
            // 
            this.l_vs.AutoSize = true;
            this.l_vs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.l_vs.ForeColor = System.Drawing.Color.Goldenrod;
            this.l_vs.Location = new System.Drawing.Point(73, 262);
            this.l_vs.Name = "l_vs";
            this.l_vs.Size = new System.Drawing.Size(77, 28);
            this.l_vs.TabIndex = 79;
            this.l_vs.Text = "Vệ Sinh";
            this.l_vs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l_s
            // 
            this.l_s.AutoSize = true;
            this.l_s.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.l_s.ForeColor = System.Drawing.Color.Goldenrod;
            this.l_s.Location = new System.Drawing.Point(826, 102);
            this.l_s.Name = "l_s";
            this.l_s.Size = new System.Drawing.Size(200, 28);
            this.l_s.TabIndex = 81;
            this.l_s.Text = "Số Nhân Viên Vệ Sinh";
            this.l_s.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbb
            // 
            this.cbb.BackColor = System.Drawing.Color.White;
            this.cbb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cbb.FormattingEnabled = true;
            this.cbb.Items.AddRange(new object[] {
            "MOMO",
            "BANKING"});
            this.cbb.Location = new System.Drawing.Point(831, 136);
            this.cbb.Name = "cbb";
            this.cbb.Size = new System.Drawing.Size(200, 36);
            this.cbb.TabIndex = 82;
            // 
            // NVBM_QLP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1233, 770);
            this.Controls.Add(this.cbb);
            this.Controls.Add(this.l_s);
            this.Controls.Add(this.tb_vs);
            this.Controls.Add(this.l_vs);
            this.Controls.Add(this.cb_vchl);
            this.Controls.Add(this.tb_qd);
            this.Controls.Add(this.l_qd);
            this.Controls.Add(this.tb_p);
            this.Controls.Add(this.l_p);
            this.Controls.Add(this.tb_ten);
            this.Controls.Add(this.l_kh);
            this.Controls.Add(this.b_ht);
            this.Controls.Add(this.tb_md);
            this.Controls.Add(this.l_md);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.l_MAIN);
            this.Name = "NVBM_QLP";
            this.Text = "NVBM_QLP";
            this.Load += new System.EventHandler(this.NVBM_QLP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_ht;
        private System.Windows.Forms.TextBox tb_md;
        private System.Windows.Forms.Label l_md;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label l_MAIN;
        private System.Windows.Forms.TextBox tb_ten;
        private System.Windows.Forms.Label l_kh;
        private System.Windows.Forms.TextBox tb_p;
        private System.Windows.Forms.Label l_p;
        private System.Windows.Forms.TextBox tb_qd;
        private System.Windows.Forms.Label l_qd;
        private System.Windows.Forms.CheckBox cb_vchl;
        private System.Windows.Forms.TextBox tb_vs;
        private System.Windows.Forms.Label l_vs;
        private System.Windows.Forms.Label l_s;
        private System.Windows.Forms.ComboBox cbb;
    }
}