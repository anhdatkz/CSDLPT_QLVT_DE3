using DevExpress.XtraEditors;
using System;
using System.Collections;
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
    public partial class FormNhanVien : Form
    {
        int vitri = 0;
        private string maCN = "";
        Stack list = new Stack();

        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void nHANVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bds_nhanvien.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS_QLVT);

        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            DS_QLVT.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'dS_QLVT.NHANVIEN' table. You can move, or remove it, as needed.
            this.TableAdapter_nhanvien.Connection.ConnectionString = Program.connstr;
            this.TableAdapter_nhanvien.Fill(this.DS_QLVT.NHANVIEN);

            maCN = ((DataRowView)bds_nhanvien[0])["MACN"].ToString();

            this.comboBox_chinhanh.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua

            comboBox_chinhanh.DisplayMember = "TENCN";
            comboBox_chinhanh.ValueMember = "TENSERVER";
            comboBox_chinhanh.SelectedIndex = Program.mchinhanh;

            if (Program.mGroup == "CONGTY")
            {
                comboBox_chinhanh.Enabled = true;  // bật tắt theo phân quyền
                btn_them.Enabled = btn_sua.Enabled = btn_luu.Enabled = false;
                btn_xoa.Enabled = btn_undo.Enabled = btn_reload.Enabled = btn_chuyenCN.Enabled = false;
            }
            else if (Program.mGroup == "CHINHANH")
            {
                groupControl_chinhanh.Visible = false;
            }
            else if (Program.mGroup == "USER")
            {
                groupControl_chinhanh.Visible = btn_chuyenCN.Enabled = false;
            }
            btn_them.Enabled = btn_xoa.Enabled = btn_sua.Enabled
                = btn_reload.Enabled = btn_thoat.Enabled = true;
            btn_luu.Enabled = false;
            TextEdit_macn.Enabled = false;
        }

        private void them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            comboBox_chinhanh.Enabled = false;
            vitri = bds_nhanvien.Position;
            GridControl_nhanvien.Enabled = false;
            btn_them.Enabled = btn_xoa.Enabled = btn_sua.Enabled
                = btn_reload.Enabled = btn_thoat.Enabled = false;

            groupControl_nhanvien.Enabled = true;
            btn_luu.Enabled = btn_undo.Enabled = TextEdit_manv.Enabled = TextEdit_ho.Enabled = TextEdit_ten.Enabled = true;
            TextEdit_diachi.Enabled = true;
            bds_nhanvien.AddNew();
            this.TextEdit_macn.EditValue = maCN;
        }

        private void xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*if (bds_sv.Count > 0)
            {
                XtraMessageBox.Show("Không thể xóa lớp này vì Lớp đã có sinh viên.", "", MessageBoxButtons.OK);
                return;
            }*/
            if (XtraMessageBox.Show("Bạn có thực sự muốn xóa Lớp này??", "Xác nhận.", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {

                    bds_nhanvien.RemoveCurrent();
                    this.TableAdapter_nhanvien.Connection.ConnectionString = Program.connstr;
                    this.TableAdapter_nhanvien.Update(this.DS_QLVT.NHANVIEN);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Lỗi xóa nhân viên.\nBạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.TableAdapter_nhanvien.Fill(this.DS_QLVT.NHANVIEN);
                    return;

                }
            }
            if (bds_nhanvien.Count == 0) btn_xoa.Enabled = false;

            GridControl_nhanvien.Enabled = true;
            btn_reload.Enabled = true;
            groupControl_nhanvien.Enabled = false;

            if (vitri > 0)
            {
                bds_nhanvien.Position = vitri;
            }
        }

        private void chinhsua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            comboBox_chinhanh.Enabled = false;
            vitri = bds_nhanvien.Position;
            GridControl_nhanvien.Enabled = false;
            btn_them.Enabled = btn_xoa.Enabled = btn_sua.Enabled
                = btn_reload.Enabled = btn_thoat.Enabled = false;

            groupControl_nhanvien.Enabled = true;
            btn_luu.Enabled = btn_undo.Enabled = TextEdit_manv.Enabled = TextEdit_ho.Enabled = TextEdit_ten.Enabled = true;
            TextEdit_diachi.Enabled = true;
            TextEdit_manv.Enabled = false;
        }

        private void luu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (TextEdit_manv.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhân viên không được để trống!", "", MessageBoxButtons.OK);
                TextEdit_manv.Focus();
                return;
            }
            if (TextEdit_ho.Text.Trim() == "")
            {
                MessageBox.Show("Họ không được để trống!", "", MessageBoxButtons.OK);
                TextEdit_ho.Focus();
                return;
            }

            if (TextEdit_ten.Text.Trim() == "")
            {
                MessageBox.Show("Họ không được để trống!", "", MessageBoxButtons.OK);
                TextEdit_ten.Focus();
                return;
            }

            try
            {
                bds_nhanvien.EndEdit();
                bds_nhanvien.ResetCurrentItem();
                this.TableAdapter_nhanvien.Connection.ConnectionString = Program.connstr;
                this.TableAdapter_nhanvien.Update(this.DS_QLVT.NHANVIEN);
                MessageBox.Show("Lưu thông tin lớp vào CSDL thành công!", "Notification",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                GridControl_nhanvien.Enabled = true;
                groupControl_nhanvien.Enabled = btn_luu.Enabled = false;
                btn_them.Enabled = btn_xoa.Enabled = btn_sua.Enabled
                     = btn_reload.Enabled = btn_thoat.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi! Không thể lưu thông tin vào CSDL!.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void undo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (list.Count > 0)
            {
                String statement = list.Pop().ToString();
                if (statement.Equals("DELETE"))
                {
                    //btnThem.Enabled = btnXoa.Enabled = nhanVienGridControl.Enabled = btnReload.Enabled = btnThoat.Enabled = false;
                    //btnUndo.Enabled = gcInfoNhanVien.Enabled = btnGhi.Enabled = true;
                    this.bds_nhanvien.AddNew();
                    String TT = list.Pop().ToString();
                    String[] TT_NV = TT.Split('#');
                    TextEdit_manv.Text = TT_NV[0];
                    TextEdit_ho.Text = TT_NV[1];
                    TextEdit_ten.Text = TT_NV[2];
                    TextEdit_macn.Text = TT_NV[3];
                    DateTimePicker_ngaysinh.Text = TT_NV[4];
                    TextEdit_diachi.Text = TT_NV[5];
                    SpinEdit_luong.Text = TT_NV[6];
                    CheckBox_trangthaixoa.Checked = false;
                    this.bds_nhanvien.EndEdit();
                    this.TableAdapter_nhanvien.Update(this.DS_QLVT.NHANVIEN);
                }
                else if (statement.Equals("INSERT"))
                {
                    String maNV = list.Pop().ToString();
                    int vitrixoa = bds_nhanvien.Find("MANV", maNV);
                    bds_nhanvien.Position = vitrixoa;
                    bds_nhanvien.RemoveCurrent();
                }
                else if (statement.Equals("CHUYENCN"))
                {
                    String info = list.Pop().ToString();
                    String[] info_CN = info.Split('#');
                    Console.WriteLine(info_CN[0] + " " + info_CN[1]);
                    String servername_temp = Program.servername;

                    Program.servername = info_CN[1].ToString();

                    Program.mlogin = Program.remotelogin;
                    Program.password = Program.remotepassword;


                    if (Program.KetNoi() == 0)
                        MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
                    String maNV = info_CN[0].ToString();
                    String maCN = "";
                    if (info_CN[1].ToString().Contains("2")) maCN = "CN1";
                    else if (info_CN[1].ToString().Contains("1")) maCN = "CN2";
                    Program.conn = new SqlConnection(Program.connstr);
                    Program.conn.Open();
                    SqlCommand cmd = new SqlCommand("SP_CHUYENCHINHANH_NV", Program.conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@MANV", maNV));
                    cmd.Parameters.Add(new SqlParameter("@MACN", maCN));
                    SqlDataReader myReader = null;
                    try
                    {
                        myReader = cmd.ExecuteReader();
                        MessageBox.Show("Chuyển nhân viên trở về thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.TableAdapter_nhanvien.Fill(this.DS_QLVT.NHANVIEN);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        if (Program.servername != servername_temp)
                        {
                            Program.servername = servername_temp;
                            Program.mlogin = Program.mloginDN;
                            Program.password = Program.passwordDN;
                            if (Program.KetNoi() == 0)
                                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
                        }

                    }

                }
                this.TableAdapter_nhanvien.Update(this.DS_QLVT.NHANVIEN);
            }
            if (list.Count == 0) btn_undo.Enabled = false;
        }

        private void reload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.TableAdapter_nhanvien.Fill(this.DS_QLVT.NHANVIEN);
                btn_luu.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi làm mới! :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void chuyenCN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void comboBox_chinhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox_chinhanh.ValueMember != "")   //Xử lý trường hợp Event autorun khi vừa khởi chạy project
            {
                if (comboBox_chinhanh.SelectedValue.ToString() == "System.Data.DataRowView")
                    return;
                Program.servername = comboBox_chinhanh.SelectedValue.ToString();

                if (comboBox_chinhanh.SelectedIndex != Program.mchinhanh)
                {
                    Program.mlogin = Program.remotelogin;
                    Program.password = Program.remotepassword;
                }
                else
                {
                    Program.mlogin = Program.mloginDN;
                    Program.password = Program.passwordDN;
                }
                if (Program.KetNoi() == 0)
                    MessageBox.Show("Lỗi kết nối đến chi nhánh mới!", "", MessageBoxButtons.OK);
                else
                {
                    this.TableAdapter_nhanvien.Connection.ConnectionString = Program.connstr;
                    this.TableAdapter_nhanvien.Fill(this.DS_QLVT.NHANVIEN);

                    maCN = ((DataRowView)bds_nhanvien[0])["MACN"].ToString();
                }
            }
        }
    }
}
