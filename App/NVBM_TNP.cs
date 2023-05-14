using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLKS
{
    public partial class NVBM_TNP : Form
    {
        public static int manv = 0;
        public static string data = string.Empty;
        SqlConnection con = new SqlConnection(data);
        SqlCommand command = null;
        public NVBM_TNP()
        {
            InitializeComponent();
            con.Open();
        }
        void load()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT PNP.MAPHIEU, PNP.PHONG, PNP.TINHTRANG, (SELECT TEN FROM KHACHHANG WHERE MAKH = (SELECT P.KHACHHANG FROM PHIEU P WHERE P.MAPHIEU = PNP.MAPHIEU)) AS TENKH " + 
                                                        "FROM PHIEUNHANPHONG PNP WHERE PNP.TINHTRANG = N'CHƯA NHẬN'", con);

            DataTable table = new DataTable();
            adapter.Fill(table);
            dgv.DataSource = table;
        }
        private void NVBM_TNP_Load(object sender, EventArgs e)
        {
            load();
        }

        private void b_xn_Click(object sender, EventArgs e)
        {
            if (tb_md.Text == "")
            {
                MessageBox.Show("Chưa chọn phiếu nhận");
            }
            else
            {
                command = new SqlCommand("UPDATE PHIEUNHANPHONG " +
                                         "SET TINHTRANG = N'ĐÃ NHẬN'," +
                                         "    NVDANKHACH = " + manv +"," +
                                         "    THOIGIAN = GETDATE()" +
                                         "WHERE MAPHIEU = '" + tb_md.Text + "'", con);
                command.CommandType = CommandType.Text;
                int n = command.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show("Tiếp nhận thành công");
                    load();
                }
                else
                {
                    MessageBox.Show("Tiếp nhận thất bại");
                }
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_md.DataBindings.Clear();
            tb_md.DataBindings.Add("text", dgv.DataSource, "MAPHIEU");
        }
    }
}
