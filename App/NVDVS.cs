using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLKS
{
    public partial class NVDVS : Form
    {
        public static string data = string.Empty;
        SqlConnection con = new SqlConnection(data);
        public NVDVS()
        {
            InitializeComponent();
            con.Open();
        }
        void load()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT MAPHONG, VESINH FROM PHONG", con);

            DataTable table = new DataTable();
            adapter.Fill(table);
            dgv.DataSource = table;
        }
        private void b_cn_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("UPDATE PHONG SET VESINH = N'Sạch' WHERE MAPHONG = '" + tb_p.Text + "'", con);
            command.CommandType = CommandType.Text;
            int n = command.ExecuteNonQuery();
            if( n > 0)
            {
                MessageBox.Show("Cập nhật thành công!!");
                load();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!!");
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_p.DataBindings.Clear();
            tb_p.DataBindings.Add("text", dgv.DataSource, "MAPHONG");
            tb_ttvs.DataBindings.Clear();
            tb_ttvs.DataBindings.Add("text", dgv.DataSource, "VESINH");
        }

        private void NVDVS_Load(object sender, EventArgs e)
        {
            load();
        }

        private void b_dx_Click(object sender, EventArgs e)
        {
            this.Close();
            DANGNHAP L = new DANGNHAP();
            L.Show();
        }

        private void b_t_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có chắc muốn thoát chứ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
