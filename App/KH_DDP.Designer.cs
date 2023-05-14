namespace QLKS
{
    partial class KH_DDP
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
            this.tb_tt = new System.Windows.Forms.TextBox();
            this.l_tt = new System.Windows.Forms.Label();
            this.tb_md = new System.Windows.Forms.TextBox();
            this.l_md = new System.Windows.Forms.Label();
            this.b_huy = new System.Windows.Forms.Button();
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
            this.l_MAIN.TabIndex = 2;
            this.l_MAIN.Text = "ĐƠN ĐẶT PHÒNG";
            this.l_MAIN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.dgv.TabIndex = 42;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // tb_tt
            // 
            this.tb_tt.BackColor = System.Drawing.Color.White;
            this.tb_tt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_tt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_tt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tb_tt.Location = new System.Drawing.Point(546, 242);
            this.tb_tt.Name = "tb_tt";
            this.tb_tt.Size = new System.Drawing.Size(180, 34);
            this.tb_tt.TabIndex = 46;
            // 
            // l_tt
            // 
            this.l_tt.AutoSize = true;
            this.l_tt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.l_tt.ForeColor = System.Drawing.Color.Goldenrod;
            this.l_tt.Location = new System.Drawing.Point(407, 248);
            this.l_tt.Name = "l_tt";
            this.l_tt.Size = new System.Drawing.Size(102, 28);
            this.l_tt.TabIndex = 45;
            this.l_tt.Text = "Tình Trạng";
            this.l_tt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_md
            // 
            this.tb_md.BackColor = System.Drawing.Color.White;
            this.tb_md.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_md.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_md.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tb_md.Location = new System.Drawing.Point(150, 242);
            this.tb_md.Name = "tb_md";
            this.tb_md.Size = new System.Drawing.Size(180, 34);
            this.tb_md.TabIndex = 44;
            // 
            // l_md
            // 
            this.l_md.AutoSize = true;
            this.l_md.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.l_md.ForeColor = System.Drawing.Color.Goldenrod;
            this.l_md.Location = new System.Drawing.Point(50, 250);
            this.l_md.Name = "l_md";
            this.l_md.Size = new System.Drawing.Size(82, 28);
            this.l_md.TabIndex = 43;
            this.l_md.Text = "Mã Đơn";
            this.l_md.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // b_huy
            // 
            this.b_huy.BackColor = System.Drawing.Color.Goldenrod;
            this.b_huy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_huy.FlatAppearance.BorderSize = 0;
            this.b_huy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.b_huy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_huy.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.b_huy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.b_huy.Location = new System.Drawing.Point(927, 237);
            this.b_huy.Name = "b_huy";
            this.b_huy.Size = new System.Drawing.Size(200, 50);
            this.b_huy.TabIndex = 47;
            this.b_huy.Text = "Hủy";
            this.b_huy.UseVisualStyleBackColor = false;
            this.b_huy.Click += new System.EventHandler(this.b_huy_Click);
            // 
            // KH_DDP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1233, 770);
            this.Controls.Add(this.b_huy);
            this.Controls.Add(this.tb_tt);
            this.Controls.Add(this.l_tt);
            this.Controls.Add(this.tb_md);
            this.Controls.Add(this.l_md);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.l_MAIN);
            this.Name = "KH_DDP";
            this.Text = "KH_DDP";
            this.Load += new System.EventHandler(this.KH_DDP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_MAIN;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox tb_tt;
        private System.Windows.Forms.Label l_tt;
        private System.Windows.Forms.TextBox tb_md;
        private System.Windows.Forms.Label l_md;
        private System.Windows.Forms.Button b_huy;
    }
}