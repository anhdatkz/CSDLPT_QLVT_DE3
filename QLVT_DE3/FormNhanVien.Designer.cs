
namespace QLVT_DE3
{
    partial class FormNhanVien
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
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label lUONGLabel;
            System.Windows.Forms.Label mACNLabel;
            System.Windows.Forms.Label trangThaiXoaLabel;
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar_chucnang = new DevExpress.XtraBars.Bar();
            this.btn_them = new DevExpress.XtraBars.BarButtonItem();
            this.btn_xoa = new DevExpress.XtraBars.BarButtonItem();
            this.btn_sua = new DevExpress.XtraBars.BarButtonItem();
            this.btn_luu = new DevExpress.XtraBars.BarButtonItem();
            this.btn_undo = new DevExpress.XtraBars.BarButtonItem();
            this.btn_reload = new DevExpress.XtraBars.BarButtonItem();
            this.btn_chuyenCN = new DevExpress.XtraBars.BarButtonItem();
            this.btn_thoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.lapDH = new DevExpress.XtraBars.BarButtonItem();
            this.groupControl_chinhanh = new DevExpress.XtraEditors.GroupControl();
            this.comboBox_chinhanh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DS_QLVT = new QLVT_DE3.DS_QLVT();
            this.bds_nhanvien = new System.Windows.Forms.BindingSource(this.components);
            this.TableAdapter_nhanvien = new QLVT_DE3.DS_QLVTTableAdapters.NHANVIENTableAdapter();
            this.tableAdapterManager = new QLVT_DE3.DS_QLVTTableAdapters.TableAdapterManager();
            this.GridControl_nhanvien = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThaiXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl_nhanvien = new DevExpress.XtraEditors.GroupControl();
            this.TextEdit_manv = new DevExpress.XtraEditors.TextEdit();
            this.CheckBox_trangthaixoa = new System.Windows.Forms.CheckBox();
            this.TextEdit_macn = new DevExpress.XtraEditors.TextEdit();
            this.SpinEdit_luong = new DevExpress.XtraEditors.SpinEdit();
            this.DateTimePicker_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.TextEdit_diachi = new DevExpress.XtraEditors.TextEdit();
            this.TextEdit_ten = new DevExpress.XtraEditors.TextEdit();
            this.TextEdit_ho = new DevExpress.XtraEditors.TextEdit();
            mANVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            lUONGLabel = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            trangThaiXoaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_chinhanh)).BeginInit();
            this.groupControl_chinhanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS_QLVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_nhanvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl_nhanvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_nhanvien)).BeginInit();
            this.groupControl_nhanvien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_manv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_macn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpinEdit_luong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_diachi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_ten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_ho.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(245, 50);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(37, 13);
            mANVLabel.TabIndex = 0;
            mANVLabel.Text = "Mã NV";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(438, 51);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(20, 13);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "Họ";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(622, 50);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(25, 13);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "Tên";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(242, 85);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(39, 13);
            dIACHILabel.TabIndex = 6;
            dIACHILabel.Text = "Địa chỉ";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Location = new System.Drawing.Point(242, 119);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(54, 13);
            nGAYSINHLabel.TabIndex = 8;
            nGAYSINHLabel.Text = "Ngày sinh";
            // 
            // lUONGLabel
            // 
            lUONGLabel.AutoSize = true;
            lUONGLabel.Location = new System.Drawing.Point(622, 119);
            lUONGLabel.Name = "lUONGLabel";
            lUONGLabel.Size = new System.Drawing.Size(37, 13);
            lUONGLabel.TabIndex = 10;
            lUONGLabel.Text = "Lương";
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Location = new System.Drawing.Point(242, 153);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(38, 13);
            mACNLabel.TabIndex = 12;
            mACNLabel.Text = "Mã CN";
            // 
            // trangThaiXoaLabel
            // 
            trangThaiXoaLabel.AutoSize = true;
            trangThaiXoaLabel.Location = new System.Drawing.Point(622, 153);
            trangThaiXoaLabel.Name = "trangThaiXoaLabel";
            trangThaiXoaLabel.Size = new System.Drawing.Size(77, 13);
            trangThaiXoaLabel.TabIndex = 14;
            trangThaiXoaLabel.Text = "Trạng thái xóa";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar_chucnang});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_them,
            this.btn_xoa,
            this.btn_sua,
            this.btn_luu,
            this.btn_undo,
            this.btn_reload,
            this.btn_chuyenCN,
            this.lapDH,
            this.btn_thoat});
            this.barManager1.MainMenu = this.bar_chucnang;
            this.barManager1.MaxItemId = 9;
            // 
            // bar_chucnang
            // 
            this.bar_chucnang.BarName = "Main menu";
            this.bar_chucnang.DockCol = 0;
            this.bar_chucnang.DockRow = 0;
            this.bar_chucnang.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar_chucnang.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_them, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_xoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_sua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_luu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_undo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_reload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_chuyenCN, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_thoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar_chucnang.OptionsBar.MultiLine = true;
            this.bar_chucnang.OptionsBar.UseWholeRow = true;
            this.bar_chucnang.Text = "Main menu";
            // 
            // btn_them
            // 
            this.btn_them.Caption = "Thêm";
            this.btn_them.Id = 0;
            this.btn_them.ImageOptions.Image = global::QLVT_DE3.Properties.Resources.add_16x16;
            this.btn_them.ImageOptions.LargeImage = global::QLVT_DE3.Properties.Resources.add_32x32;
            this.btn_them.Name = "btn_them";
            this.btn_them.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.them_ItemClick);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Caption = "Xóa";
            this.btn_xoa.Id = 1;
            this.btn_xoa.ImageOptions.Image = global::QLVT_DE3.Properties.Resources.remove_16x16;
            this.btn_xoa.ImageOptions.LargeImage = global::QLVT_DE3.Properties.Resources.remove_32x32;
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.xoa_ItemClick);
            // 
            // btn_sua
            // 
            this.btn_sua.Caption = "Chỉnh sửa";
            this.btn_sua.Id = 2;
            this.btn_sua.ImageOptions.Image = global::QLVT_DE3.Properties.Resources.editname_16x16;
            this.btn_sua.ImageOptions.LargeImage = global::QLVT_DE3.Properties.Resources.editname_32x32;
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.chinhsua_ItemClick);
            // 
            // btn_luu
            // 
            this.btn_luu.Caption = "Lưu";
            this.btn_luu.Id = 3;
            this.btn_luu.ImageOptions.Image = global::QLVT_DE3.Properties.Resources.save_16x16;
            this.btn_luu.ImageOptions.LargeImage = global::QLVT_DE3.Properties.Resources.save_32x32;
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.luu_ItemClick);
            // 
            // btn_undo
            // 
            this.btn_undo.Caption = "Undo";
            this.btn_undo.Id = 4;
            this.btn_undo.ImageOptions.Image = global::QLVT_DE3.Properties.Resources.reset_16x16;
            this.btn_undo.ImageOptions.LargeImage = global::QLVT_DE3.Properties.Resources.reset_32x32;
            this.btn_undo.Name = "btn_undo";
            this.btn_undo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.undo_ItemClick);
            // 
            // btn_reload
            // 
            this.btn_reload.Caption = "Reload";
            this.btn_reload.Id = 5;
            this.btn_reload.ImageOptions.Image = global::QLVT_DE3.Properties.Resources.refresh_16x16;
            this.btn_reload.ImageOptions.LargeImage = global::QLVT_DE3.Properties.Resources.refresh_32x32;
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.reload_ItemClick);
            // 
            // btn_chuyenCN
            // 
            this.btn_chuyenCN.Caption = "Chuyển chi nhánh";
            this.btn_chuyenCN.Id = 6;
            this.btn_chuyenCN.ImageOptions.Image = global::QLVT_DE3.Properties.Resources.assignto_16x16;
            this.btn_chuyenCN.ImageOptions.LargeImage = global::QLVT_DE3.Properties.Resources.assignto_32x32;
            this.btn_chuyenCN.Name = "btn_chuyenCN";
            this.btn_chuyenCN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.chuyenCN_ItemClick);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Caption = "Thoát";
            this.btn_thoat.Id = 8;
            this.btn_thoat.ImageOptions.Image = global::QLVT_DE3.Properties.Resources.cancel_16x16;
            this.btn_thoat.ImageOptions.LargeImage = global::QLVT_DE3.Properties.Resources.cancel_32x32;
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.thoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1071, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 531);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1071, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 507);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1071, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 507);
            // 
            // lapDH
            // 
            this.lapDH.Caption = "Lập đơn hàng";
            this.lapDH.Id = 7;
            this.lapDH.ImageOptions.Image = global::QLVT_DE3.Properties.Resources.insert_16x16;
            this.lapDH.ImageOptions.LargeImage = global::QLVT_DE3.Properties.Resources.insert_32x32;
            this.lapDH.Name = "lapDH";
            // 
            // groupControl_chinhanh
            // 
            this.groupControl_chinhanh.Controls.Add(this.comboBox_chinhanh);
            this.groupControl_chinhanh.Controls.Add(this.label1);
            this.groupControl_chinhanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl_chinhanh.Location = new System.Drawing.Point(0, 24);
            this.groupControl_chinhanh.Name = "groupControl_chinhanh";
            this.groupControl_chinhanh.Size = new System.Drawing.Size(1071, 55);
            this.groupControl_chinhanh.TabIndex = 4;
            this.groupControl_chinhanh.Text = "Chi nhánh";
            // 
            // comboBox_chinhanh
            // 
            this.comboBox_chinhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_chinhanh.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_chinhanh.FormattingEnabled = true;
            this.comboBox_chinhanh.Location = new System.Drawing.Point(245, 26);
            this.comboBox_chinhanh.Name = "comboBox_chinhanh";
            this.comboBox_chinhanh.Size = new System.Drawing.Size(443, 25);
            this.comboBox_chinhanh.TabIndex = 1;
            this.comboBox_chinhanh.SelectedIndexChanged += new System.EventHandler(this.comboBox_chinhanh_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi nhánh";
            // 
            // DS_QLVT
            // 
            this.DS_QLVT.DataSetName = "DS_QLVT";
            this.DS_QLVT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bds_nhanvien
            // 
            this.bds_nhanvien.DataMember = "NHANVIEN";
            this.bds_nhanvien.DataSource = this.DS_QLVT;
            // 
            // TableAdapter_nhanvien
            // 
            this.TableAdapter_nhanvien.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DATHANGTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = this.TableAdapter_nhanvien;
            this.tableAdapterManager.PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.PHIEUXUATTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT_DE3.DS_QLVTTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // GridControl_nhanvien
            // 
            this.GridControl_nhanvien.DataSource = this.bds_nhanvien;
            this.GridControl_nhanvien.Dock = System.Windows.Forms.DockStyle.Top;
            this.GridControl_nhanvien.Location = new System.Drawing.Point(0, 79);
            this.GridControl_nhanvien.MainView = this.gridView1;
            this.GridControl_nhanvien.MenuManager = this.barManager1;
            this.GridControl_nhanvien.Name = "GridControl_nhanvien";
            this.GridControl_nhanvien.Size = new System.Drawing.Size(1071, 216);
            this.GridControl_nhanvien.TabIndex = 6;
            this.GridControl_nhanvien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colHO,
            this.colTEN,
            this.colDIACHI,
            this.colNGAYSINH,
            this.colLUONG,
            this.colMACN,
            this.colTrangThaiXoa});
            this.gridView1.GridControl = this.GridControl_nhanvien;
            this.gridView1.Name = "gridView1";
            // 
            // colMANV
            // 
            this.colMANV.Caption = "Mã VN";
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 0;
            // 
            // colHO
            // 
            this.colHO.Caption = "Họ";
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "Tên";
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "Địa chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.Caption = "Ngày sinh";
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 4;
            // 
            // colLUONG
            // 
            this.colLUONG.Caption = "Lương";
            this.colLUONG.FieldName = "LUONG";
            this.colLUONG.Name = "colLUONG";
            this.colLUONG.Visible = true;
            this.colLUONG.VisibleIndex = 5;
            // 
            // colMACN
            // 
            this.colMACN.Caption = "Mã CN";
            this.colMACN.FieldName = "MACN";
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 6;
            // 
            // colTrangThaiXoa
            // 
            this.colTrangThaiXoa.Caption = "Trạng thái xóa";
            this.colTrangThaiXoa.FieldName = "TrangThaiXoa";
            this.colTrangThaiXoa.Name = "colTrangThaiXoa";
            this.colTrangThaiXoa.Visible = true;
            this.colTrangThaiXoa.VisibleIndex = 7;
            // 
            // groupControl_nhanvien
            // 
            this.groupControl_nhanvien.Controls.Add(this.TextEdit_manv);
            this.groupControl_nhanvien.Controls.Add(trangThaiXoaLabel);
            this.groupControl_nhanvien.Controls.Add(this.CheckBox_trangthaixoa);
            this.groupControl_nhanvien.Controls.Add(mACNLabel);
            this.groupControl_nhanvien.Controls.Add(this.TextEdit_macn);
            this.groupControl_nhanvien.Controls.Add(lUONGLabel);
            this.groupControl_nhanvien.Controls.Add(this.SpinEdit_luong);
            this.groupControl_nhanvien.Controls.Add(nGAYSINHLabel);
            this.groupControl_nhanvien.Controls.Add(this.DateTimePicker_ngaysinh);
            this.groupControl_nhanvien.Controls.Add(dIACHILabel);
            this.groupControl_nhanvien.Controls.Add(this.TextEdit_diachi);
            this.groupControl_nhanvien.Controls.Add(tENLabel);
            this.groupControl_nhanvien.Controls.Add(this.TextEdit_ten);
            this.groupControl_nhanvien.Controls.Add(hOLabel);
            this.groupControl_nhanvien.Controls.Add(this.TextEdit_ho);
            this.groupControl_nhanvien.Controls.Add(mANVLabel);
            this.groupControl_nhanvien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl_nhanvien.Location = new System.Drawing.Point(0, 295);
            this.groupControl_nhanvien.Name = "groupControl_nhanvien";
            this.groupControl_nhanvien.Size = new System.Drawing.Size(1071, 236);
            this.groupControl_nhanvien.TabIndex = 7;
            this.groupControl_nhanvien.Text = "Thông tin nhân viên";
            // 
            // TextEdit_manv
            // 
            this.TextEdit_manv.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_nhanvien, "MANV", true));
            this.TextEdit_manv.Location = new System.Drawing.Point(306, 48);
            this.TextEdit_manv.MenuManager = this.barManager1;
            this.TextEdit_manv.Name = "TextEdit_manv";
            this.TextEdit_manv.Size = new System.Drawing.Size(115, 20);
            this.TextEdit_manv.TabIndex = 17;
            // 
            // CheckBox_trangthaixoa
            // 
            this.CheckBox_trangthaixoa.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bds_nhanvien, "TrangThaiXoa", true));
            this.CheckBox_trangthaixoa.Location = new System.Drawing.Point(705, 148);
            this.CheckBox_trangthaixoa.Name = "CheckBox_trangthaixoa";
            this.CheckBox_trangthaixoa.Size = new System.Drawing.Size(68, 24);
            this.CheckBox_trangthaixoa.TabIndex = 15;
            this.CheckBox_trangthaixoa.UseVisualStyleBackColor = true;
            // 
            // TextEdit_macn
            // 
            this.TextEdit_macn.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_nhanvien, "MACN", true));
            this.TextEdit_macn.Enabled = false;
            this.TextEdit_macn.Location = new System.Drawing.Point(306, 150);
            this.TextEdit_macn.MenuManager = this.barManager1;
            this.TextEdit_macn.Name = "TextEdit_macn";
            this.TextEdit_macn.Size = new System.Drawing.Size(115, 20);
            this.TextEdit_macn.TabIndex = 13;
            // 
            // SpinEdit_luong
            // 
            this.SpinEdit_luong.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_nhanvien, "LUONG", true));
            this.SpinEdit_luong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.SpinEdit_luong.Location = new System.Drawing.Point(664, 116);
            this.SpinEdit_luong.MenuManager = this.barManager1;
            this.SpinEdit_luong.Name = "SpinEdit_luong";
            this.SpinEdit_luong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SpinEdit_luong.Size = new System.Drawing.Size(109, 20);
            this.SpinEdit_luong.TabIndex = 11;
            // 
            // DateTimePicker_ngaysinh
            // 
            this.DateTimePicker_ngaysinh.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bds_nhanvien, "NGAYSINH", true));
            this.DateTimePicker_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePicker_ngaysinh.Location = new System.Drawing.Point(306, 115);
            this.DateTimePicker_ngaysinh.Name = "DateTimePicker_ngaysinh";
            this.DateTimePicker_ngaysinh.Size = new System.Drawing.Size(200, 21);
            this.DateTimePicker_ngaysinh.TabIndex = 9;
            // 
            // TextEdit_diachi
            // 
            this.TextEdit_diachi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_nhanvien, "DIACHI", true));
            this.TextEdit_diachi.Location = new System.Drawing.Point(306, 82);
            this.TextEdit_diachi.MenuManager = this.barManager1;
            this.TextEdit_diachi.Name = "TextEdit_diachi";
            this.TextEdit_diachi.Size = new System.Drawing.Size(467, 20);
            this.TextEdit_diachi.TabIndex = 7;
            // 
            // TextEdit_ten
            // 
            this.TextEdit_ten.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_nhanvien, "TEN", true));
            this.TextEdit_ten.Location = new System.Drawing.Point(664, 48);
            this.TextEdit_ten.MenuManager = this.barManager1;
            this.TextEdit_ten.Name = "TextEdit_ten";
            this.TextEdit_ten.Size = new System.Drawing.Size(109, 20);
            this.TextEdit_ten.TabIndex = 5;
            // 
            // TextEdit_ho
            // 
            this.TextEdit_ho.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bds_nhanvien, "HO", true));
            this.TextEdit_ho.Location = new System.Drawing.Point(470, 48);
            this.TextEdit_ho.MenuManager = this.barManager1;
            this.TextEdit_ho.Name = "TextEdit_ho";
            this.TextEdit_ho.Size = new System.Drawing.Size(130, 20);
            this.TextEdit_ho.TabIndex = 3;
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 531);
            this.Controls.Add(this.groupControl_nhanvien);
            this.Controls.Add(this.GridControl_nhanvien);
            this.Controls.Add(this.groupControl_chinhanh);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormNhanVien";
            this.Text = "FormNhanVien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_chinhanh)).EndInit();
            this.groupControl_chinhanh.ResumeLayout(false);
            this.groupControl_chinhanh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS_QLVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_nhanvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl_nhanvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_nhanvien)).EndInit();
            this.groupControl_nhanvien.ResumeLayout(false);
            this.groupControl_nhanvien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_manv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_macn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpinEdit_luong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_diachi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_ten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_ho.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar_chucnang;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btn_them;
        private DevExpress.XtraBars.BarButtonItem btn_xoa;
        private DevExpress.XtraBars.BarButtonItem btn_sua;
        private DevExpress.XtraBars.BarButtonItem btn_luu;
        private DevExpress.XtraBars.BarButtonItem btn_undo;
        private DevExpress.XtraBars.BarButtonItem btn_reload;
        private DevExpress.XtraBars.BarButtonItem btn_chuyenCN;
        private DevExpress.XtraBars.BarButtonItem lapDH;
        private DevExpress.XtraBars.BarButtonItem btn_thoat;
        private System.Windows.Forms.BindingSource bds_nhanvien;
        private DS_QLVT DS_QLVT;
        private DevExpress.XtraEditors.GroupControl groupControl_chinhanh;
        private System.Windows.Forms.ComboBox comboBox_chinhanh;
        private System.Windows.Forms.Label label1;
        private DS_QLVTTableAdapters.NHANVIENTableAdapter TableAdapter_nhanvien;
        private DS_QLVTTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl GridControl_nhanvien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl_nhanvien;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThaiXoa;
        private System.Windows.Forms.CheckBox CheckBox_trangthaixoa;
        private DevExpress.XtraEditors.TextEdit TextEdit_macn;
        private DevExpress.XtraEditors.SpinEdit SpinEdit_luong;
        private System.Windows.Forms.DateTimePicker DateTimePicker_ngaysinh;
        private DevExpress.XtraEditors.TextEdit TextEdit_diachi;
        private DevExpress.XtraEditors.TextEdit TextEdit_ten;
        private DevExpress.XtraEditors.TextEdit TextEdit_ho;
        private DevExpress.XtraEditors.TextEdit TextEdit_manv;
    }
}