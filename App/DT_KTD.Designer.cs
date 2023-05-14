namespace QLKS
{
    partial class DT_KTD
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
            this.b_xn = new System.Windows.Forms.Button();
            this.tb_md = new System.Windows.Forms.TextBox();
            this.l_md = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tb_dv = new System.Windows.Forms.TextBox();
            this.l_dv = new System.Windows.Forms.Label();
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
            this.l_MAIN.TabIndex = 22;
            this.l_MAIN.Text = "KIỂM TRA ĐƠN";
            this.l_MAIN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.b_xn.Location = new System.Drawing.Point(689, 202);
            this.b_xn.Name = "b_xn";
            this.b_xn.Size = new System.Drawing.Size(200, 50);
            this.b_xn.TabIndex = 59;
            this.b_xn.Text = "Xác Nhận";
            this.b_xn.UseVisualStyleBackColor = false;
            this.b_xn.Click += new System.EventHandler(this.b_xn_Click);
            // 
            // tb_md
            // 
            this.tb_md.BackColor = System.Drawing.Color.White;
            this.tb_md.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_md.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_md.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tb_md.Location = new System.Drawing.Point(206, 187);
            this.tb_md.Name = "tb_md";
            this.tb_md.Size = new System.Drawing.Size(180, 34);
            this.tb_md.TabIndex = 58;
            // 
            // l_md
            // 
            this.l_md.AutoSize = true;
            this.l_md.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.l_md.ForeColor = System.Drawing.Color.Goldenrod;
            this.l_md.Location = new System.Drawing.Point(106, 193);
            this.l_md.Name = "l_md";
            this.l_md.Size = new System.Drawing.Size(82, 28);
            this.l_md.TabIndex = 57;
            this.l_md.Text = "Mã Đơn";
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
            this.dgv.TabIndex = 56;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // tb_dv
            // 
            this.tb_dv.BackColor = System.Drawing.Color.White;
            this.tb_dv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_dv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_dv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tb_dv.Location = new System.Drawing.Point(206, 257);
            this.tb_dv.Name = "tb_dv";
            this.tb_dv.Size = new System.Drawing.Size(180, 34);
            this.tb_dv.TabIndex = 61;
            // 
            // l_dv
            // 
            this.l_dv.AutoSize = true;
            this.l_dv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.l_dv.ForeColor = System.Drawing.Color.Goldenrod;
            this.l_dv.Location = new System.Drawing.Point(106, 265);
            this.l_dv.Name = "l_dv";
            this.l_dv.Size = new System.Drawing.Size(79, 28);
            this.l_dv.TabIndex = 60;
            this.l_dv.Text = "Dịch Vụ";
            this.l_dv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DT_KTD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1233, 770);
            this.Controls.Add(this.tb_dv);
            this.Controls.Add(this.l_dv);
            this.Controls.Add(this.b_xn);
            this.Controls.Add(this.tb_md);
            this.Controls.Add(this.l_md);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.l_MAIN);
            this.Name = "DT_KTD";
            this.Text = "DT_KTD";
            this.Load += new System.EventHandler(this.DT_KTD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_MAIN;
        private System.Windows.Forms.Button b_xn;
        private System.Windows.Forms.TextBox tb_md;
        private System.Windows.Forms.Label l_md;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox tb_dv;
        private System.Windows.Forms.Label l_dv;
    }
}