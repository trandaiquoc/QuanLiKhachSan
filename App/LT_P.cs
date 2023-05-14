using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLKS
{
    public partial class LT_P : Form
    {
        public static int manv = 0;
        public static string data = string.Empty;
        SqlConnection con = new SqlConnection(data);
        SqlCommand command = null;
        public LT_P()
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
        void loadPhong()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM PHONG", con);

            DataTable table = new DataTable();
            adapter.Fill(table);
            dgv.DataSource = table;
        }
        private void LT_P_Load(object sender, EventArgs e)
        {
            tb_p.Enabled = false;
            tb_tt.Enabled = false;
            tb_vs.Enabled = false;
            loadUser();
            loadPhong();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_p.DataBindings.Clear();
            tb_p.DataBindings.Add("text", dgv.DataSource, "MAPHONG");
            tb_tt.DataBindings.Clear();
            tb_tt.DataBindings.Add("text", dgv.DataSource, "TINHTRANG");
            tb_vs.DataBindings.Clear();
            tb_vs.DataBindings.Add("text", dgv.DataSource, "VESINH");
        }

        private void bt_tp_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("UPDATE PHONG SET TINHTRANG = N'TRỐNG', VESINH = N'BẨN' WHERE MAPHONG = '" + tb_p.Text + "'", con);
            command.CommandType = CommandType.Text;
            int n = command.ExecuteNonQuery();
            if (n > 0)
            {
                MessageBox.Show("Xác Nhận Trả Phòng Thành Công");
                loadPhong();
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void b_d_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("SELECT COUNT(*) FROM KHACHHANG WHERE MAKH = " + cbb_mkh.Text, con);
            command.CommandType = CommandType.Text;
            var n = command.ExecuteScalar();
            if(n.ToString() == "0")
            {
                MessageBox.Show("Khách hàng không tồn tại");
            }
            else
            {
                if (cbb_mkh.Text != "" && tb_p.Text != "")
                {
                    DP.phong = tb_p.Text;
                    DP.manv = manv;
                    DP.makh = Int32.Parse(cbb_mkh.Text);
                    DP d = new DP();
                    d.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Thiếu thông tin cần thiết");
                }
            }
        }
    }
}
