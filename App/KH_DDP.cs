using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLKS
{
    public partial class KH_DDP : Form
    {
        public static int makh = 0;
        public static string data = string.Empty;
        SqlConnection con = new SqlConnection(data);
        SqlCommand command = null;
        public KH_DDP()
        {
            InitializeComponent();
            con.Open();
        }

        void load()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT PDP.*  FROM PHIEUDATPHONG PDP JOIN PHIEU P ON PDP.MAPHIEU = P.MAPHIEU WHERE  P.KHACHHANG = " + makh, con);

            DataTable table = new DataTable();
            adapter.Fill(table);
            dgv.DataSource = table;
        }
        private void KH_DDP_Load(object sender, EventArgs e)
        {
            load();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_md.DataBindings.Clear();
            tb_md.DataBindings.Add("text", dgv.DataSource, "MAPHIEU");
            tb_tt.DataBindings.Clear();
            tb_tt.DataBindings.Add("text", dgv.DataSource, "TINHTRANG");
        }

        private void b_huy_Click(object sender, EventArgs e)
        {
            if ( tb_md.Text != "")
            {
                command = new SqlCommand("SP_KH_HUYPHONG", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MAPHIEU", SqlDbType.Int).Value = tb_md.Text;
                int n = command.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show("Hủy thành công");
                }
                else MessageBox.Show("Xoá không thành công");
            }
            else
            {
                MessageBox.Show("Chưa chọn đơn");
            }
            
        }
    }
}
