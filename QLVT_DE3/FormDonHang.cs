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

        private void dATHANGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dATHANGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_QLVT);

        }

        private void dATHANGBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.dATHANGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_QLVT);

        }

        private void dATHANGBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.dATHANGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_QLVT);

        }

        private void FormDonHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_QLVT.DATHANG' table. You can move, or remove it, as needed.
            this.dATHANGTableAdapter.Fill(this.dS_QLVT.DATHANG);

        }
    }
}
