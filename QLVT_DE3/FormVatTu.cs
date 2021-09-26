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
    public partial class FormVatTu : Form
    {
        public FormVatTu()
        {
            InitializeComponent();
        }

        private void vattuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vattuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_QLVT);

        }

        private void FormVatTu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_QLVT.Vattu' table. You can move, or remove it, as needed.
            this.vattuTableAdapter.Fill(this.dS_QLVT.Vattu);

        }
    }
}
