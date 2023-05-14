using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace QLKS
{
    public partial class DVTT : Form
    {
        public static int makh = 0;
        public static int maphieu = 0;
        public static string data = string.Empty;
        SqlConnection con = new SqlConnection(data);
        SqlCommand command = null;
        public DVTT()
        {
            InitializeComponent();
            con.Open();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_dv.DataBindings.Clear();
            tb_dv.DataBindings.Add("text", dgv.DataSource, "MADV");
        }

        private void b_dat_Click(object sender, EventArgs e)
        {
            try
            {
                command = new SqlCommand("SP_KH_CHONDVTT", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MAPHIEU", SqlDbType.Int).Value = maphieu;
                command.Parameters.Add("@MADV", SqlDbType.VarChar).Value = tb_dv.Text;
                command.Parameters.Add("@LDK", SqlDbType.VarChar).Value = tb_lhd.Text;
                var returnParameter = command.Parameters.Add("@ReturnVal", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;
                command.ExecuteNonQuery();
                var n = returnParameter.Value.ToString();
                if (n == "1")
                    MessageBox.Show("Thiếu LỊCH HOẠT ĐỘNG kìa má!!!");
                else MessageBox.Show("Chốt Đơn <3");
            }
            catch (Exception)
            {
                MessageBox.Show("Này đặt rồi má ơi -3-");
            }
        }

        private void DVTT_Load(object sender, EventArgs e)
        {
            tb_dv.Enabled = false;
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT MADV, TENDV, GIA, LICHHOATDONG FROM DICHVU WHERE LOAIHINH = 'THUONG'", con);

            DataTable table = new DataTable();
            adapter.Fill(table);
            dgv.DataSource = table;
        }

        private void b_xn_Click(object sender, EventArgs e)
        {
            DDV.dichvu = tb_dv.Text;
            DDV.makh = makh;
            DDV.phieu = maphieu;
            DDV ddv = new DDV();
            ddv.ShowDialog();
        }
    }
}
