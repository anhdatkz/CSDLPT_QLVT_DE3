
namespace QLVT_DE3
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_nhanvien = new DevExpress.XtraBars.BarButtonItem();
            this.btn_vattu = new DevExpress.XtraBars.BarButtonItem();
            this.btn_kho = new DevExpress.XtraBars.BarButtonItem();
            this.btn_taikhoan = new DevExpress.XtraBars.BarButtonItem();
            this.btn_lapdonhang = new DevExpress.XtraBars.BarButtonItem();
            this.btn_dangxuat = new DevExpress.XtraBars.BarButtonItem();
            this.btn_dsnv = new DevExpress.XtraBars.BarButtonItem();
            this.btn_dsvt = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ctvt = new DevExpress.XtraBars.BarButtonItem();
            this.btn_dspn = new DevExpress.XtraBars.BarButtonItem();
            this.btn_hdnv = new DevExpress.XtraBars.BarButtonItem();
            this.btn_thnx = new DevExpress.XtraBars.BarButtonItem();
            this.rp_quanly = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rp_baocao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup11 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup12 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.manv = new System.Windows.Forms.ToolStripStatusLabel();
            this.hoten = new System.Windows.Forms.ToolStripStatusLabel();
            this.nhom = new System.Windows.Forms.ToolStripStatusLabel();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btn_nhanvien,
            this.btn_vattu,
            this.btn_kho,
            this.btn_taikhoan,
            this.btn_lapdonhang,
            this.btn_dangxuat,
            this.btn_dsnv,
            this.btn_dsvt,
            this.btn_ctvt,
            this.btn_dspn,
            this.btn_hdnv,
            this.btn_thnx});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 13;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rp_quanly,
            this.rp_baocao});
            this.ribbonControl1.Size = new System.Drawing.Size(1080, 158);
            // 
            // btn_nhanvien
            // 
            this.btn_nhanvien.Caption = "Nhân viên";
            this.btn_nhanvien.Id = 1;
            this.btn_nhanvien.ImageOptions.Image = global::QLVT_DE3.Properties.Resources.bodetails_16x16;
            this.btn_nhanvien.ImageOptions.LargeImage = global::QLVT_DE3.Properties.Resources.bodetails_32x32;
            this.btn_nhanvien.Name = "btn_nhanvien";
            this.btn_nhanvien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_nhanvien_ItemClick);
            // 
            // btn_vattu
            // 
            this.btn_vattu.Caption = "Vật tư";
            this.btn_vattu.Id = 2;
            this.btn_vattu.ImageOptions.Image = global::QLVT_DE3.Properties.Resources.boproductgroup_16x16;
            this.btn_vattu.ImageOptions.LargeImage = global::QLVT_DE3.Properties.Resources.boproductgroup_32x32;
            this.btn_vattu.Name = "btn_vattu";
            this.btn_vattu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_vattu_ItemClick);
            // 
            // btn_kho
            // 
            this.btn_kho.Caption = "Kho";
            this.btn_kho.Id = 3;
            this.btn_kho.ImageOptions.Image = global::QLVT_DE3.Properties.Resources.home_16x162;
            this.btn_kho.ImageOptions.LargeImage = global::QLVT_DE3.Properties.Resources.home_32x322;
            this.btn_kho.Name = "btn_kho";
            this.btn_kho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_kho_ItemClick);
            // 
            // btn_taikhoan
            // 
            this.btn_taikhoan.Caption = "Tạo tài khoản";
            this.btn_taikhoan.Id = 4;
            this.btn_taikhoan.ImageOptions.Image = global::QLVT_DE3.Properties.Resources.bouser_16x161;
            this.btn_taikhoan.ImageOptions.LargeImage = global::QLVT_DE3.Properties.Resources.bouser_32x321;
            this.btn_taikhoan.Name = "btn_taikhoan";
            this.btn_taikhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_taikhoan_ItemClick);
            // 
            // btn_lapdonhang
            // 
            this.btn_lapdonhang.Caption = "Đơn Hàng";
            this.btn_lapdonhang.Id = 5;
            this.btn_lapdonhang.ImageOptions.Image = global::QLVT_DE3.Properties.Resources.addgroupheader_16x16;
            this.btn_lapdonhang.ImageOptions.LargeImage = global::QLVT_DE3.Properties.Resources.addgroupheader_32x32;
            this.btn_lapdonhang.Name = "btn_lapdonhang";
            this.btn_lapdonhang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_lapdonhang_ItemClick);
            // 
            // btn_dangxuat
            // 
            this.btn_dangxuat.Caption = "Đăng xuất";
            this.btn_dangxuat.Id = 6;
            this.btn_dangxuat.ImageOptions.Image = global::QLVT_DE3.Properties.Resources.close_16x163;
            this.btn_dangxuat.ImageOptions.LargeImage = global::QLVT_DE3.Properties.Resources.close_32x323;
            this.btn_dangxuat.Name = "btn_dangxuat";
            this.btn_dangxuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_dangxuat_ItemClick);
            // 
            // btn_dsnv
            // 
            this.btn_dsnv.Caption = "Danh sách nhân viên";
            this.btn_dsnv.Id = 7;
            this.btn_dsnv.ImageOptions.Image = global::QLVT_DE3.Properties.Resources.groupheader_16x16;
            this.btn_dsnv.ImageOptions.LargeImage = global::QLVT_DE3.Properties.Resources.groupheader_32x32;
            this.btn_dsnv.Name = "btn_dsnv";
            // 
            // btn_dsvt
            // 
            this.btn_dsvt.Caption = "Danh sách vật tư";
            this.btn_dsvt.Id = 8;
            this.btn_dsvt.ImageOptions.Image = global::QLVT_DE3.Properties.Resources.boorderitem_16x16;
            this.btn_dsvt.ImageOptions.LargeImage = global::QLVT_DE3.Properties.Resources.boorderitem_32x32;
            this.btn_dsvt.Name = "btn_dsvt";
            // 
            // btn_ctvt
            // 
            this.btn_ctvt.Caption = "Chi tiết vật tư";
            this.btn_ctvt.Id = 9;
            this.btn_ctvt.ImageOptions.Image = global::QLVT_DE3.Properties.Resources.bofileattachment_16x16;
            this.btn_ctvt.ImageOptions.LargeImage = global::QLVT_DE3.Properties.Resources.bofileattachment_32x32;
            this.btn_ctvt.Name = "btn_ctvt";
            // 
            // btn_dspn
            // 
            this.btn_dspn.Caption = "DS đơn đặt hàng chưa lập PN";
            this.btn_dspn.Id = 10;
            this.btn_dspn.ImageOptions.Image = global::QLVT_DE3.Properties.Resources.boreport_16x16;
            this.btn_dspn.ImageOptions.LargeImage = global::QLVT_DE3.Properties.Resources.boreport_32x32;
            this.btn_dspn.Name = "btn_dspn";
            // 
            // btn_hdnv
            // 
            this.btn_hdnv.Caption = "Hoạt động nhân viên";
            this.btn_hdnv.Id = 11;
            this.btn_hdnv.ImageOptions.Image = global::QLVT_DE3.Properties.Resources.boresume_16x16;
            this.btn_hdnv.ImageOptions.LargeImage = global::QLVT_DE3.Properties.Resources.boresume_32x32;
            this.btn_hdnv.Name = "btn_hdnv";
            // 
            // btn_thnx
            // 
            this.btn_thnx.Caption = "Tổng hợp nhập xuất";
            this.btn_thnx.Id = 12;
            this.btn_thnx.ImageOptions.Image = global::QLVT_DE3.Properties.Resources.topbottomrules_16x16;
            this.btn_thnx.ImageOptions.LargeImage = global::QLVT_DE3.Properties.Resources.topbottomrules_32x32;
            this.btn_thnx.Name = "btn_thnx";
            // 
            // rp_quanly
            // 
            this.rp_quanly.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5,
            this.ribbonPageGroup6,
            this.ribbonPageGroup7});
            this.rp_quanly.Name = "rp_quanly";
            this.rp_quanly.Text = "Quản lý";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_nhanvien);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_vattu);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_kho);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btn_taikhoan);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btn_lapdonhang);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btn_dangxuat);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            // 
            // rp_baocao
            // 
            this.rp_baocao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup8,
            this.ribbonPageGroup9,
            this.ribbonPageGroup10,
            this.ribbonPageGroup11,
            this.ribbonPageGroup12});
            this.rp_baocao.Name = "rp_baocao";
            this.rp_baocao.Text = "Báo cáo";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_dsnv);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.btn_dsvt);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.ItemLinks.Add(this.btn_ctvt);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            // 
            // ribbonPageGroup10
            // 
            this.ribbonPageGroup10.ItemLinks.Add(this.btn_dspn);
            this.ribbonPageGroup10.Name = "ribbonPageGroup10";
            // 
            // ribbonPageGroup11
            // 
            this.ribbonPageGroup11.ItemLinks.Add(this.btn_hdnv);
            this.ribbonPageGroup11.Name = "ribbonPageGroup11";
            // 
            // ribbonPageGroup12
            // 
            this.ribbonPageGroup12.ItemLinks.Add(this.btn_thnx);
            this.ribbonPageGroup12.Name = "ribbonPageGroup12";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manv,
            this.hoten,
            this.nhom});
            this.statusStrip1.Location = new System.Drawing.Point(0, 547);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1080, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // manv
            // 
            this.manv.Name = "manv";
            this.manv.Size = new System.Drawing.Size(42, 17);
            this.manv.Text = "MANV";
            // 
            // hoten
            // 
            this.hoten.Name = "hoten";
            this.hoten.Size = new System.Drawing.Size(45, 17);
            this.hoten.Text = "HOTEN";
            // 
            // nhom
            // 
            this.nhom.Name = "nhom";
            this.nhom.Size = new System.Drawing.Size(45, 17);
            this.nhom.Text = "NHÓM";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 569);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "FormMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rp_quanly;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rp_baocao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btn_nhanvien;
        private DevExpress.XtraBars.BarButtonItem btn_vattu;
        private DevExpress.XtraBars.BarButtonItem btn_kho;
        private DevExpress.XtraBars.BarButtonItem btn_taikhoan;
        private DevExpress.XtraBars.BarButtonItem btn_lapdonhang;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel manv;
        private System.Windows.Forms.ToolStripStatusLabel hoten;
        private System.Windows.Forms.ToolStripStatusLabel nhom;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btn_dangxuat;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarButtonItem btn_dsnv;
        private DevExpress.XtraBars.BarButtonItem btn_dsvt;
        private DevExpress.XtraBars.BarButtonItem btn_ctvt;
        private DevExpress.XtraBars.BarButtonItem btn_dspn;
        private DevExpress.XtraBars.BarButtonItem btn_hdnv;
        private DevExpress.XtraBars.BarButtonItem btn_thnx;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup11;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup12;
    }
}

