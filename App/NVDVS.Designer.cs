namespace QLKS
{
    partial class NVDVS
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
            this.b_cn = new System.Windows.Forms.Button();
            this.tb_p = new System.Windows.Forms.TextBox();
            this.l_p = new System.Windows.Forms.Label();
            this.tb_ttvs = new System.Windows.Forms.TextBox();
            this.l_ttvs = new System.Windows.Forms.Label();
            this.b_dx = new System.Windows.Forms.Button();
            this.b_t = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // l_MAIN
            // 
            this.l_MAIN.Dock = System.Windows.Forms.DockStyle.Top;
            this.l_MAIN.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.l_MAIN.ForeColor = System.Drawing.Color.Goldenrod;
            this.l_MAIN.Location = new System.Drawing.Point(0, 0);
            this.l_MAIN.Name = "l_MAIN";
            this.l_MAIN.Size = new System.Drawing.Size(1023, 47);
            this.l_MAIN.TabIndex = 50;
            this.l_MAIN.Text = "THÔNG TIN PHÒNG";
            this.l_MAIN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv.Location = new System.Drawing.Point(0, 318);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1023, 255);
            this.dgv.TabIndex = 51;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // b_cn
            // 
            this.b_cn.BackColor = System.Drawing.Color.Goldenrod;
            this.b_cn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_cn.FlatAppearance.BorderSize = 0;
            this.b_cn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.b_cn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_cn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.b_cn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.b_cn.Location = new System.Drawing.Point(694, 91);
            this.b_cn.Name = "b_cn";
            this.b_cn.Size = new System.Drawing.Size(200, 50);
            this.b_cn.TabIndex = 58;
            this.b_cn.Text = "Đã Dọn";
            this.b_cn.UseVisualStyleBackColor = false;
            this.b_cn.Click += new System.EventHandler(this.b_cn_Click);
            // 
            // tb_p
            // 
            this.tb_p.BackColor = System.Drawing.Color.White;
            this.tb_p.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_p.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_p.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tb_p.Location = new System.Drawing.Point(194, 127);
            this.tb_p.Name = "tb_p";
            this.tb_p.Size = new System.Drawing.Size(180, 34);
            this.tb_p.TabIndex = 57;
            // 
            // l_p
            // 
            this.l_p.AutoSize = true;
            this.l_p.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.l_p.ForeColor = System.Drawing.Color.Goldenrod;
            this.l_p.Location = new System.Drawing.Point(16, 129);
            this.l_p.Name = "l_p";
            this.l_p.Size = new System.Drawing.Size(69, 28);
            this.l_p.TabIndex = 56;
            this.l_p.Text = "Phòng";
            this.l_p.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_ttvs
            // 
            this.tb_ttvs.BackColor = System.Drawing.Color.White;
            this.tb_ttvs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_ttvs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_ttvs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tb_ttvs.Location = new System.Drawing.Point(194, 201);
            this.tb_ttvs.Name = "tb_ttvs";
            this.tb_ttvs.Size = new System.Drawing.Size(180, 34);
            this.tb_ttvs.TabIndex = 60;
            // 
            // l_ttvs
            // 
            this.l_ttvs.AutoSize = true;
            this.l_ttvs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.l_ttvs.ForeColor = System.Drawing.Color.Goldenrod;
            this.l_ttvs.Location = new System.Drawing.Point(16, 207);
            this.l_ttvs.Name = "l_ttvs";
            this.l_ttvs.Size = new System.Drawing.Size(172, 28);
            this.l_ttvs.TabIndex = 59;
            this.l_ttvs.Text = "Tình Trạng Vệ Sinh";
            this.l_ttvs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // b_dx
            // 
            this.b_dx.BackColor = System.Drawing.Color.Goldenrod;
            this.b_dx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_dx.FlatAppearance.BorderSize = 0;
            this.b_dx.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.b_dx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_dx.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.b_dx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.b_dx.Location = new System.Drawing.Point(694, 147);
            this.b_dx.Name = "b_dx";
            this.b_dx.Size = new System.Drawing.Size(200, 50);
            this.b_dx.TabIndex = 61;
            this.b_dx.Text = "Đăng Xuất";
            this.b_dx.UseVisualStyleBackColor = false;
            this.b_dx.Click += new System.EventHandler(this.b_dx_Click);
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
            this.b_t.Location = new System.Drawing.Point(694, 203);
            this.b_t.Name = "b_t";
            this.b_t.Size = new System.Drawing.Size(200, 50);
            this.b_t.TabIndex = 62;
            this.b_t.Text = "Thoát";
            this.b_t.UseVisualStyleBackColor = false;
            this.b_t.Click += new System.EventHandler(this.b_t_Click);
            // 
            // NVDVS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1023, 573);
            this.Controls.Add(this.b_t);
            this.Controls.Add(this.b_dx);
            this.Controls.Add(this.tb_ttvs);
            this.Controls.Add(this.l_ttvs);
            this.Controls.Add(this.b_cn);
            this.Controls.Add(this.tb_p);
            this.Controls.Add(this.l_p);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.l_MAIN);
            this.Name = "NVDVS";
            this.Text = "NVDVS";
            this.Load += new System.EventHandler(this.NVDVS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_MAIN;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button b_cn;
        private System.Windows.Forms.TextBox tb_p;
        private System.Windows.Forms.Label l_p;
        private System.Windows.Forms.TextBox tb_ttvs;
        private System.Windows.Forms.Label l_ttvs;
        private System.Windows.Forms.Button b_dx;
        private System.Windows.Forms.Button b_t;
    }
}