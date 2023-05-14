using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLKS
{
    public partial class CTDV : Form
    {
        public static int maphieu = 0;
        public static string data = string.Empty;
        SqlConnection con = new SqlConnection(data);
        public CTDV()
        {
            InitializeComponent();
            con.Open();
        }

        private void b_thoat_Click(object sender, EventArgs e)
        {
            con.Close();
            this.Close();
        }

        private void CTDV_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM CHITIETPHIEUDV WHERE MAPHIEU = " + maphieu, con);

            DataTable table = new DataTable();
            adapter.Fill(table);
            dgv.DataSource = table;
        }
    }
}
