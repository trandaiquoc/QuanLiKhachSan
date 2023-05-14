using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLKS
{
    public partial class LT_PNP : Form
    {
        public static int manv = 0;
        public static string data = string.Empty;
        SqlConnection con = new SqlConnection(data);
        SqlCommand command = null;
        public LT_PNP()
        {
            InitializeComponent();
            con.Open();
        }
        void load()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM PHIEUDATPHONG WHERE MAPHIEU NOT IN (SELECT MAPHIEU FROM PHIEUNHANPHONG)", con);

            DataTable table = new DataTable();
            adapter.Fill(table);
            dgv.DataSource = table;
        }
        private void LT_PNP_Load(object sender, EventArgs e)
        {
            load();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_p.DataBindings.Clear();
            tb_p.DataBindings.Add("text", dgv.DataSource, "MAPHIEU");
        }

        private void b_kt_Click(object sender, EventArgs e)
        {
            if( tb_p.Text == "")
            {
                MessageBox.Show("Chưa Chọn Phiếu");
            }
            else
            {
                command = new SqlCommand("SP_LT_PNP", con);
                command.Parameters.Add("@MAPHIEU", SqlDbType.Int).Value = Int32.Parse(tb_p.Text);
                command.CommandType = CommandType.StoredProcedure;
                int n = command.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show("Khởi Tạo Thành Công");
                    load();
                }
                else
                {
                    MessageBox.Show("Lỗi");
                }
            }
        }
    }
}
