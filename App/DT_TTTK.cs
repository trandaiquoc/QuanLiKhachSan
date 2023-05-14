using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLKS
{
    public partial class DT_TTTK : Form
    {
        public static int madt = 0;
        public static string data = string.Empty;
        SqlConnection con = new SqlConnection(data);
        SqlCommand command = null;
        public DT_TTTK()
        {
            InitializeComponent();
            con.Open();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("SP_DT_CAPNHATTHONGTIN", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MADT", SqlDbType.Int).Value = madt;
            command.Parameters.Add("@TEN", SqlDbType.NVarChar).Value = tb_ten.Text;
            command.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = tb_sdt.Text;
            command.Parameters.Add("@EMAIL", SqlDbType.NVarChar).Value = tb_e.Text;
            command.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = tb_dc.Text;
            var returnParameter = command.Parameters.Add("@ReturnVal", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;
            command.ExecuteNonQuery();
            string n = returnParameter.Value.ToString();
            if (n == "1")
            {
                MessageBox.Show("Số Điện Thoại chỉ có số");
            }
            else
            {
                MessageBox.Show("Cập nhật thành công");
            }
        }

        private void DT_TTTK_Load(object sender, EventArgs e)
        {
            tb_sldv.Enabled = false;
            load();
        }
        void load()
        {
            command = new SqlCommand("SELECT * FROM DOITAC WHERE MADT = " + madt, con);
            var reader = command.ExecuteReader();
            reader.Read();
            tb_ten.Text = reader["TENDT"].ToString();
            tb_dc.Text = reader["DIACHITRUSOCHINH"].ToString();
            tb_e.Text = reader["EMAIL"].ToString();
            tb_sdt.Text = reader["SDT"].ToString();
            tb_sldv.Text = reader["SLDV"].ToString();
            reader.Close();
        }
    }
}
