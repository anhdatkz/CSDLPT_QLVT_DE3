
namespace QLVT_DE3
{
    partial class FormVatTu
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
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label tENVTLabel;
            System.Windows.Forms.Label dVTLabel;
            System.Windows.Forms.Label sOLUONGTONLabel;
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
            this.dS_QLVT = new QLVT_DE3.DS_QLVT();
            this.vattuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vattuTableAdapter = new QLVT_DE3.DS_QLVTTableAdapters.VattuTableAdapter();
            this.tableAdapterManager = new QLVT_DE3.DS_QLVTTableAdapters.TableAdapterManager();
            this.GridControl_vattu = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONGTON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl_vattu = new DevExpress.XtraEditors.GroupControl();
            this.SpinEdit_soluongton = new DevExpress.XtraEditors.SpinEdit();
            this.TextEdit_dvt = new DevExpress.XtraEditors.TextEdit();
            this.TextEdit_tenvt = new DevExpress.XtraEditors.TextEdit();
            this.TextEdit_mavt = new DevExpress.XtraEditors.TextEdit();
            mAVTLabel = new System.Windows.Forms.Label();
            tENVTLabel = new System.Windows.Forms.Label();
            dVTLabel = new System.Windows.Forms.Label();
            sOLUONGTONLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_QLVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl_vattu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_vattu)).BeginInit();
            this.groupControl_vattu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpinEdit_soluongton.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_dvt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_tenvt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_mavt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(191, 60);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(36, 13);
            mAVTLabel.TabIndex = 0;
            mAVTLabel.Text = "Mã VT";
            // 
            // tENVTLabel
            // 
            tENVTLabel.AutoSize = true;
            tENVTLabel.Location = new System.Drawing.Point(437, 57);
            tENVTLabel.Name = "tENVTLabel";
            tENVTLabel.Size = new System.Drawing.Size(40, 13);
            tENVTLabel.TabIndex = 2;
            tENVTLabel.Text = "Tên VT";
            // 
            // dVTLabel
            // 
            dVTLabel.AutoSize = true;
            dVTLabel.Location = new System.Drawing.Point(191, 96);
            dVTLabel.Name = "dVTLabel";
            dVTLabel.Size = new System.Drawing.Size(26, 13);
            dVTLabel.TabIndex = 4;
            dVTLabel.Text = "DVT";
            // 
            // sOLUONGTONLabel
            // 
            sOLUONGTONLabel.AutoSize = true;
            sOLUONGTONLabel.Location = new System.Drawing.Point(437, 100);
            sOLUONGTONLabel.Name = "sOLUONGTONLabel";
            sOLUONGTONLabel.Size = new System.Drawing.Size(68, 13);
            sOLUONGTONLabel.TabIndex = 6;
            sOLUONGTONLabel.Text = "Số lượng tồn";
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
            this.btn_them.ImageOptions.Image = global::QLVT_DE3.Properties.Resources.add_16x161;
            this.btn_them.ImageOptions.LargeImage = global::QLVT_DE3.Properties.Resources.add_32x321;
            this.btn_them.Name = "btn_them";
            // 
            // btn_xoa
            // 
            this.btn_xoa.Caption = "Xóa";
            this.btn_xoa.Id = 1;
            this.btn_xoa.ImageOptions.Image = global::QLVT_DE3.Properties.Resources.remove_16x161;
            this.btn_xoa.ImageOptions.LargeImage = global::QLVT_DE3.Properties.Resources.remove_32x321;
            this.btn_xoa.Name = "btn_xoa";
            // 
            // btn_sua
            // 
            this.btn_sua.Caption = "Chỉnh sửa";
            this.btn_sua.Id = 2;
            this.btn_sua.ImageOptions.Image = global::QLVT_DE3.Properties.Resources.editname_16x161;
            this.btn_sua.ImageOptions.LargeImage = global::QLVT_DE3.Properties.Resources.editname_32x321;
            this.btn_sua.Name = "btn_sua";
            // 
            // btn_luu
            // 
            this.btn_luu.Caption = "Lưu";
            this.btn_luu.Id = 3;
            this.btn_luu.ImageOptions.Image = global::QLVT_DE3.Properties.Resources.saveto_16x16;
            this.btn_luu.ImageOptions.LargeImage = global::QLVT_DE3.Properties.Resources.saveto_32x32;
            this.btn_luu.Name = "btn_luu";
            // 
            // btn_undo
            // 
            this.btn_undo.Caption = "Undo";
            this.btn_undo.Id = 4;
            this.btn_undo.ImageOptions.Image = global::QLVT_DE3.Properties.Resources.reset_16x161;
            this.btn_undo.ImageOptions.LargeImage = global::QLVT_DE3.Properties.Resources.reset_32x321;
            this.btn_undo.Name = "btn_undo";
            // 
            // btn_reload
            // 
            this.btn_reload.Caption = "Reload";
            this.btn_reload.Id = 5;
            this.btn_reload.ImageOptions.Image = global::QLVT_DE3.Properties.Resources.refresh_16x161;
            this.btn_reload.ImageOptions.LargeImage = global::QLVT_DE3.Properties.Resources.refresh_32x321;
            this.btn_reload.Name = "btn_reload";
            // 
            // btn_thoat
            // 
            this.btn_thoat.Caption = "Thoát";
            this.btn_thoat.Id = 6;
            this.btn_thoat.ImageOptions.Image = global::QLVT_DE3.Properties.Resources.cancel_16x161;
            this.btn_thoat.ImageOptions.LargeImage = global::QLVT_DE3.Properties.Resources.cancel_32x321;
            this.btn_thoat.Name = "btn_thoat";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1069, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 526);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1069, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 502);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1069, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 502);
            // 
            // dS_QLVT
            // 
            this.dS_QLVT.DataSetName = "DS_QLVT";
            this.dS_QLVT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vattuBindingSource
            // 
            this.vattuBindingSource.DataMember = "Vattu";
            this.vattuBindingSource.DataSource = this.dS_QLVT;
            // 
            // vattuTableAdapter
            // 
            this.vattuTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.PHIEUXUATTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT_DE3.DS_QLVTTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = this.vattuTableAdapter;
            // 
            // GridControl_vattu
            // 
            this.GridControl_vattu.DataSource = this.vattuBindingSource;
            this.GridControl_vattu.Dock = System.Windows.Forms.DockStyle.Top;
            this.GridControl_vattu.Location = new System.Drawing.Point(0, 24);
            this.GridControl_vattu.MainView = this.gridView1;
            this.GridControl_vattu.MenuManager = this.barManager1;
            this.GridControl_vattu.Name = "GridControl_vattu";
            this.GridControl_vattu.Size = new System.Drawing.Size(1069, 262);
            this.GridControl_vattu.TabIndex = 5;
            this.GridControl_vattu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAVT,
            this.colTENVT,
            this.colDVT,
            this.colSOLUONGTON});
            this.gridView1.GridControl = this.GridControl_vattu;
            this.gridView1.Name = "gridView1";
            // 
            // colMAVT
            // 
            this.colMAVT.Caption = "Mã VT";
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 0;
            // 
            // colTENVT
            // 
            this.colTENVT.Caption = "Tên VT";
            this.colTENVT.FieldName = "TENVT";
            this.colTENVT.Name = "colTENVT";
            this.colTENVT.Visible = true;
            this.colTENVT.VisibleIndex = 1;
            // 
            // colDVT
            // 
            this.colDVT.Caption = "Đơn vị tính";
            this.colDVT.FieldName = "DVT";
            this.colDVT.Name = "colDVT";
            this.colDVT.Visible = true;
            this.colDVT.VisibleIndex = 2;
            // 
            // colSOLUONGTON
            // 
            this.colSOLUONGTON.Caption = "Số lượng tồn";
            this.colSOLUONGTON.FieldName = "SOLUONGTON";
            this.colSOLUONGTON.Name = "colSOLUONGTON";
            this.colSOLUONGTON.Visible = true;
            this.colSOLUONGTON.VisibleIndex = 3;
            // 
            // groupControl_vattu
            // 
            this.groupControl_vattu.Controls.Add(sOLUONGTONLabel);
            this.groupControl_vattu.Controls.Add(this.SpinEdit_soluongton);
            this.groupControl_vattu.Controls.Add(dVTLabel);
            this.groupControl_vattu.Controls.Add(this.TextEdit_dvt);
            this.groupControl_vattu.Controls.Add(tENVTLabel);
            this.groupControl_vattu.Controls.Add(this.TextEdit_tenvt);
            this.groupControl_vattu.Controls.Add(mAVTLabel);
            this.groupControl_vattu.Controls.Add(this.TextEdit_mavt);
            this.groupControl_vattu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl_vattu.Location = new System.Drawing.Point(0, 286);
            this.groupControl_vattu.Name = "groupControl_vattu";
            this.groupControl_vattu.Size = new System.Drawing.Size(1069, 240);
            this.groupControl_vattu.TabIndex = 6;
            this.groupControl_vattu.Text = "Thông tin vật tư";
            // 
            // SpinEdit_soluongton
            // 
            this.SpinEdit_soluongton.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vattuBindingSource, "SOLUONGTON", true));
            this.SpinEdit_soluongton.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.SpinEdit_soluongton.Location = new System.Drawing.Point(508, 97);
            this.SpinEdit_soluongton.MenuManager = this.barManager1;
            this.SpinEdit_soluongton.Name = "SpinEdit_soluongton";
            this.SpinEdit_soluongton.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.SpinEdit_soluongton.Size = new System.Drawing.Size(217, 20);
            this.SpinEdit_soluongton.TabIndex = 7;
            // 
            // TextEdit_dvt
            // 
            this.TextEdit_dvt.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vattuBindingSource, "DVT", true));
            this.TextEdit_dvt.Location = new System.Drawing.Point(235, 93);
            this.TextEdit_dvt.MenuManager = this.barManager1;
            this.TextEdit_dvt.Name = "TextEdit_dvt";
            this.TextEdit_dvt.Size = new System.Drawing.Size(135, 20);
            this.TextEdit_dvt.TabIndex = 5;
            // 
            // TextEdit_tenvt
            // 
            this.TextEdit_tenvt.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vattuBindingSource, "TENVT", true));
            this.TextEdit_tenvt.Location = new System.Drawing.Point(508, 54);
            this.TextEdit_tenvt.MenuManager = this.barManager1;
            this.TextEdit_tenvt.Name = "TextEdit_tenvt";
            this.TextEdit_tenvt.Size = new System.Drawing.Size(217, 20);
            this.TextEdit_tenvt.TabIndex = 3;
            // 
            // TextEdit_mavt
            // 
            this.TextEdit_mavt.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vattuBindingSource, "MAVT", true));
            this.TextEdit_mavt.Location = new System.Drawing.Point(235, 57);
            this.TextEdit_mavt.MenuManager = this.barManager1;
            this.TextEdit_mavt.Name = "TextEdit_mavt";
            this.TextEdit_mavt.Size = new System.Drawing.Size(135, 20);
            this.TextEdit_mavt.TabIndex = 1;
            // 
            // FormVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 526);
            this.Controls.Add(this.groupControl_vattu);
            this.Controls.Add(this.GridControl_vattu);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormVatTu";
            this.Text = "FormVatTu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormVatTu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_QLVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl_vattu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_vattu)).EndInit();
            this.groupControl_vattu.ResumeLayout(false);
            this.groupControl_vattu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpinEdit_soluongton.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_dvt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_tenvt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEdit_mavt.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btn_them;
        private DevExpress.XtraBars.BarButtonItem btn_xoa;
        private DevExpress.XtraBars.BarButtonItem btn_sua;
        private DevExpress.XtraBars.BarButtonItem btn_luu;
        private DevExpress.XtraBars.BarButtonItem btn_undo;
        private DevExpress.XtraBars.BarButtonItem btn_reload;
        private DevExpress.XtraBars.BarButtonItem btn_thoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource vattuBindingSource;
        private DS_QLVT dS_QLVT;
        private DS_QLVTTableAdapters.VattuTableAdapter vattuTableAdapter;
        private DS_QLVTTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.GroupControl groupControl_vattu;
        private DevExpress.XtraEditors.SpinEdit SpinEdit_soluongton;
        private DevExpress.XtraEditors.TextEdit TextEdit_dvt;
        private DevExpress.XtraEditors.TextEdit TextEdit_tenvt;
        private DevExpress.XtraEditors.TextEdit TextEdit_mavt;
        private DevExpress.XtraGrid.GridControl GridControl_vattu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colTENVT;
        private DevExpress.XtraGrid.Columns.GridColumn colDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONGTON;
    }
}