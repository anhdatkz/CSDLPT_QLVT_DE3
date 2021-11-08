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

                //comboBox_khoa.Enabled = false;
            }
            else if (Program.mGroup == "CHINHANH")
            {
                radioButton_CTY.Enabled = false;
            }
        }

        private void button_taoTK_Click(object sender, EventArgs e)
        {
            if (!checkValidate(textBox_loginname, "Login name không được để trống!")) return;
            if (!checkValidate(textBox_password, "Password không được đẻ trống!")) return;
            if (!(radioButton_CTY.Checked || radioButton_chinhanh.Checked || radioButton_user.Checked || radioButton_user.Checked))
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
            sqlCommand.Parameters.AddWithValue("@p2", comboBox_username.SelectedValue.ToString());
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
                return;
            }
            else if (resultCheckLogin == 2)
            {
                MessageBox.Show("User bị trùng. Vui lòng chọn mã giáo viên khác!\n", "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox_username.Focus();
                return;
            }
            else
            {
                String role = radioButton_CTY.Checked ? "CONGTY" : (radioButton_chinhanh.Checked ? "CHINHANH" :"USER");
                query = "DECLARE @result int " +
                           "EXEC @result = SP_TAOTAIKHOAN @p1, @p2, @p3, @p4 " +
                           "SELECT 'result' = @result";
                sqlCommand = new SqlCommand(query, Program.conn);
                sqlCommand.Parameters.AddWithValue("@p1", textBox_loginname.Text);
                sqlCommand.Parameters.AddWithValue("@p2", textBox_password.Text);
                sqlCommand.Parameters.AddWithValue("@p3", comboBox_username.SelectedValue.ToString());
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
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void nHANVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.BDS_DSNV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS_QLVT);

        }

        private void checkBox_show_CheckedChanged(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = (checkBox_show.Checked) ? false : true;
        }

        private void dSNVBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.BDS_DSNV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS_QLVT);

        }

        private void dSNVBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.BDS_DSNV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS_QLVT);

        }
    }
}
