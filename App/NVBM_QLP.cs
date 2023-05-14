using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLKS
{
    public partial class NVBM_QLP : Form
    {
        public static int manv = 0;
        public static string data = string.Empty;
        SqlConnection con = new SqlConnection(data);
        SqlCommand command = null;
        public NVBM_QLP()
        {
            InitializeComponent();
            con.Open();
        }
        void load()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT PNP.*, (SELECT TEN FROM KHACHHANG WHERE MAKH = P.KHACHHANG) AS TENKH, PH.QUYDINH, PH.VESINH\r\nFROM PHIEUNHANPHONG PNP JOIN PHIEU P ON P.MAPHIEU = PNP.MAPHIEU JOIN PHONG PH ON PNP.PHONG = PH.MAPHONG\r\nWHERE PNP.TINHTRANG = N'ĐÃ NHẬN' AND PNP.NVDANKHACH = " + manv, con);

            DataTable table = new DataTable();
            adapter.Fill(table);
            dgv.DataSource = table;
        }
        void loadNumber()
        {
            cbb.Items.Clear();
            command = new SqlCommand("SELECT SDT FROM NHANVIEN WHERE VAITRO = 'Vesinh'", con);
            command.CommandType = CommandType.Text;
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                cbb.Items.Add(reader[0]);
            }
            reader.Close();
        }
        private void NVBM_QLP_Load(object sender, EventArgs e)
        {
            load();
            loadNumber();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_md.DataBindings.Clear();
            tb_md.DataBindings.Add("text", dgv.DataSource, "MAPHIEU");
            tb_ten.DataBindings.Clear();
            tb_ten.DataBindings.Add("text", dgv.DataSource, "TENKH");
            tb_p.DataBindings.Clear();
            tb_p.DataBindings.Add("text", dgv.DataSource, "PHONG");
            tb_qd.DataBindings.Clear();
            tb_qd.DataBindings.Add("text", dgv.DataSource, "QUYDINH");
            tb_vs.DataBindings.Clear();
            tb_vs.DataBindings.Add("text", dgv.DataSource, "VESINH");
        }

        private void b_ht_Click(object sender, EventArgs e)
        {
            int check = 0;
            if(cb_vchl.Checked == true)
            {
                check = 1;
            }
            command = new SqlCommand("UPDATE PHIEUNHANPHONG SET TINHTRANG = N'HOÀN THÀNH', VANCHUYENHANHLY = " + check + " WHERE MAPHIEU = " + tb_md.Text, con);
            command.CommandType = CommandType.Text;
            int n = command.ExecuteNonQuery();
            if ( n > 0 )
            {
                MessageBox.Show("Phiếu Đã Hoàn Thành");
                load();
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
        }
    }
}
