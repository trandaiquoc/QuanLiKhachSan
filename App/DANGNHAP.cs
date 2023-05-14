using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLKS
{
    public partial class DANGNHAP : Form
    {
        public static string username = string.Empty;
        public static string password = string.Empty;
        public static string data = string.Empty;
        SqlConnection con = new SqlConnection(data);
        public DANGNHAP()
        {
            InitializeComponent();
            con.Open();
        }

        private void pictureBox_hienmk_Click(object sender, System.EventArgs e)
        {
            if (textBox_pass.PasswordChar == '*')
            {
                pictureBox_anmk.BringToFront();
                textBox_pass.PasswordChar = '\0';
            }
        }

        private void pictureBox_anmk_Click(object sender, System.EventArgs e)
        {
            if (textBox_pass.PasswordChar == '\0')
            {
                pictureBox_hienmk.BringToFront();
                textBox_pass.PasswordChar = '*';
            }
        }

        private void button_login_Click(object sender, System.EventArgs e)
        {
            SqlCommand command = new SqlCommand("SP_DANGNHAP", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@USERID", SqlDbType.VarChar).Value = textBox_username.Text;
            command.Parameters.Add("@PASSWORD", SqlDbType.VarChar).Value = textBox_pass.Text;
            var returnParameter = command.Parameters.Add("@ReturnVal", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;
            command.ExecuteNonQuery();
            var n = returnParameter.Value.ToString();
            if (n == "1")
            {
                MessageBox.Show("Không nhập đầy đủ thông tin để đăng nhập");
            }
            else if (n == "2")
            {
                MessageBox.Show("Tài khoản không tồn tại");
            }
            else if (n == "3")
            {
                MessageBox.Show("Sai mật khẩu");
            }
            else if (n == "4")
            {
                MessageBox.Show("Đăng nhập không thành công");
            }
            else
            {
                command = new SqlCommand("SELECT USERID FROM TAIKHOAN WHERE USERNAME = '" + textBox_username.Text + "' AND PASSWORD = '" + textBox_pass.Text + "'", con);
                command.CommandType = CommandType.Text;
                string matk = command.ExecuteScalar().ToString();

                command = new SqlCommand("SP_CHECKTYPEACC", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@USERID", SqlDbType.Int).Value = Int32.Parse(matk);
                returnParameter = command.Parameters.Add("@ReturnVal", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;
                command.ExecuteNonQuery();
                n = returnParameter.Value.ToString();
                if (n == "1")
                {
                    this.Hide();
                    KHACHHANG KH = new KHACHHANG();
                    KHACHHANG.matk = Int32.Parse(matk);
                    KH.Show();
                }
                else if(n == "2")
                {
                    this.Hide();
                    DOITAC DT = new DOITAC();
                    DOITAC.matk = Int32.Parse(matk);
                    DT.Show();
                }
                else if (n == "3")
                {
                    this.Hide();
                    LETAN LT = new LETAN();
                    LETAN.matk = Int32.Parse(matk);
                    LT.Show();
                }
                else if (n == "4")
                {
                    this.Hide();
                    BELLMAN B = new BELLMAN();
                    BELLMAN.matk = Int32.Parse(matk);
                    B.Show();
                }
                else if (n == "5")
                {
                    this.Hide();
                    NVDVS DVS = new NVDVS();
                    DVS.Show();
                }
                else
                {
                    MessageBox.Show("Lỗi!!");
                }
            }
        }
        private void button_signup_Click(object sender, System.EventArgs e)
        {
            DANGKY DK = new DANGKY();
            DK.ShowDialog();
        }

        private void button_exit_Click(object sender, System.EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có chắc muốn thoát chứ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void textBox_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                button_login_Click(sender, e);
            }
        }

        private void DANGNHAP_Load(object sender, System.EventArgs e)
        {
            textBox_username.Text = null;
            textBox_pass.Text = null;
            if (username != null && password != null)
            {
                textBox_username.Text = username;
                textBox_pass.Text = password;
            }
        }

        private void textBox_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textBox_pass.Select();
            }
        }
    }
}
