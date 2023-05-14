namespace QLKS
{
    partial class LT_P
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
            this.l_mkh = new System.Windows.Forms.Label();
            this.cbb_mkh = new System.Windows.Forms.ComboBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.b_d = new System.Windows.Forms.Button();
            this.tb_tt = new System.Windows.Forms.TextBox();
            this.tb_p = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.l_tt = new System.Windows.Forms.Label();
            this.tb_vs = new System.Windows.Forms.TextBox();
            this.l_vs = new System.Windows.Forms.Label();
            this.bt_tp = new System.Windows.Forms.Button();
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
            this.l_MAIN.TabIndex = 45;
            this.l_MAIN.Text = "PHÒNG";
            this.l_MAIN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l_mkh
            // 
            this.l_mkh.AutoSize = true;
            this.l_mkh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.l_mkh.ForeColor = System.Drawing.Color.Goldenrod;
            this.l_mkh.Location = new System.Drawing.Point(664, 92);
            this.l_mkh.Name = "l_mkh";
            this.l_mkh.Size = new System.Drawing.Size(150, 28);
            this.l_mkh.TabIndex = 54;
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
            this.cbb_mkh.Location = new System.Drawing.Point(820, 95);
            this.cbb_mkh.Name = "cbb_mkh";
            this.cbb_mkh.Size = new System.Drawing.Size(200, 36);
            this.cbb_mkh.TabIndex = 55;
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgv.Location = new System.Drawing.Point(0, 92);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(636, 678);
            this.dgv.TabIndex = 53;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
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
            this.b_d.Location = new System.Drawing.Point(820, 332);
            this.b_d.Name = "b_d";
            this.b_d.Size = new System.Drawing.Size(200, 50);
            this.b_d.TabIndex = 52;
            this.b_d.Text = "Đặt";
            this.b_d.UseVisualStyleBackColor = false;
            this.b_d.Click += new System.EventHandler(this.b_d_Click);
            // 
            // tb_tt
            // 
            this.tb_tt.BackColor = System.Drawing.Color.White;
            this.tb_tt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_tt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_tt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tb_tt.Location = new System.Drawing.Point(820, 208);
            this.tb_tt.Name = "tb_tt";
            this.tb_tt.Size = new System.Drawing.Size(200, 34);
            this.tb_tt.TabIndex = 75;
            // 
            // tb_p
            // 
            this.tb_p.BackColor = System.Drawing.Color.White;
            this.tb_p.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_p.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_p.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tb_p.Location = new System.Drawing.Point(820, 153);
            this.tb_p.Name = "tb_p";
            this.tb_p.Size = new System.Drawing.Size(200, 34);
            this.tb_p.TabIndex = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(664, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 28);
            this.label1.TabIndex = 76;
            this.label1.Text = "Phòng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l_tt
            // 
            this.l_tt.AutoSize = true;
            this.l_tt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.l_tt.ForeColor = System.Drawing.Color.Goldenrod;
            this.l_tt.Location = new System.Drawing.Point(664, 214);
            this.l_tt.Name = "l_tt";
            this.l_tt.Size = new System.Drawing.Size(102, 28);
            this.l_tt.TabIndex = 74;
            this.l_tt.Text = "Tình Trạng";
            this.l_tt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_vs
            // 
            this.tb_vs.BackColor = System.Drawing.Color.White;
            this.tb_vs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_vs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_vs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tb_vs.Location = new System.Drawing.Point(820, 268);
            this.tb_vs.Name = "tb_vs";
            this.tb_vs.Size = new System.Drawing.Size(200, 34);
            this.tb_vs.TabIndex = 79;
            // 
            // l_vs
            // 
            this.l_vs.AutoSize = true;
            this.l_vs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.l_vs.ForeColor = System.Drawing.Color.Goldenrod;
            this.l_vs.Location = new System.Drawing.Point(664, 274);
            this.l_vs.Name = "l_vs";
            this.l_vs.Size = new System.Drawing.Size(77, 28);
            this.l_vs.TabIndex = 78;
            this.l_vs.Text = "Vệ Sinh";
            this.l_vs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_tp
            // 
            this.bt_tp.BackColor = System.Drawing.Color.Goldenrod;
            this.bt_tp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_tp.FlatAppearance.BorderSize = 0;
            this.bt_tp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.bt_tp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_tp.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bt_tp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bt_tp.Location = new System.Drawing.Point(820, 401);
            this.bt_tp.Name = "bt_tp";
            this.bt_tp.Size = new System.Drawing.Size(200, 50);
            this.bt_tp.TabIndex = 80;
            this.bt_tp.Text = "Khách Trả Phòng";
            this.bt_tp.UseVisualStyleBackColor = false;
            this.bt_tp.Click += new System.EventHandler(this.bt_tp_Click);
            // 
            // LT_P
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1233, 770);
            this.Controls.Add(this.bt_tp);
            this.Controls.Add(this.tb_vs);
            this.Controls.Add(this.l_vs);
            this.Controls.Add(this.tb_p);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_tt);
            this.Controls.Add(this.l_tt);
            this.Controls.Add(this.l_mkh);
            this.Controls.Add(this.cbb_mkh);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.b_d);
            this.Controls.Add(this.l_MAIN);
            this.Name = "LT_P";
            this.Text = "LT_DP";
            this.Load += new System.EventHandler(this.LT_P_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_MAIN;
        private System.Windows.Forms.Label l_mkh;
        private System.Windows.Forms.ComboBox cbb_mkh;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button b_d;
        private System.Windows.Forms.TextBox tb_tt;
        private System.Windows.Forms.TextBox tb_p;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l_tt;
        private System.Windows.Forms.TextBox tb_vs;
        private System.Windows.Forms.Label l_vs;
        private System.Windows.Forms.Button bt_tp;
    }
}