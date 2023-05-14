using System;
using System.Windows.Forms;

namespace QLKS
{
    public partial class BELLMAN : Form
    {
        public static int matk = 0;
        private Form currentChildForm = null;
        public BELLMAN()
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
        private void BELLMAN_Load(object sender, EventArgs e)
        {
            label_user.Text = "NVBM" + matk.ToString();
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

        private void b_tnp_Click(object sender, EventArgs e)
        {
            NVBM_TNP.manv = matk;
            openChildForm(new NVBM_TNP());
        }

        private void b_qlp_Click(object sender, EventArgs e)
        {
            NVBM_QLP.manv = matk;
            openChildForm(new NVBM_QLP());
        }
    }
}
