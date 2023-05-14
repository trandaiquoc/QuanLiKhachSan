using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLKS
{
    public partial class KH_DDV : Form
    {
        public static int makh = 0;
        public static string data = string.Empty;
        SqlConnection con = new SqlConnection(data);
        SqlCommand command = null;
        private Form currentChildForm = null;
        public KH_DDV()
        {
            InitializeComponent();
            con.Open();
        }
        private void openChildForm1(Form child)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            panel1.Controls.Add(child);
            panel1.Tag = child;
            child.BringToFront();
            child.Show();
        }
        private void openChildForm2(Form child)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            panel2.Controls.Add(child);
            panel2.Tag = child;
            child.BringToFront();
            child.Show();
        }

        private void b_dvtt_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("SP_KH_TAOPHIEUDV", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAKH", SqlDbType.Int).Value = makh;
            var reader = command.ExecuteReader();
            reader.Read();
            DVTT.maphieu = Int32.Parse(reader[0].ToString());
            DVTT.makh = makh;
            openChildForm1(new DVTT());
            reader.Close();
        }

        private void b_dvt_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("SP_KH_TAOPHIEUDV", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAKH", SqlDbType.Int).Value = makh;
            var reader = command.ExecuteReader();
            reader.Read();
            DVT.maphieu = Int32.Parse(reader[0].ToString());
            DVT.makh = makh;
            openChildForm2(new DVT());
            reader.Close();
        }
    }
}
