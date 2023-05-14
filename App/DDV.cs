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
    public partial class DDV : Form
    {
        public static int makh = 0;
        public static int phieu = 0;
        public static string dichvu = string.Empty;
        public static string data = string.Empty;
        SqlConnection con = new SqlConnection(data);
        SqlCommand command = null;
        public DDV()
        {
            InitializeComponent();
            con.Open();
        }

        private void DDV_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT MADV, (SELECT TENDV FROM DICHVU D WHERE P.MADV = D.MADV) AS TENDV, LICHDANGKY, GIA, TINHTRANG FROM CHITIETPHIEUDV P WHERE MAPHIEU = " + phieu, con);

            DataTable table = new DataTable();
            adapter.Fill(table);
            dgv.DataSource = table;
        }

        private void b_huy_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("SP_KH_HUY", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAPHIEU", SqlDbType.Int).Value = phieu;
            int n = command.ExecuteNonQuery();
            if (n > 0)
            {
                MessageBox.Show("Hủy thành công");
                this.Close();
            }
            else MessageBox.Show("Xoá không thành công");
        }

        private void b_dat_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("SP_KH_XACNHAN", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAPHIEU", SqlDbType.Int).Value = phieu;
            command.Parameters.Add("@MAKH", SqlDbType.Int).Value = makh;
            int n = command.ExecuteNonQuery();
            if (n > 0)
            {
                MessageBox.Show("Đặt thành công");
                this.Close();
            }
            else MessageBox.Show("Đặt không thành công");

        }
    }
}
