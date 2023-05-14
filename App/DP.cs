using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLKS
{
    public partial class DP : Form
    {
        public static int makh = 0;
        public static int manv = 0;
        public static string phong = string.Empty;
        public static string data = string.Empty;
        SqlConnection con = new SqlConnection(data);
        SqlCommand command = null;
        public DP()
        {
            InitializeComponent();
            con.Open();
        }

        private void b_huy_Click(object sender, EventArgs e)
        {
            con.Close();
            this.Close();
        }

        private void DP_Load(object sender, EventArgs e)
        {
            tb_ten.Enabled = false;
            tb_gia.Enabled = false;
            tb_lp.Enabled = false;
            command = new SqlCommand("SELECT * FROM PHONG WHERE MAPHONG = '" + phong + "'", con);
            var reader = command.ExecuteReader();
            reader.Read();
            tb_ten.Text = reader["MAPHONG"].ToString();
            tb_gia.Text = reader["GIA"].ToString();
            tb_lp.Text = reader["LOAIPHONG"].ToString();
            reader.Close();
        }

        private void b_dat_Click(object sender, EventArgs e)
        {
            if (cbb_httt.Text == null)
            {
                MessageBox.Show("Chưa chọn hệ thống thanh toán");
            }
            try
            {
                command = new SqlCommand("SP_KH_DATPHONG", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MAKH", SqlDbType.Int).Value = makh;
                command.Parameters.Add("@NVLAPPHIEU", SqlDbType.Int).Value = manv;
                command.Parameters.Add("@PHONG", SqlDbType.VarChar).Value = phong;
                command.Parameters.Add("@NGAYDEN", SqlDbType.VarChar).Value = dtp.Text;
                command.Parameters.Add("@SODEMLUUTRU", SqlDbType.Int).Value = Int32.Parse(tb_sdlt.Text);
                command.Parameters.Add("@YEUCAUKHACHHANG", SqlDbType.NVarChar).Value = tb_yct.Text;
                command.Parameters.Add("@LOAIPHONG", SqlDbType.NVarChar).Value = tb_lp.Text;
                var returnParameter = command.Parameters.Add("@ReturnVal", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;
            
                command.ExecuteNonQuery();
                string n = returnParameter.Value.ToString();
                if (n == "1")
                {
                    MessageBox.Show("Phải nhập ngày đến và sô đêm lưu trú");
                }
                else
                {
                    MessageBox.Show("Đặt phòng thành công");
                    con.Close();
                    this.Close();
                }
            }
            catch (Exception) 
            {
                MessageBox.Show("Số đêm lưu trú phải là số");
            }
            
        }
    }
}
