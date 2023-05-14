using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class LT_KHM : Form
    {
        public static int manv = 0;
        public static string data = string.Empty;
        SqlConnection con = new SqlConnection(data);
        SqlCommand command = null;
        public LT_KHM()
        {
            InitializeComponent();
            con.Open();
        }

        private void b_t_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("SP_LT_THEMKH", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@TEN", SqlDbType.NVarChar).Value = tb_ten.Text;
            command.Parameters.Add("@CMND", SqlDbType.NVarChar).Value = tb_cccd.Text;
            command.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = tb_sdt.Text;
            command.Parameters.Add("@EMAIL", SqlDbType.NVarChar).Value = tb_e.Text;
            command.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = tb_dc.Text;
            command.Parameters.Add("@DK", SqlDbType.NVarChar).Value = tb_dk.Text;
            var returnParameter = command.Parameters.Add("@ReturnVal", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;
            command.ExecuteNonQuery();
            string n = returnParameter.Value.ToString();
            if (n == "1")
            {
                MessageBox.Show("Số Điện Thoại chỉ có số");
            }
            else if (n == "2")
            {
                MessageBox.Show("CCCD chỉ có số");
            }
            else if (n == "3")
            {
                MessageBox.Show("CMND/CCCD/HC đã tồn tại");
            }
            else
            {
                MessageBox.Show("Thêm mới thành công");
            }
        }

        private void b_check_Click(object sender, EventArgs e)
        {
            if(tb_sdt.Text == "")
            {
                MessageBox.Show("SDT chưa nhập");
            }
            else
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM KHACHHANG WHERE SDT = '" + tb_sdt.Text + "'", con);

                DataTable table = new DataTable();
                adapter.Fill(table);
                dgv.DataSource = table;
            }
        }
    }
}
