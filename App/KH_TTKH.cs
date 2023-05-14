using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLKS
{
    public partial class KH_TTKH : Form
    {
        public static int makh = 0;
        public static string data = string.Empty;
        SqlConnection con = new SqlConnection(data);
        SqlCommand command = null;
        public KH_TTKH()
        {
            InitializeComponent();
            con.Open();
        }

        private void KH_TTKH_Load(object sender, EventArgs e)
        {
            load();
        }
        void load()
        {
            command = new SqlCommand("SELECT * FROM KHACHHANG WHERE MAKH = " + makh, con);
            var reader = command.ExecuteReader();
            reader.Read();
            tb_ten.Text = reader["TEN"].ToString();
            tb_cccd.Text = reader["CMND"].ToString();
            tb_dc.Text = reader["DIACHI"].ToString();
            tb_e.Text = reader["EMAIL"].ToString();
            tb_sdt.Text = reader["SDT"].ToString();
            tb_dk.Text = reader["DOANKHACH"].ToString();
            reader.Close();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("SP_KH_CAPNHATTHONGTIN", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAKH", SqlDbType.Int).Value = makh;
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
                MessageBox.Show("Cập nhật thành công");
            }
        }
    }
}
