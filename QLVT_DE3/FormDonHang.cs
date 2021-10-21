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
    public partial class FormDonHang : Form
    {
        public FormDonHang()
        {
            InitializeComponent();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void dATHANGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dATHANGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_QLVT);

        }

        private void FormDonHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_QLVT.CTPX' table. You can move, or remove it, as needed.
            this.cTPXTableAdapter.Fill(this.dS_QLVT.CTPX);
            // TODO: This line of code loads data into the 'dS_QLVT.PHIEUNHAP' table. You can move, or remove it, as needed.
            this.pHIEUNHAPTableAdapter.Fill(this.dS_QLVT.PHIEUNHAP);
            // TODO: This line of code loads data into the 'dS_QLVT.CTPN' table. You can move, or remove it, as needed.
            this.cTPNTableAdapter.Fill(this.dS_QLVT.CTPN);
            // TODO: This line of code loads data into the 'dS_QLVT.CTDDH' table. You can move, or remove it, as needed.
            this.cTDDHTableAdapter.Fill(this.dS_QLVT.CTDDH);
            // TODO: This line of code loads data into the 'dS_QLVT.PHIEUXUAT' table. You can move, or remove it, as needed.
            this.pHIEUXUATTableAdapter.Fill(this.dS_QLVT.PHIEUXUAT);
            // TODO: This line of code loads data into the 'dS_QLVT.DATHANG' table. You can move, or remove it, as needed.
            this.dATHANGTableAdapter.Fill(this.dS_QLVT.DATHANG);

        }

        private void masoDDHLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
