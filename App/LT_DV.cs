using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLKS
{
    public partial class LT_DV : Form
    {
        public static int manv = 0;
        public static string data = string.Empty;
        SqlConnection con = new SqlConnection(data);
        SqlCommand command = null;
        private Form currentChildForm = null;
        public LT_DV()
        {
            InitializeComponent();
            con.Open();
        }
        void loadUser()
        {
            cbb_mkh.Items.Clear();
            command = new SqlCommand("SELECT MAKH FROM KHACHHANG", con);
            command.CommandType = CommandType.Text;
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                cbb_mkh.Items.Add(reader[0]);
            }
            reader.Close();
        }
        private void LT_DV_Load(object sender, EventArgs e)
        {
            loadUser();
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
        private void b_d_Click(object sender, EventArgs e)
        {
            if (cbb_mkh.Text != "" && cbb_dv.Text != null)
            {
                if(cbb_dv.Text == "Dịch Vụ Thông Thường")
                {
                    try
                    {
                        command = new SqlCommand("SP_KH_TAOPHIEUDV", con);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@MAKH", SqlDbType.Int).Value = Int32.Parse(cbb_mkh.Text);
                        var reader = command.ExecuteReader();
                        reader.Read();
                        DVTT.maphieu = Int32.Parse(reader[0].ToString());
                        DVTT.makh = Int32.Parse(cbb_mkh.Text);
                        openChildForm(new DVTT());
                        reader.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Khách hàng không tồn tại");
                    }
                }
                else
                {
                    try
                    {
                        command = new SqlCommand("SP_KH_TAOPHIEUDV", con);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@MAKH", SqlDbType.Int).Value = Int32.Parse(cbb_mkh.Text);
                        var reader = command.ExecuteReader();
                        reader.Read();
                        DVT.maphieu = Int32.Parse(reader[0].ToString());
                        DVT.makh = Int32.Parse(cbb_mkh.Text);
                        openChildForm(new DVT());
                        reader.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Khách hàng không tồn tại");
                    }
                }
            }
            else
            {
                MessageBox.Show("Thiếu thông tin cần thiết");
            }
        }
    }
}
