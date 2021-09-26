using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLVT_DE3
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Boolean thoat = false;

        public FormMain()
        {
            InitializeComponent();
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            SqlDataReader myReader;

            String strLenh = "exec SP_DANGNHAP'" + Program.mlogin + "'";
            myReader = Program.ExecSqlDataReader(strLenh);
            if (myReader == null) return;
            myReader.Read();

            Program.username = myReader.GetString(0);
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Tài khoản của bạn không có quyền truy cập dữ liệu!\nVui lòng kiểm tra lại tài khoản!");
                return;
            }
            Program.mHoten = myReader.GetString(1);
            Program.mGroup = myReader.GetString(2);
            myReader.Close();
            Program.conn.Close();
            Program.frmChinh.manv.Text = "Mã nhân viên: " + Program.username;
            Program.frmChinh.hoten.Text = "Họ tên: " + Program.mHoten;
            Program.frmChinh.nhom.Text = "Nhóm: " + Program.mGroup;

            if (Program.mGroup == "USER")
            {
                btn_taikhoan.Enabled = false;   //Tắt nút Tạo tài khoản
            }
        }

        private void btn_nhanvien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormNhanVien));
            if (frm != null) frm.Activate();
            else
            {
                FormNhanVien f = new FormNhanVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btn_vattu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormVatTu));
            if (frm != null) frm.Activate();
            else
            {
                FormVatTu f = new FormVatTu();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btn_kho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormKho));
            if (frm != null) frm.Activate();
            else
            {
                FormKho f = new FormKho();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btn_taikhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormTaoTaiKhoan));
            if (frm != null) frm.Activate();
            else
            {
                FormTaoTaiKhoan f = new FormTaoTaiKhoan();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btn_lapdonhang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormDonHang));
            if (frm != null) frm.Activate();
            else
            {
                FormDonHang f = new FormDonHang();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btn_dangxuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            thoat = true;
            Program.frmChinh.Close();
            Program.loginForm.Visible = true;
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!thoat)
            {
                if (XtraMessageBox.Show("Bạn có thực sự muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
                else
                {
                    this.Dispose();
                    Program.loginForm.Close();
                }
            }
        }


    }
}
