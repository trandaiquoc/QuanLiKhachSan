using System;
using System.Windows.Forms;

namespace QLKS
{
    public partial class KH_DP : Form
    {
        public static int makh = 0;
        private Form currentChildForm = null;
        public KH_DP()
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
            flowLayoutPanel1.Controls.Add(child);
            flowLayoutPanel1.Tag = child;
            child.BringToFront();
            child.Show();
        }
        private void b_102_Click(object sender, EventArgs e)
        {
            DP.phong = "P102";
            DP.makh = makh;
            openChildForm(new DP());
        }

        private void b_101_Click(object sender, EventArgs e)
        {
            DP.phong = "P101";
            DP.makh = makh;
            openChildForm(new DP());
        }

        private void b_103_Click(object sender, EventArgs e)
        {
            DP.phong = "P103";
            DP.makh = makh;
            openChildForm(new DP());
        }

        private void b_201_Click(object sender, EventArgs e)
        {
            DP.phong = "P201";
            DP.makh = makh;
            openChildForm(new DP());
        }

        private void b_202_Click(object sender, EventArgs e)
        {
            DP.phong = "P202";
            DP.makh = makh;
            openChildForm(new DP());
        }

        private void b_203_Click(object sender, EventArgs e)
        {
            DP.phong = "P203";
            DP.makh = makh;
            openChildForm(new DP());
        }
    }
}
