using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLKS
{
    public partial class KH_DDDV : Form
    {
        public static int makh = 0;
        public static string data = string.Empty;
        SqlConnection con = new SqlConnection(data);
        public KH_DDDV()
        {
            InitializeComponent();
            con.Open();
        }

        void load()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM PHIEUDICHVU WHERE KHACHHANG = " + makh, con);

            DataTable table = new DataTable();
            adapter.Fill(table);
            dgv.DataSource = table;
        }

        private void b_xdv_Click(object sender, EventArgs e)
        {
            if( tb_md.Text != "")
            {
                CTDV.maphieu = Int32.Parse(tb_md.Text);
                CTDV ctdv = new CTDV();
                ctdv.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chưa chọn đơn");
            }
            
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_md.DataBindings.Clear();
            tb_md.DataBindings.Add("text", dgv.DataSource, "MAPHIEU");
        }

        private void KH_DDDV_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}
