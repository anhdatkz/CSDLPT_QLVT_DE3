using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLVT_DE3.Report
{
    public partial class Report_DSNV : DevExpress.XtraReports.UI.XtraReport
    {
        public Report_DSNV()
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Fill();
        }

    }
}
