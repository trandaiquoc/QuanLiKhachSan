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
    public partial class DVT : Form
    {
        public static int makh = 0;
        public static int maphieu = 0;
        public static string data = string.Empty;
        SqlConnection con = new SqlConnection(data);
        SqlCommand command = null;
        public DVT()
        {
            InitializeComponent();
            con.Open();
        }

        private void b_dat_Click(object sender, EventArgs e)
        {
            int sntg = 1;
            if(tb_songuoi.Text != null && int.TryParse(tb_songuoi.Text, out int s) == true)
            {
                sntg = Int32.Parse(tb_songuoi.Text);
            }
            else
            {
                MessageBox.Show("Phải nhập số cho số người tham gia");
            }
            try
            {
                command = new SqlCommand("SP_KH_CHONDVT", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MAPHIEU", SqlDbType.Int).Value = maphieu;
                command.Parameters.Add("@MADV", SqlDbType.VarChar).Value = tb_dv.Text;
                command.Parameters.Add("@LDK", SqlDbType.VarChar).Value = tb_lhd.Text;
                command.Parameters.Add("@SNTG", SqlDbType.Int).Value = sntg;
                command.Parameters.Add("@VANCHUYEN", SqlDbType.NVarChar).Value = cbb_vc.Text;
                var returnParameter = command.Parameters.Add("@ReturnVal", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;
                command.ExecuteNonQuery();
                var n = returnParameter.Value.ToString();
                if (n == "1")
                    MessageBox.Show("Thiếu LỊCH HOẠT ĐỘNG kìa má!!!");
                else if (n =="2")
                    MessageBox.Show("Thiếu SỐ NGƯỜI THAM GIA kìa má!!!");
                else if (n == "3")
                    MessageBox.Show("Muốn chở đi hay không nè!!!");
                else if (n == "4")
                    MessageBox.Show("Số Người Tham Gia Quá Nhiều");
                else MessageBox.Show("Chốt Đơn <3");
            }
            catch (Exception)
            {
                MessageBox.Show("Này đặt rồi má ơi -3-");
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_dv.DataBindings.Clear();
            tb_dv.DataBindings.Add("text", dgv.DataSource, "MADV");
        }

        private void DVT_Load(object sender, EventArgs e)
        {
            tb_dv.Enabled = false;
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT DVT.MADV, DT.SDT, DV.TENDV, DV.GIA, DV.LICHHOATDONG FROM DICHVUTOUR DVT join DICHVU DV ON DV.MADV = DVT.MADV JOIN DOITAC DT ON DVT.MADT = DT.MADT", con);

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
