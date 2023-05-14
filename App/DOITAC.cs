using System;
using System.Windows.Forms;

namespace QLKS
{
    public partial class DOITAC : Form
    {
        public static int matk = 0;
        private Form currentChildForm = null;
        public DOITAC()
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
        private void DOITAC_Load(object sender, EventArgs e)
        {
            label_user.Text = "DT" + matk.ToString();
        }

        private void b_tttk_Click(object sender, EventArgs e)
        {
            DT_TTTK.madt = matk;
            openChildForm(new DT_TTTK());
        }

        private void b_ktd_Click(object sender, EventArgs e)
        {
            DT_KTD.madt = matk; 
            openChildForm(new DT_KTD());
        }

        private void b_qldv_Click(object sender, EventArgs e)
        {
            DT_QLDV.madt = matk;
            openChildForm(new DT_QLDV());
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
    }
}
