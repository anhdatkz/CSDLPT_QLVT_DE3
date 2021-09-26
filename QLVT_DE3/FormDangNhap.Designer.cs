
namespace QLVT_DE3
{
    partial class FormDangNhap
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
            System.Windows.Forms.Label tENKHOALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhap));
            this.groupControl_dangnhap = new DevExpress.XtraEditors.GroupControl();
            this.ComboBox_chinhanh = new System.Windows.Forms.ComboBox();
            this.v_DS_PHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DS_QLVT = new QLVT_DE3.DS_QLVT();
            this.checkBox_show = new System.Windows.Forms.CheckBox();
            this.button_thoat = new System.Windows.Forms.Button();
            this.button_dangnhap = new System.Windows.Forms.Button();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.v_DS_PHANMANHTableAdapter = new QLVT_DE3.DS_QLVTTableAdapters.V_DS_PHANMANHTableAdapter();
            this.tableAdapterManager = new QLVT_DE3.DS_QLVTTableAdapters.TableAdapterManager();
            tENKHOALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_dangnhap)).BeginInit();
            this.groupControl_dangnhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_QLVT)).BeginInit();
            this.SuspendLayout();
            // 
            // tENKHOALabel
            // 
            tENKHOALabel.AutoSize = true;
            tENKHOALabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENKHOALabel.Location = new System.Drawing.Point(58, 89);
            tENKHOALabel.Name = "tENKHOALabel";
            tENKHOALabel.Size = new System.Drawing.Size(71, 17);
            tENKHOALabel.TabIndex = 15;
            tENKHOALabel.Text = "Chi Nhánh";
            // 
            // groupControl_dangnhap
            // 
            this.groupControl_dangnhap.Controls.Add(this.ComboBox_chinhanh);
            this.groupControl_dangnhap.Controls.Add(tENKHOALabel);
            this.groupControl_dangnhap.Controls.Add(this.checkBox_show);
            this.groupControl_dangnhap.Controls.Add(this.button_thoat);
            this.groupControl_dangnhap.Controls.Add(this.button_dangnhap);
            this.groupControl_dangnhap.Controls.Add(this.textBox_password);
            this.groupControl_dangnhap.Controls.Add(this.textBox_username);
            this.groupControl_dangnhap.Controls.Add(this.label_password);
            this.groupControl_dangnhap.Controls.Add(this.label_username);
            this.groupControl_dangnhap.Location = new System.Drawing.Point(90, 40);
            this.groupControl_dangnhap.Name = "groupControl_dangnhap";
            this.groupControl_dangnhap.Size = new System.Drawing.Size(580, 344);
            this.groupControl_dangnhap.TabIndex = 1;
            this.groupControl_dangnhap.Text = "Đăng Nhập";
            // 
            // ComboBox_chinhanh
            // 
            this.ComboBox_chinhanh.DataSource = this.v_DS_PHANMANHBindingSource;
            this.ComboBox_chinhanh.DisplayMember = "TENCN";
            this.ComboBox_chinhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_chinhanh.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_chinhanh.FormattingEnabled = true;
            this.ComboBox_chinhanh.Location = new System.Drawing.Point(161, 86);
            this.ComboBox_chinhanh.Name = "ComboBox_chinhanh";
            this.ComboBox_chinhanh.Size = new System.Drawing.Size(307, 25);
            this.ComboBox_chinhanh.TabIndex = 16;
            this.ComboBox_chinhanh.ValueMember = "TENSERVER";
            this.ComboBox_chinhanh.SelectedIndexChanged += new System.EventHandler(this.ComboBox_chinhanh_SelectedIndexChanged);
            // 
            // v_DS_PHANMANHBindingSource
            // 
            this.v_DS_PHANMANHBindingSource.DataMember = "V_DS_PHANMANH";
            this.v_DS_PHANMANHBindingSource.DataSource = this.DS_QLVT;
            // 
            // DS_QLVT
            // 
            this.DS_QLVT.DataSetName = "DS_QLVT";
            this.DS_QLVT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkBox_show
            // 
            this.checkBox_show.AutoSize = true;
            this.checkBox_show.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_show.Location = new System.Drawing.Point(477, 197);
            this.checkBox_show.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_show.Name = "checkBox_show";
            this.checkBox_show.Size = new System.Drawing.Size(60, 21);
            this.checkBox_show.TabIndex = 15;
            this.checkBox_show.Text = "Show";
            this.checkBox_show.UseVisualStyleBackColor = true;
            this.checkBox_show.CheckedChanged += new System.EventHandler(this.checkBox_show_CheckedChanged);
            // 
            // button_thoat
            // 
            this.button_thoat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_thoat.Image = ((System.Drawing.Image)(resources.GetObject("button_thoat.Image")));
            this.button_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_thoat.Location = new System.Drawing.Point(364, 271);
            this.button_thoat.Margin = new System.Windows.Forms.Padding(4);
            this.button_thoat.Name = "button_thoat";
            this.button_thoat.Size = new System.Drawing.Size(104, 34);
            this.button_thoat.TabIndex = 14;
            this.button_thoat.Text = "Thoát";
            this.button_thoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_thoat.UseVisualStyleBackColor = true;
            this.button_thoat.Click += new System.EventHandler(this.button_thoat_Click);
            // 
            // button_dangnhap
            // 
            this.button_dangnhap.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dangnhap.Image = ((System.Drawing.Image)(resources.GetObject("button_dangnhap.Image")));
            this.button_dangnhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_dangnhap.Location = new System.Drawing.Point(161, 271);
            this.button_dangnhap.Margin = new System.Windows.Forms.Padding(4);
            this.button_dangnhap.Name = "button_dangnhap";
            this.button_dangnhap.Size = new System.Drawing.Size(104, 34);
            this.button_dangnhap.TabIndex = 13;
            this.button_dangnhap.Text = "Đăng Nhập";
            this.button_dangnhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_dangnhap.UseVisualStyleBackColor = true;
            this.button_dangnhap.Click += new System.EventHandler(this.button_dangnhap_Click);
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password.Location = new System.Drawing.Point(161, 195);
            this.textBox_password.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(307, 25);
            this.textBox_password.TabIndex = 12;
            this.textBox_password.UseSystemPasswordChar = true;
            // 
            // textBox_username
            // 
            this.textBox_username.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_username.Location = new System.Drawing.Point(161, 149);
            this.textBox_username.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(307, 25);
            this.textBox_username.TabIndex = 11;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.Location = new System.Drawing.Point(58, 196);
            this.label_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(66, 17);
            this.label_password.TabIndex = 10;
            this.label_password.Text = "Password";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_username.Location = new System.Drawing.Point(58, 150);
            this.label_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(69, 17);
            this.label_username.TabIndex = 9;
            this.label_username.Text = "Username";
            this.label_username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DATHANGTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.PHIEUXUATTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT_DE3.DS_QLVTTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // FormDanhNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupControl_dangnhap);
            this.Name = "FormDanhNhap";
            this.Text = "FormDanhNhap";
            this.Load += new System.EventHandler(this.FormDanhNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl_dangnhap)).EndInit();
            this.groupControl_dangnhap.ResumeLayout(false);
            this.groupControl_dangnhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_QLVT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl_dangnhap;
        private System.Windows.Forms.CheckBox checkBox_show;
        private System.Windows.Forms.Button button_thoat;
        private System.Windows.Forms.Button button_dangnhap;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_username;
        private DS_QLVT DS_QLVT;
        private System.Windows.Forms.BindingSource v_DS_PHANMANHBindingSource;
        private DS_QLVTTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private DS_QLVTTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox ComboBox_chinhanh;
    }
}