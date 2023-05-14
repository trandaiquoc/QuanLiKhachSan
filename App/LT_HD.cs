using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLKS
{
    public partial class LT_HD : Form
    {
        public static int manv = 0;
        public static string data = string.Empty;
        SqlConnection con = new SqlConnection(data);
        SqlCommand command = null;
        public LT_HD()
        {
            InitializeComponent();
            con.Open();
        }
        void load()
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
        void loadHD()
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT MAHD, TONGTIEN, SOTIENTHANHTOANTRUOC, TINHTRANG, PHIEU, DICHVU  FROM HOADON WHERE TINHTRANG = 'CTT' AND MAKH = " + cbb_mkh.Text, con);

                DataTable table = new DataTable();
                adapter.Fill(table);
                dgv.DataSource = table;
            }
            catch (Exception)
            {
                MessageBox.Show("Khách Hàng không tồn tại");
            }
            
        }

        private void LT_HD_Load(object sender, EventArgs e)
        {
            load();
        }

        private void b_search_Click(object sender, EventArgs e)
        {
            if ( cbb_mkh.Text == "")
            {
                MessageBox.Show("Chưa chọn khách hàng");
            }
            else
            {
                loadHD();
            }
        }

        private void b_xn_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("SP_KH_THANHTOAN", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAKH", SqlDbType.Int).Value = cbb_mkh.Text;
            command.Parameters.Add("@HTTT", SqlDbType.NVarChar).Value = "OFFLINE";
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
    }
}
