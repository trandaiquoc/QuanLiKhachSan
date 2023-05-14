namespace QLKS
{
    partial class KH_DDV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KH_DDV));
            this.l_MAIN = new System.Windows.Forms.Label();
            this.b_dvt = new System.Windows.Forms.Button();
            this.b_dvtt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.l_MAIN.TabIndex = 1;
            this.l_MAIN.Text = "ĐẶT DỊCH VỤ";
            this.l_MAIN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // b_dvt
            // 
            this.b_dvt.BackColor = System.Drawing.Color.Goldenrod;
            this.b_dvt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_dvt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_dvt.FlatAppearance.BorderSize = 0;
            this.b_dvt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.b_dvt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_dvt.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.b_dvt.ForeColor = System.Drawing.Color.Goldenrod;
            this.b_dvt.Image = ((System.Drawing.Image)(resources.GetObject("b_dvt.Image")));
            this.b_dvt.Location = new System.Drawing.Point(0, 0);
            this.b_dvt.Name = "b_dvt";
            this.b_dvt.Size = new System.Drawing.Size(614, 678);
            this.b_dvt.TabIndex = 22;
            this.b_dvt.Text = "Dịch Vụ Tour";
            this.b_dvt.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.b_dvt.UseVisualStyleBackColor = false;
            this.b_dvt.Click += new System.EventHandler(this.b_dvt_Click);
            // 
            // b_dvtt
            // 
            this.b_dvtt.BackColor = System.Drawing.Color.Goldenrod;
            this.b_dvtt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_dvtt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_dvtt.FlatAppearance.BorderSize = 0;
            this.b_dvtt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(195)))), ((int)(((byte)(165)))));
            this.b_dvtt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_dvtt.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.b_dvtt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.b_dvtt.Image = ((System.Drawing.Image)(resources.GetObject("b_dvtt.Image")));
            this.b_dvtt.Location = new System.Drawing.Point(0, 0);
            this.b_dvtt.Name = "b_dvtt";
            this.b_dvtt.Size = new System.Drawing.Size(613, 678);
            this.b_dvtt.TabIndex = 23;
            this.b_dvtt.Text = "Dịch Vụ Thông Thường";
            this.b_dvtt.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.b_dvtt.UseVisualStyleBackColor = false;
            this.b_dvtt.Click += new System.EventHandler(this.b_dvtt_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.b_dvtt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 678);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.b_dvt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(619, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(614, 678);
            this.panel2.TabIndex = 25;
            // 
            // KH_DDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1233, 770);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.l_MAIN);
            this.Name = "KH_DDV";
            this.Text = "KH_DDV";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label l_MAIN;
        private System.Windows.Forms.Button b_dvt;
        private System.Windows.Forms.Button b_dvtt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}