using System;
using System.Windows.Forms;

namespace QLKS
{
    public partial class KHACHHANG : Form
    {
        public static int matk = 0;
        private Form currentChildForm = null;

        public KHACHHANG()
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
        private void b_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có chắc muốn thoát chứ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void b_dx_Click(object sender, EventArgs e)
        {
            this.Close();
            DANGNHAP L = new DANGNHAP();
            L.Show();
        }

        private void b_dp_Click(object sender, EventArgs e)
        {
            KH_DP.makh = matk;
            openChildForm(new KH_DP());
        }

        private void b_tttk_Click(object sender, EventArgs e)
        {
            KH_TTKH.makh = matk;
            openChildForm(new KH_TTKH());
        }

        private void b_ddv_Click(object sender, EventArgs e)
        {
            KH_DDV.makh = matk;
            openChildForm(new KH_DDV());
        }

        private void b_tt_Click(object sender, EventArgs e)
        {
            KH_TT.makh = matk;
            openChildForm(new KH_TT());
        }

        private void b_ddp_Click(object sender, EventArgs e)
        {
            KH_DDP.makh = matk;
            openChildForm(new KH_DDP());
        }

        private void b_dddv_Click(object sender, EventArgs e)
        {
            KH_DDDV.makh = matk;
            openChildForm(new KH_DDDV());
        }

        private void KHACHHANG_Load(object sender, EventArgs e)
        {
            label_user.Text = "KH" + matk.ToString();
        }
    }
}
