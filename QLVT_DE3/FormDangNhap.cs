using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT_DE3
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void FormDanhNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_QLVT.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.DS_QLVT.V_DS_PHANMANH);
            //Lệnh giả để chọn giá trị cho ComboBox
            ComboBox_chinhanh.SelectedIndex = 1;
            ComboBox_chinhanh.SelectedIndex = 0;
        }

        private void executeLogin()
        {
            if (textBox_username.Text.Trim() == "")
            {
                MessageBox.Show("Tài Khoản đăng nhập không được rỗng!", "Báo lỗi đăng nhập.", MessageBoxButtons.OK);
                textBox_username.Focus();
                return;
            }

            Program.mlogin = textBox_username.Text;
            Program.password = textBox_password.Text;

            try
            {

                if (Program.KetNoi() == 0) return;
                Program.mchinhanh = ComboBox_chinhanh.SelectedIndex;
                Program.bds_dspm = v_DS_PHANMANHBindingSource;
                Program.mloginDN = Program.mlogin;
                Program.passwordDN = Program.password;

                Program.frmChinh = new FormMain();
                Program.frmChinh.Activate();
                Program.frmChinh.Show();
                this.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Username or password incorrect " + ex.Message, "Error message", MessageBoxButtons.OK);
                textBox_username.Focus();
                return;
            }
        }

        private void button_dangnhap_Click(object sender, EventArgs e)
        {
            executeLogin();
        }

        private void button_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox_show_CheckedChanged(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = (checkBox_show.Checked) ? false : true;
        }

        private void ComboBox_chinhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.servername = ComboBox_chinhanh.SelectedValue.ToString();
        }
    }
}
