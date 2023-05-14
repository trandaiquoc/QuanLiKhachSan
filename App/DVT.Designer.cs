namespace QLKS
{
    partial class DVT
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
            this.b_xn = new System.Windows.Forms.Button();
            this.tb_lhd = new System.Windows.Forms.TextBox();
            this.l_hd = new System.Windows.Forms.Label();
            this.tb_dv = new System.Windows.Forms.TextBox();
            this.l_dv = new System.Windows.Forms.Label();
            this.b_dat = new System.Windows.Forms.Button();
            this.tb_songuoi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_vc = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
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
            this.dgv.TabIndex = 59;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
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
            this.b_xn.Location = new System.Drawing.Point(384, 551);
            this.b_xn.Name = "b_xn";
            this.b_xn.Size = new System.Drawing.Size(200, 50);
            this.b_xn.TabIndex = 58;
            this.b_xn.Text = "Xác nhận đơn";
            this.b_xn.UseVisualStyleBackColor = false;
            this.b_xn.Click += new System.EventHandler(this.b_xn_Click);
            // 
            // tb_lhd
            // 
            this.tb_lhd.BackColor = System.Drawing.Color.White;
            this.tb_lhd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_lhd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_lhd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tb_lhd.Location = new System.Drawing.Point(172, 421);
            this.tb_lhd.Name = "tb_lhd";
            this.tb_lhd.Size = new System.Drawing.Size(180, 34);
            this.tb_lhd.TabIndex = 57;
            // 
            // l_hd
            // 
            this.l_hd.AutoSize = true;
            this.l_hd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.l_hd.ForeColor = System.Drawing.Color.Goldenrod;
            this.l_hd.Location = new System.Drawing.Point(18, 427);
            this.l_hd.Name = "l_hd";
            this.l_hd.Size = new System.Drawing.Size(148, 28);
            this.l_hd.TabIndex = 56;
            this.l_hd.Text = "Lịch Hoạt Động";
            this.l_hd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_dv
            // 
            this.tb_dv.BackColor = System.Drawing.Color.White;
            this.tb_dv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_dv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_dv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tb_dv.Location = new System.Drawing.Point(172, 344);
            this.tb_dv.Name = "tb_dv";
            this.tb_dv.Size = new System.Drawing.Size(180, 34);
            this.tb_dv.TabIndex = 55;
            // 
            // l_dv
            // 
            this.l_dv.AutoSize = true;
            this.l_dv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.l_dv.ForeColor = System.Drawing.Color.Goldenrod;
            this.l_dv.Location = new System.Drawing.Point(18, 346);
            this.l_dv.Name = "l_dv";
            this.l_dv.Size = new System.Drawing.Size(79, 28);
            this.l_dv.TabIndex = 54;
            this.l_dv.Text = "Dịch Vụ";
            this.l_dv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.b_dat.Location = new System.Drawing.Point(384, 474);
            this.b_dat.Name = "b_dat";
            this.b_dat.Size = new System.Drawing.Size(200, 50);
            this.b_dat.TabIndex = 53;
            this.b_dat.Text = "Đặt";
            this.b_dat.UseVisualStyleBackColor = false;
            this.b_dat.Click += new System.EventHandler(this.b_dat_Click);
            // 
            // tb_songuoi
            // 
            this.tb_songuoi.BackColor = System.Drawing.Color.White;
            this.tb_songuoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_songuoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_songuoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tb_songuoi.Location = new System.Drawing.Point(172, 490);
            this.tb_songuoi.Name = "tb_songuoi";
            this.tb_songuoi.Size = new System.Drawing.Size(180, 34);
            this.tb_songuoi.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(18, 496);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 28);
            this.label1.TabIndex = 60;
            this.label1.Text = "Số Người";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(18, 566);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 28);
            this.label2.TabIndex = 62;
            this.label2.Text = "Vận Chuyển";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbb_vc
            // 
            this.cbb_vc.BackColor = System.Drawing.Color.White;
            this.cbb_vc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_vc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb_vc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbb_vc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cbb_vc.FormattingEnabled = true;
            this.cbb_vc.Items.AddRange(new object[] {
            "Có",
            "Không"});
            this.cbb_vc.Location = new System.Drawing.Point(172, 558);
            this.cbb_vc.Name = "cbb_vc";
            this.cbb_vc.Size = new System.Drawing.Size(180, 36);
            this.cbb_vc.TabIndex = 63;
            // 
            // DVT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(596, 631);
            this.Controls.Add(this.cbb_vc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_songuoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.b_xn);
            this.Controls.Add(this.tb_lhd);
            this.Controls.Add(this.l_hd);
            this.Controls.Add(this.tb_dv);
            this.Controls.Add(this.l_dv);
            this.Controls.Add(this.b_dat);
            this.Name = "DVT";
            this.Text = "DVT";
            this.Load += new System.EventHandler(this.DVT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button b_xn;
        private System.Windows.Forms.TextBox tb_lhd;
        private System.Windows.Forms.Label l_hd;
        private System.Windows.Forms.TextBox tb_dv;
        private System.Windows.Forms.Label l_dv;
        private System.Windows.Forms.Button b_dat;
        private System.Windows.Forms.TextBox tb_songuoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_vc;
    }
}