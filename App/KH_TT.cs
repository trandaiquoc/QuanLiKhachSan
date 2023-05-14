using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLKS
{
    public partial class KH_TT : Form
    {
        public static int makh = 0;
        public static string data = string.Empty;
        SqlConnection con = new SqlConnection(data);
        SqlCommand command = null;
        public KH_TT()
        {
            InitializeComponent();
            con.Open();
        }

        private void b_thanhtoan_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("SP_KH_THANHTOAN", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAKH", SqlDbType.Int).Value = makh;
            command.Parameters.Add("@HTTT", SqlDbType.NVarChar).Value = cbb_httt.Text;
            var returnParameter = command.Parameters.Add("@ReturnVal", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;
            command.ExecuteNonQuery();
            string n = returnParameter.Value.ToString();
            if (n == "1")
            {
                MessageBox.Show("Chưa chọn hình thức thanh toán");
            }
            else if (n == "0")
            {
                MessageBox.Show("Thanh toán thành công <3");
                load();
            }
            else MessageBox.Show("Thanh toán thất bại T.T");
        }

        private void KH_TT_Load(object sender, EventArgs e)
        {
            load();
        }

        void load()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT MAHD, TONGTIEN, SOTIENTHANHTOANTRUOC, TINHTRANG, PHIEU, DICHVU  FROM HOADON WHERE TINHTRANG = 'CTT' AND MAKH = " + makh, con);

            DataTable table = new DataTable();
            adapter.Fill(table);
            dgv.DataSource = table;
        }
    }
}
