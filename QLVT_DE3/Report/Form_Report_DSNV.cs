using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT_DE3.Report
{
    public partial class Form_Report_DSNV : Form
    {
        private string maCN = "";
        public Form_Report_DSNV()
        {
            InitializeComponent();
        }

        private void Form_Report_DSNV_Load(object sender, EventArgs e)
        {
            DS_QLVT.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS_QLVT.ChiNhanh' table. You can move, or remove it, as needed.
            this.TableAdapter_nhanvien.Connection.ConnectionString = Program.connstr;
            this.chiNhanhTableAdapter.Fill(this.DS_QLVT.ChiNhanh);

            //maCN = ((DataRowView)bds_nhanvien[0])["MACN"].ToString();

            this.comboBox_chinhanh.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua

            comboBox_chinhanh.DisplayMember = "TENCN";
            comboBox_chinhanh.ValueMember = "TENSERVER";
            comboBox_chinhanh.SelectedIndex = Program.mchinhanh;
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
                }
            }
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            Report_DSNV report = new Report_DSNV();
            report.xrLabel_chinhanh.Text = this.comboBox_chinhanh.SelectedValue.ToString();
            ReportPrintTool print = new ReportPrintTool(report);
            print.ShowPreviewDialog();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
