using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLKS
{
    public partial class DT_QLDV : Form
    {
        public static int madt = 0;
        public static string data = string.Empty;
        SqlConnection con = new SqlConnection(data);
        SqlCommand command = null;
        public DT_QLDV()
        {
            InitializeComponent();
            con.Open();
        }

        private void DT_QLDV_Load(object sender, EventArgs e)
        {
            tb_dv.Enabled = false;
            load();
        }
        void load()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT DVT.MADV, DV.TENDV, DVT.DIADIEM, DV.GIA, DV.LICHHOATDONG, DVT.SOLUONGTOIDA FROM DICHVU DV JOIN DICHVUTOUR DVT ON DV.MADV = DVT.MADV WHERE DVT.MADT = " + madt, con);

            DataTable table = new DataTable();
            adapter.Fill(table);
            dgv.DataSource = table;
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_t.DataBindings.Clear();
            tb_t.DataBindings.Add("text", dgv.DataSource, "TENDV");
            tb_dv.DataBindings.Clear();
            tb_dv.DataBindings.Add("text", dgv.DataSource, "MADV");
            tb_dd.DataBindings.Clear();
            tb_dd.DataBindings.Add("text", dgv.DataSource, "DIADIEM");
            tb_g.DataBindings.Clear();
            tb_g.DataBindings.Add("text", dgv.DataSource, "GIA");
            tb_lhd.DataBindings.Clear();
            tb_lhd.DataBindings.Add("text", dgv.DataSource, "LICHHOATDONG");
            tb_sltd.DataBindings.Clear();
            tb_sltd.DataBindings.Add("text", dgv.DataSource, "SOLUONGTOIDA");
        }

        private void b_t_Click(object sender, EventArgs e)
        {
            if (tb_sltd.Text != null && int.TryParse(tb_sltd.Text, out int s) == false)
            {
                MessageBox.Show("Số Người Tối Đa Phải Là Số");
            }
            else if (tb_g.Text != null && float.TryParse(tb_g.Text, out float g) == false)
            {
                MessageBox.Show("Giá Phải Là Số");
            }
            else
            {
                try
                {
                    command = new SqlCommand("SP_DT_THEM", con);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@MADT", SqlDbType.Int).Value = madt;
                    command.Parameters.Add("@TEN", SqlDbType.NVarChar).Value = tb_t.Text;
                    command.Parameters.Add("@SLTD", SqlDbType.Int).Value = Int32.Parse(tb_sltd.Text);
                    command.Parameters.Add("@DIADIEM", SqlDbType.NVarChar).Value = tb_dd.Text;
                    command.Parameters.Add("@GIA", SqlDbType.Float).Value = float.Parse(tb_g.Text);
                    command.Parameters.Add("@LHD", SqlDbType.NVarChar).Value = tb_lhd.Text;
                    var returnParameter = command.Parameters.Add("@ReturnVal", SqlDbType.Int);
                    returnParameter.Direction = ParameterDirection.ReturnValue;
                    command.ExecuteNonQuery();
                    string n = returnParameter.Value.ToString();
                    if (n == "1")
                    {
                        MessageBox.Show("Thiếu thông tin để tạo");
                    }
                    else
                    {
                        MessageBox.Show("Thêm mới thành công");
                        load();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
                
        }

        private void b_x_Click(object sender, EventArgs e)
        {
            try
            {
                command = new SqlCommand("SP_DT_XOA", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MADV", SqlDbType.VarChar).Value = tb_dv.Text;
                int n = command.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show("Xóa thành công");
                    load();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void b_s_Click(object sender, EventArgs e)
        {
            if (tb_sltd.Text != null && int.TryParse(tb_sltd.Text, out int s) == false)
            {
                MessageBox.Show("Số Người Tối Đa Phải Là Số");
            }
            else if (tb_g.Text != null && float.TryParse(tb_g.Text, out float g) == false)
            {
                MessageBox.Show("Giá Phải Là Số");
            }
            else
            {
                try
                {
                    command = new SqlCommand("SP_DT_SUA", con);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@MADV", SqlDbType.VarChar).Value = tb_dv.Text;
                    command.Parameters.Add("@TEN", SqlDbType.NVarChar).Value = tb_t.Text;
                    command.Parameters.Add("@SLTD", SqlDbType.Int).Value = Int32.Parse(tb_sltd.Text);
                    command.Parameters.Add("@DIADIEM", SqlDbType.NVarChar).Value = tb_dd.Text;
                    command.Parameters.Add("@GIA", SqlDbType.Float).Value = float.Parse(tb_g.Text);
                    command.Parameters.Add("@LHD", SqlDbType.NVarChar).Value = tb_lhd.Text;
                    int n = command.ExecuteNonQuery();
                    if (n > 0)
                    {
                        MessageBox.Show("Sửa thành công");
                        load();
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
