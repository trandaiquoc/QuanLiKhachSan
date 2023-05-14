using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLKS
{
    public partial class DT_KTD : Form
    {
        public static int madt = 0;
        public static string data = string.Empty;
        SqlConnection con = new SqlConnection(data);
        SqlCommand command = null;
        public DT_KTD()
        {
            InitializeComponent();
            con.Open();
        }
        void load()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT PDV.MAPHIEU, PDV.NGAY, PDV.TONGTIEN, CT.MADV, CT.LICHDANGKY, CT.SONGUOITHAMGIA, CT.VANCHUYEN " +
                                                        "FROM PHIEUDICHVU PDV JOIN CHITIETPHIEUDV CT ON PDV.MAPHIEU = CT.MAPHIEU JOIN DICHVUTOUR DV ON CT.MADV = DV.MADV " +
                                                        "WHERE CT.TINHTRANG = 'CXN' AND DV.MADT = " + madt, con);

            DataTable table = new DataTable();
            adapter.Fill(table);
            dgv.DataSource = table;
        }
        private void DT_KTD_Load(object sender, EventArgs e)
        {
            load();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_md.DataBindings.Clear();
            tb_md.DataBindings.Add("text", dgv.DataSource, "MAPHIEU");
            tb_dv.DataBindings.Clear();
            tb_dv.DataBindings.Add("text", dgv.DataSource, "MADV");
        }

        private void b_xn_Click(object sender, EventArgs e)
        {
            if(tb_md.Text == "" || tb_dv.Text == "")
            {
                MessageBox.Show("Chưa chọn đơn");
            }
            else
            {
                command = new SqlCommand("UPDATE CHITIETPHIEUDV SET TINHTRANG = 'XN' WHERE MADV = '" + tb_dv.Text + "' AND MAPHIEU = " + tb_md.Text, con);
                command.CommandType = CommandType.Text;
                int n = command.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show("Tiếp nhận đơn thành công");
                    load();
                }
                else
                {
                    MessageBox.Show("Tiếp nhận đơn thất bại");
                }
            }
            
        }
    }
}
