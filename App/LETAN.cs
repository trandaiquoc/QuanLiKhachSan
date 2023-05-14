using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class LETAN : Form
    {
        public static int matk = 0;
        private Form currentChildForm = null;
        public LETAN()
        {
            InitializeComponent();
        }
        private void openChildForm(Form child)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            panel_body.Controls.Add(child);
            panel_body.Tag = child;
            child.BringToFront();
            child.Show();
        }
        private void LETAN_Load(object sender, EventArgs e)
        {
            label_user.Text = "LT" + matk.ToString();
        }

        private void b_dx_Click(object sender, EventArgs e)
        {
            this.Close();
            DANGNHAP L = new DANGNHAP();
            L.Show();
        }

        private void b_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có chắc muốn thoát chứ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void b_khm_Click(object sender, EventArgs e)
        {
            LT_KHM.manv = matk;
            openChildForm(new LT_KHM());
        }

        private void b_dp_Click(object sender, EventArgs e)
        {
            LT_P.manv = matk;
            openChildForm(new LT_P());
        }

        private void b_ddv_Click(object sender, EventArgs e)
        {
            LT_DV.manv = matk;
            openChildForm(new LT_DV());
        }

        private void b_hd_Click(object sender, EventArgs e)
        {
            LT_HD.manv = matk;
            openChildForm(new LT_HD());
        }

        private void b_pnp_Click(object sender, EventArgs e)
        {
            LT_PNP.manv = matk;
            openChildForm(new LT_PNP());
        }
    }
}
