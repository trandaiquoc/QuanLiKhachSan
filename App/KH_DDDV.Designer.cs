namespace QLKS
{
    partial class KH_DDDV
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
            this.tb_md = new System.Windows.Forms.TextBox();
            this.l_md = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.l_MAIN = new System.Windows.Forms.Label();
            this.b_xdv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_md
            // 
            this.tb_md.BackColor = System.Drawing.Color.White;
            this.tb_md.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_md.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_md.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tb_md.Location = new System.Drawing.Point(383, 239);
            this.tb_md.Name = "tb_md";
            this.tb_md.Size = new System.Drawing.Size(180, 34);
            this.tb_md.TabIndex = 51;
            // 
            // l_md
            // 
            this.l_md.AutoSize = true;
            this.l_md.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.l_md.ForeColor = System.Drawing.Color.Goldenrod;
            this.l_md.Location = new System.Drawing.Point(283, 247);
            this.l_md.Name = "l_md";
            this.l_md.Size = new System.Drawing.Size(82, 28);
            this.l_md.TabIndex = 50;
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
            this.dgv.TabIndex = 49;
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
            this.l_MAIN.TabIndex = 48;
            this.l_MAIN.Text = "ĐƠN ĐẶT DỊCH VỤ";
            this.l_MAIN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // b_xdv
            // 
            this.b_xdv.BackColor = System.Drawing.Color.Goldenrod;
            this.b_xdv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_xdv.FlatAppearance.BorderSize = 0;
            this.b_xdv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.b_xdv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_xdv.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.b_xdv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.b_xdv.Location = new System.Drawing.Point(752, 239);
            this.b_xdv.Name = "b_xdv";
            this.b_xdv.Size = new System.Drawing.Size(200, 50);
            this.b_xdv.TabIndex = 55;
            this.b_xdv.Text = "Xem Dịch Vụ";
            this.b_xdv.UseVisualStyleBackColor = false;
            this.b_xdv.Click += new System.EventHandler(this.b_xdv_Click);
            // 
            // KH_DDDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1233, 770);
            this.Controls.Add(this.b_xdv);
            this.Controls.Add(this.tb_md);
            this.Controls.Add(this.l_md);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.l_MAIN);
            this.Name = "KH_DDDV";
            this.Text = "KH_DDDV";
            this.Load += new System.EventHandler(this.KH_DDDV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_md;
        private System.Windows.Forms.Label l_md;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label l_MAIN;
        private System.Windows.Forms.Button b_xdv;
    }
}