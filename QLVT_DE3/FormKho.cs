using DevExpress.XtraEditors;
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
    public partial class FormKho : Form
    {
        int vitri = 0;
        private string maCN = "";
        /*Stack list = new Stack();*/

        public FormKho()
        {
            InitializeComponent();
        }

        private void khoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.khoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS_QLVT);

        }

        private void FormKho_Load(object sender, EventArgs e)
        {
            DS_QLVT.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS_QLVT.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Fill(this.DS_QLVT.Kho);

            maCN = ((DataRowView)khoBindingSource[0])["MACN"].ToString();

            this.comboBoxChinNhanh.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua

            comboBoxChinNhanh.DisplayMember = "TENCN";
            comboBoxChinNhanh.ValueMember = "TENSERVER";
            comboBoxChinNhanh.SelectedIndex = Program.mchinhanh;

            if (Program.mGroup == "CONGTY")
            {
                comboBoxChinNhanh.Enabled = true;  // bật tắt theo phân quyền
                btn_them.Enabled = btn_sua.Enabled = btn_luu.Enabled = false;
                btn_xoa.Enabled = btn_undo.Enabled = btn_reload.Enabled = false;
            }
            else if (Program.mGroup == "CHINHANH")
            {
                groupControl_chinhanh.Visible = false;
            }
            else if (Program.mGroup == "USER")
            {
                groupControl_chinhanh.Visible= false;
            }
            btn_them.Enabled = btn_xoa.Enabled = btn_sua.Enabled
                = btn_reload.Enabled = btn_thoat.Enabled = true;
            btn_luu.Enabled = false;
            TextEdit_macn.Enabled = false;


            ///Chưa phân hoạch lại quyền ở chưc năng qquản kho
        }

        private void khoBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.khoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS_QLVT);
        }

        private void btn_them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            comboBoxChinNhanh.Enabled = false;
            btn_reload.Enabled = btn_them.Enabled = btn_sua.Enabled = btn_thoat.Enabled
                = btn_xoa.Enabled = btn_undo.Enabled =TextEdit_macn.Enabled = false;
            vitri = khoBindingSource.Position;
            khoGridControl.Enabled = false;

            btn_luu.Enabled = btn_undo.Enabled = TextEdit_makho.Enabled = TextEdit_tenkho.Enabled = true;
            TextEdit_diachi.Enabled = true;

            khoBindingSource.AddNew();

            this.TextEdit_macn.EditValue = maCN;
        }

        private void btn_xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có thực sự muốn xóa nhân viên này??", "Xác nhận.", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    khoBindingSource.RemoveCurrent();
                    this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.khoTableAdapter.Update(this.DS_QLVT.Kho);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Lỗi xóa nhân viên.\nBạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.khoTableAdapter.Fill(this.DS_QLVT.Kho);
                    return;

                }

                if (khoBindingSource.Count == 0) btn_xoa.Enabled = false;

                khoGridControl.Enabled = true;
                btn_reload.Enabled = true;
                groupControl_kho.Enabled = false;

                if (vitri > 0)
                {
                    khoBindingSource.Position = vitri;
                }
            }

            //chưa check kĩ
        }

        private void btn_sua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            comboBoxChinNhanh.Enabled = false;
            vitri = khoBindingSource.Position;
            khoGridControl.Enabled = false;
            btn_them.Enabled = btn_xoa.Enabled = btn_sua.Enabled
                = btn_reload.Enabled = btn_thoat.Enabled = false;

            groupControl_chinhanh.Enabled = true;
            btn_luu.Enabled = btn_undo.Enabled = TextEdit_makho.Enabled = TextEdit_tenkho.Enabled = TextEdit_diachi.Enabled = true;
            TextEdit_diachi.Enabled = true;
            TextEdit_makho.Enabled = TextEdit_macn.Enabled = false;
        }

        private void btn_luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TextEdit_makho.Text.Trim() == "")
            {
                MessageBox.Show("Mã kho không được để trống!", "", MessageBoxButtons.OK);
                TextEdit_makho.Focus();
                return;
            }
            else if (TextEdit_tenkho.Text.Trim() == "")
            {
                MessageBox.Show("Tên kho không được để trống!", "", MessageBoxButtons.OK);
                TextEdit_makho.Focus();
                return;
            }
            else if (TextEdit_diachi.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ không được để trống!", "", MessageBoxButtons.OK);
                TextEdit_makho.Focus();
                return;
            }
            else if (TextEdit_macn.Text.Trim() == "")
            {
                MessageBox.Show("Mã chi nhánh không được để trống!", "", MessageBoxButtons.OK);
                TextEdit_makho.Focus();
                return;
            }

            else
            {
                try
                {
                    khoBindingSource.EndEdit();
                    khoBindingSource.ResetCurrentItem();
                    this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.khoTableAdapter.Update(this.DS_QLVT.Kho);
                    MessageBox.Show("Lưu thông tin thành công!", "Notification",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);

                    khoGridControl.Enabled = true;
                    groupControl_kho.Enabled = btn_luu.Enabled = false;
                    btn_them.Enabled = btn_xoa.Enabled = btn_sua.Enabled
                     = btn_reload.Enabled = btn_thoat.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi! Không thể lưu thông tin vào CSDL!.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void btn_undo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            
        }

        private void btn_reload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.khoTableAdapter.Fill(this.DS_QLVT.Kho);
                btn_luu.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi làm mới! :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btn_thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
