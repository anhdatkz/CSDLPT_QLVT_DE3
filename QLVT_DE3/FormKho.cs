﻿using System;
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
        public FormKho()
        {
            InitializeComponent();
        }

        private void khoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.khoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS_QLVT);

        }

        private void FormKho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_QLVT.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Fill(this.dS_QLVT.Kho);

        }
    }
}