using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLKS
{
    public partial class DANGKY : Form
    {
        public static string data = string.Empty;
        SqlConnection con = new SqlConnection(data);
        SqlCommand command = null;
        public DANGKY()
        {
            InitializeComponent();
            con.Open();
        }

        private void button_dk_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("SP_DANGKYTAIKHOAN", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@USERNAME", SqlDbType.VarChar).Value = textBox_username.Text;
            command.Parameters.Add("@PASSWORD", SqlDbType.VarChar).Value = textBox_pass.Text;
            command.Parameters.Add("@PASSWORDCHECK", SqlDbType.VarChar).Value = tb_xnmk.Text;
            var returnParameter = command.Parameters.Add("@ReturnVal", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;
            command.ExecuteNonQuery();
            string n = returnParameter.Value.ToString();
            if (n == "1")
            {
                MessageBox.Show("Không nhập đầy đủ thông tin để đăng ký");
            }
            else if (n == "2")
            {
                MessageBox.Show("Tên tài khoản đã tồn tại");
            }
            else if (n == "3")
            {
                MessageBox.Show("Mật Khẩu và Nhập Lại Mật Khẩu không trùng khớp");
            }
            else
            {
                button_dn_Click(sender, e);
            }
        }

        private void button_dn_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn quay lại đăng nhập không?", "Đăng Ký Thành Công", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                DANGNHAP.username = textBox_username.Text;
                DANGNHAP.password = textBox_pass.Text;
                con.Close();
                this.Close();
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có chắc muốn thoát chứ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void tb_xnmk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                button_dk_Click(sender, e);
            }
        }
    }
}
