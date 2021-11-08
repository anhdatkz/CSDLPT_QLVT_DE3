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

namespace QLVT_DE3
{
    public partial class FormTaoTaiKhoan : Form
    {
        public FormTaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void dSNVBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.BDS_DSNV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS_QLVT);

        }

        private void FormTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            DS_QLVT.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS_QLVT.DSNV' table. You can move, or remove it, as needed.
            this.DSNVTableAdapter.Connection.ConnectionString = Program.connstr;
            this.DSNVTableAdapter.Fill(this.DS_QLVT.DSNV);

            if (Program.mGroup == "CONGTY")
            {
                radioButton_chinhanh.Enabled = false;
                radioButton_user.Enabled = false;

                radioButton_CTY.Select();
            }
            else if (Program.mGroup == "CHINHANH")
            {
                radioButton_CTY.Enabled = false;
            }
        }

        private void button_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_taoTK_Click(object sender, EventArgs e)
        {
            if (!checkValidate(textBox_loginname, "Login name không được để trống!")) return;
            if (!checkValidate(textBox_password, "Password không được đẻ trống!")) return;
            if (!(radioButton_CTY.Checked || radioButton_chinhanh.Checked || radioButton_user.Checked))
            {
                MessageBox.Show("Role không được để trống!!", "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBox_loginname.Text.Contains(" "))
            {
                MessageBox.Show("Login name không được chứa khoảng trắng!", "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Program.conn.Open();
            string query = "DECLARE	@result int " +
                           "EXEC @result = SP_KIEMTRATAIKHOAN @p1, @p2 " +
                           "SELECT 'result' = @result";
            SqlCommand sqlCommand = new SqlCommand(query, Program.conn);
            sqlCommand.Parameters.AddWithValue("@p1", textBox_loginname.Text);
            sqlCommand.Parameters.AddWithValue("@p2", ComboBox_manv.SelectedValue.ToString());
            SqlDataReader dataReader = null;
            try
            {
                dataReader = sqlCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thực thi Database(1)!\n" + ex.Message, "Notification",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dataReader.Read();
            int resultCheckLogin = int.Parse(dataReader.GetValue(0).ToString());
            dataReader.Close();

            if (resultCheckLogin == 1)
            {
                MessageBox.Show("Login name bị trùng. Vui lòng chọn tên login khác!\n", "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_loginname.Focus();
                Program.conn.Close();
                return;
            }
            else if (resultCheckLogin == 2)
            {
                MessageBox.Show("User bị trùng. Vui lòng chọn mã nhân viên khác!\n", "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ComboBox_manv.Focus();
                Program.conn.Close();
                return;
            }
            else
            {
                String role = radioButton_CTY.Checked ? "CONGTY" : (radioButton_chinhanh.Checked ? "CHINHANH" : "USER");
                query = "DECLARE @result int " +
                           "EXEC @result = SP_TAOTAIKHOAN @p1, @p2, @p3, @p4 " +
                           "SELECT 'result' = @result";
                sqlCommand = new SqlCommand(query, Program.conn);
                sqlCommand.Parameters.AddWithValue("@p1", textBox_loginname.Text);
                sqlCommand.Parameters.AddWithValue("@p2", textBox_password.Text);
                sqlCommand.Parameters.AddWithValue("@p3", ComboBox_manv.SelectedValue.ToString());
                sqlCommand.Parameters.AddWithValue("@p4", role);
                try
                {
                    dataReader = sqlCommand.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thực thi Database()!\n" + ex.Message, "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                dataReader.Read();
                int result = int.Parse(dataReader.GetValue(0).ToString());
                dataReader.Close();
                if (result == 0)
                {
                    MessageBox.Show("Tạo tài khoản thành công!", "Notification",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox_loginname.Clear();
                    textBox_password.Clear();

                    radioButton_CTY.Checked = radioButton_chinhanh.Checked = radioButton_user.Checked = false;
                    textBox_loginname.Focus();
                }
                Program.conn.Close();
            }
        }

        private bool checkValidate(TextBox tb, string str)
        {
            if (tb.Text.Trim().Equals(""))
            {
                MessageBox.Show(str, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb.Focus();
                return false;
            }
            return true;
        }

        private void checkBox_show_CheckedChanged(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = (checkBox_show.Checked) ? false : true;
        }

        private void ComboBox_manv_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                textBox_username.Text = this.ComboBox_manv.SelectedValue.ToString();
            }
            catch (Exception) { }
        }
    }
}
