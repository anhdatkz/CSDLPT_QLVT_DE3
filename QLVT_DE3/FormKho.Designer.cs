
namespace QLVT_DE3
{
    partial class FormKho
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
            System.Windows.Forms.Label mAKHOLabel;
            System.Windows.Forms.Label tENKHOLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label mACNLabel;
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btn_them = new DevExpress.XtraBars.BarButtonItem();
            this.btn_xoa = new DevExpress.XtraBars.BarButtonItem();
            this.btn_sua = new DevExpress.XtraBars.BarButtonItem();
            this.btn_luu = new DevExpress.XtraBars.BarButtonItem();
            this.btn_undo = new DevExpress.XtraBars.BarButtonItem();
            this.btn_reload = new DevExpress.XtraBars.BarButtonItem();
            this.btn_thoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.groupControl_chinhanh = new DevExpress.XtraEditors.GroupControl();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DS_QLVT = new QLVT_DE3.DS_QLVT();
            this.khoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khoTableAdapter = new QLVT_DE3.DS_QLVTTableAdapters.KhoTableAdapter();
            this.tableAdapterManager = new QLVT_DE3.DS_QLVTTableAdapters.TableAdapterManager();
            this.khoGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl_kho = new DevExpress.XtraEditors.GroupControl();
            this.TextEdit_makho = new DevExpress.XtraEditors.TextEdit();
            this.TextEdit_tenkho = new DevExpress.XtraEditors.TextEdit();
            this.TextEdit_diachi = new DevExpress.XtraEditors.TextEdit();
            this.TextEdit_macn = new DevExpress.XtraEditors.TextEdit();
            mAKHOLabel = new System.Windows.Forms.Label();
            tENKHOLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_chinhanh)).BeginInit();
            this.groupControl_chinhanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS_QLVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_kho)).BeginInit();
            this.groupControl_kho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_makho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_tenkho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_diachi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_macn.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
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
            this.btn_thoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_them, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_xoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_sua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_luu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_undo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_reload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_thoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btn_them
            // 
            this.btn_them.Caption = "Thêm";
            this.btn_them.Id = 0;
            this.btn_them.ImageOptions.Image = global::QLVT_DE3.Properties.Resources.add_16x162;
            this.btn_them.ImageOptions.LargeImage = global::QLVT_DE3.Properties.Resources.add_32x322;
            this.btn_them.Name = "btn_them";
            // 
            // btn_xoa
            // 
            this.btn_xoa.Caption = "Xóa";
            this.btn_xoa.Id = 1;
            this.btn_xoa.ImageOptions.Image = global::QLVT_DE3.Properties.Resources.remove_16x162;
            this.btn_xoa.ImageOptions.LargeImage = global::QLVT_DE3.Properties.Resources.remove_32x322;
            this.btn_xoa.Name = "btn_xoa";
            // 
            // btn_sua
            // 
            this.btn_sua.Caption = "Chỉnh sửa";
            this.btn_sua.Id = 2;
            this.btn_sua.ImageOptions.Image = global::QLVT_DE3.Properties.Resources.editname_16x162;
            this.btn_sua.ImageOptions.LargeImage = global::QLVT_DE3.Properties.Resources.editname_32x322;
            this.btn_sua.Name = "btn_sua";
            // 
            // btn_luu
            // 
            this.btn_luu.Caption = "Lưu";
            this.btn_luu.Id = 3;
            this.btn_luu.ImageOptions.Image = global::QLVT_DE3.Properties.Resources.saveto_16x161;
            this.btn_luu.ImageOptions.LargeImage = global::QLVT_DE3.Properties.Resources.saveto_32x321;
            this.btn_luu.Name = "btn_luu";
            // 
            // btn_undo
            // 
            this.btn_undo.Caption = "Undo";
            this.btn_undo.Id = 4;
            this.btn_undo.ImageOptions.Image = global::QLVT_DE3.Properties.Resources.reset_16x162;
            this.btn_undo.ImageOptions.LargeImage = global::QLVT_DE3.Properties.Resources.reset_32x322;
            this.btn_undo.Name = "btn_undo";
            // 
            // btn_reload
            // 
            this.btn_reload.Caption = "Reload";
            this.btn_reload.Id = 5;
            this.btn_reload.ImageOptions.Image = global::QLVT_DE3.Properties.Resources.refresh_16x162;
            this.btn_reload.ImageOptions.LargeImage = global::QLVT_DE3.Properties.Resources.refresh_32x322;
            this.btn_reload.Name = "btn_reload";
            // 
            // btn_thoat
            // 
            this.btn_thoat.Caption = "Thoát";
            this.btn_thoat.Id = 6;
            this.btn_thoat.ImageOptions.Image = global::QLVT_DE3.Properties.Resources.cancel_16x162;
            this.btn_thoat.ImageOptions.LargeImage = global::QLVT_DE3.Properties.Resources.cancel_32x322;
            this.btn_thoat.Name = "btn_thoat";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1076, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 475);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1076, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 451);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1076, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 451);
            // 
            // groupControl_chinhanh
            // 
            this.groupControl_chinhanh.Controls.Add(this.comboBox1);
            this.groupControl_chinhanh.Controls.Add(this.label1);
            this.groupControl_chinhanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl_chinhanh.Location = new System.Drawing.Point(0, 24);
            this.groupControl_chinhanh.Name = "groupControl_chinhanh";
            this.groupControl_chinhanh.Size = new System.Drawing.Size(1076, 55);
            this.groupControl_chinhanh.TabIndex = 4;
            this.groupControl_chinhanh.Text = "Chi nhánh";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(274, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(516, 25);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 27);
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
            // khoBindingSource
            // 
            this.khoBindingSource.DataMember = "Kho";
            this.khoBindingSource.DataSource = this.DS_QLVT;
            // 
            // khoTableAdapter
            // 
            this.khoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DATHANGTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = this.khoTableAdapter;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.PHIEUXUATTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT_DE3.DS_QLVTTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // khoGridControl
            // 
            this.khoGridControl.DataSource = this.khoBindingSource;
            this.khoGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.khoGridControl.Location = new System.Drawing.Point(0, 79);
            this.khoGridControl.MainView = this.gridView1;
            this.khoGridControl.MenuManager = this.barManager1;
            this.khoGridControl.Name = "khoGridControl";
            this.khoGridControl.Size = new System.Drawing.Size(1076, 220);
            this.khoGridControl.TabIndex = 16;
            this.khoGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAKHO,
            this.colTENKHO,
            this.colDIACHI,
            this.colMACN});
            this.gridView1.GridControl = this.khoGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMAKHO
            // 
            this.colMAKHO.Caption = "Mã kho";
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 0;
            // 
            // colTENKHO
            // 
            this.colTENKHO.Caption = "Tên kho";
            this.colTENKHO.FieldName = "TENKHO";
            this.colTENKHO.Name = "colTENKHO";
            this.colTENKHO.Visible = true;
            this.colTENKHO.VisibleIndex = 1;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "Địa chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 2;
            // 
            // colMACN
            // 
            this.colMACN.Caption = "Mã CN";
            this.colMACN.FieldName = "MACN";
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 3;
            // 
            // groupControl_kho
            // 
            this.groupControl_kho.Controls.Add(mACNLabel);
            this.groupControl_kho.Controls.Add(this.TextEdit_macn);
            this.groupControl_kho.Controls.Add(dIACHILabel);
            this.groupControl_kho.Controls.Add(this.TextEdit_diachi);
            this.groupControl_kho.Controls.Add(tENKHOLabel);
            this.groupControl_kho.Controls.Add(this.TextEdit_tenkho);
            this.groupControl_kho.Controls.Add(mAKHOLabel);
            this.groupControl_kho.Controls.Add(this.TextEdit_makho);
            this.groupControl_kho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl_kho.Location = new System.Drawing.Point(0, 299);
            this.groupControl_kho.Name = "groupControl_kho";
            this.groupControl_kho.Size = new System.Drawing.Size(1076, 176);
            this.groupControl_kho.TabIndex = 21;
            this.groupControl_kho.Text = "Thông tin kho";
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(232, 45);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(41, 13);
            mAKHOLabel.TabIndex = 0;
            mAKHOLabel.Text = "Mã kho";
            // 
            // TextEdit_makho
            // 
            this.TextEdit_makho.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khoBindingSource, "MAKHO", true));
            this.TextEdit_makho.Location = new System.Drawing.Point(285, 42);
            this.TextEdit_makho.MenuManager = this.barManager1;
            this.TextEdit_makho.Name = "TextEdit_makho";
            this.TextEdit_makho.Size = new System.Drawing.Size(100, 20);
            this.TextEdit_makho.TabIndex = 1;
            // 
            // tENKHOLabel
            // 
            tENKHOLabel.AutoSize = true;
            tENKHOLabel.Location = new System.Drawing.Point(415, 45);
            tENKHOLabel.Name = "tENKHOLabel";
            tENKHOLabel.Size = new System.Drawing.Size(45, 13);
            tENKHOLabel.TabIndex = 2;
            tENKHOLabel.Text = "Tên kho";
            // 
            // TextEdit_tenkho
            // 
            this.TextEdit_tenkho.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khoBindingSource, "TENKHO", true));
            this.TextEdit_tenkho.Location = new System.Drawing.Point(472, 42);
            this.TextEdit_tenkho.MenuManager = this.barManager1;
            this.TextEdit_tenkho.Name = "TextEdit_tenkho";
            this.TextEdit_tenkho.Size = new System.Drawing.Size(168, 20);
            this.TextEdit_tenkho.TabIndex = 3;
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(232, 85);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(39, 13);
            dIACHILabel.TabIndex = 4;
            dIACHILabel.Text = "Địa chỉ";
            // 
            // TextEdit_diachi
            // 
            this.TextEdit_diachi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khoBindingSource, "DIACHI", true));
            this.TextEdit_diachi.Location = new System.Drawing.Point(285, 82);
            this.TextEdit_diachi.MenuManager = this.barManager1;
            this.TextEdit_diachi.Name = "TextEdit_diachi";
            this.TextEdit_diachi.Size = new System.Drawing.Size(518, 20);
            this.TextEdit_diachi.TabIndex = 5;
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Location = new System.Drawing.Point(657, 45);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(38, 13);
            mACNLabel.TabIndex = 6;
            mACNLabel.Text = "Mã CN";
            // 
            // TextEdit_macn
            // 
            this.TextEdit_macn.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khoBindingSource, "MACN", true));
            this.TextEdit_macn.Location = new System.Drawing.Point(703, 42);
            this.TextEdit_macn.MenuManager = this.barManager1;
            this.TextEdit_macn.Name = "TextEdit_macn";
            this.TextEdit_macn.Size = new System.Drawing.Size(100, 20);
            this.TextEdit_macn.TabIndex = 7;
            // 
            // FormKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 475);
            this.Controls.Add(this.groupControl_kho);
            this.Controls.Add(this.khoGridControl);
            this.Controls.Add(this.groupControl_chinhanh);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormKho";
            this.Text = "FormKho";
            this.Load += new System.EventHandler(this.FormKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_chinhanh)).EndInit();
            this.groupControl_chinhanh.ResumeLayout(false);
            this.groupControl_chinhanh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS_QLVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_kho)).EndInit();
            this.groupControl_kho.ResumeLayout(false);
            this.groupControl_kho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_makho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_tenkho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_diachi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_macn.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btn_them;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btn_xoa;
        private DevExpress.XtraBars.BarButtonItem btn_sua;
        private DevExpress.XtraBars.BarButtonItem btn_luu;
        private DevExpress.XtraBars.BarButtonItem btn_undo;
        private DevExpress.XtraBars.BarButtonItem btn_reload;
        private DevExpress.XtraBars.BarButtonItem btn_thoat;
        private DevExpress.XtraEditors.GroupControl groupControl_chinhanh;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource khoBindingSource;
        private DS_QLVT DS_QLVT;
        private DS_QLVTTableAdapters.KhoTableAdapter khoTableAdapter;
        private DS_QLVTTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl khoGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKHO;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraEditors.GroupControl groupControl_kho;
        private DevExpress.XtraEditors.TextEdit TextEdit_macn;
        private DevExpress.XtraEditors.TextEdit TextEdit_diachi;
        private DevExpress.XtraEditors.TextEdit TextEdit_tenkho;
        private DevExpress.XtraEditors.TextEdit TextEdit_makho;
    }
}