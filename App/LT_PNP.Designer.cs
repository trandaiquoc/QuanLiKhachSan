namespace QLKS
{
    partial class LT_PNP
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
            this.tb_p = new System.Windows.Forms.TextBox();
            this.l_p = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.b_kt = new System.Windows.Forms.Button();
            this.l_MAIN = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_p
            // 
            this.tb_p.BackColor = System.Drawing.Color.White;
            this.tb_p.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_p.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tb_p.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tb_p.Location = new System.Drawing.Point(387, 193);
            this.tb_p.Name = "tb_p";
            this.tb_p.Size = new System.Drawing.Size(200, 34);
            this.tb_p.TabIndex = 89;
            // 
            // l_p
            // 
            this.l_p.AutoSize = true;
            this.l_p.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.l_p.ForeColor = System.Drawing.Color.Goldenrod;
            this.l_p.Location = new System.Drawing.Point(231, 199);
            this.l_p.Name = "l_p";
            this.l_p.Size = new System.Drawing.Size(93, 28);
            this.l_p.TabIndex = 88;
            this.l_p.Text = "Mã Phiếu";
            this.l_p.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv.Location = new System.Drawing.Point(0, 286);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1233, 484);
            this.dgv.TabIndex = 83;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // b_kt
            // 
            this.b_kt.BackColor = System.Drawing.Color.Goldenrod;
            this.b_kt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_kt.FlatAppearance.BorderSize = 0;
            this.b_kt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.b_kt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_kt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.b_kt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.b_kt.Location = new System.Drawing.Point(820, 193);
            this.b_kt.Name = "b_kt";
            this.b_kt.Size = new System.Drawing.Size(200, 50);
            this.b_kt.TabIndex = 82;
            this.b_kt.Text = "Khởi Tạo";
            this.b_kt.UseVisualStyleBackColor = false;
            this.b_kt.Click += new System.EventHandler(this.b_kt_Click);
            // 
            // l_MAIN
            // 
            this.l_MAIN.Dock = System.Windows.Forms.DockStyle.Top;
            this.l_MAIN.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.l_MAIN.ForeColor = System.Drawing.Color.Goldenrod;
            this.l_MAIN.Location = new System.Drawing.Point(0, 0);
            this.l_MAIN.Name = "l_MAIN";
            this.l_MAIN.Size = new System.Drawing.Size(1233, 92);
            this.l_MAIN.TabIndex = 81;
            this.l_MAIN.Text = "TẠO PHIẾU NHẬN PHÒNG";
            this.l_MAIN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LT_PNP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1233, 770);
            this.Controls.Add(this.tb_p);
            this.Controls.Add(this.l_p);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.b_kt);
            this.Controls.Add(this.l_MAIN);
            this.Name = "LT_PNP";
            this.Text = "LT_PNP";
            this.Load += new System.EventHandler(this.LT_PNP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_p;
        private System.Windows.Forms.Label l_p;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button b_kt;
        private System.Windows.Forms.Label l_MAIN;
    }
}