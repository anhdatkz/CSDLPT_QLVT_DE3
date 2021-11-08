
namespace QLVT_DE3
{
    partial class FormTaoTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTaoTaiKhoan));
            this.checkBox_show = new System.Windows.Forms.CheckBox();
            this.button_taoTK = new System.Windows.Forms.Button();
            this.radioButton_user = new System.Windows.Forms.RadioButton();
            this.radioButton_chinhanh = new System.Windows.Forms.RadioButton();
            this.radioButton_CTY = new System.Windows.Forms.RadioButton();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_role = new DevExpress.XtraEditors.LabelControl();
            this.label_user = new DevExpress.XtraEditors.LabelControl();
            this.label_password = new DevExpress.XtraEditors.LabelControl();
            this.textBox_loginname = new System.Windows.Forms.TextBox();
            this.Label_login = new DevExpress.XtraEditors.LabelControl();
            this.button1 = new System.Windows.Forms.Button();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.DS_QLVT = new QLVT_DE3.DS_QLVT();
            this.BDS_DSNV = new System.Windows.Forms.BindingSource(this.components);
            this.DSNVTableAdapter = new QLVT_DE3.DS_QLVTTableAdapters.DSNVTableAdapter();
            this.tableAdapterManager = new QLVT_DE3.DS_QLVTTableAdapters.TableAdapterManager();
            this.comboBox_username = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DS_QLVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDS_DSNV)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox_show
            // 
            this.checkBox_show.AutoSize = true;
            this.checkBox_show.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_show.Location = new System.Drawing.Point(618, 217);
            this.checkBox_show.Name = "checkBox_show";
            this.checkBox_show.Size = new System.Drawing.Size(60, 21);
            this.checkBox_show.TabIndex = 27;
            this.checkBox_show.Text = "Show";
            this.checkBox_show.UseVisualStyleBackColor = true;
            this.checkBox_show.CheckedChanged += new System.EventHandler(this.checkBox_show_CheckedChanged);
            // 
            // button_taoTK
            // 
            this.button_taoTK.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_taoTK.Location = new System.Drawing.Point(304, 367);
            this.button_taoTK.Name = "button_taoTK";
            this.button_taoTK.Size = new System.Drawing.Size(115, 30);
            this.button_taoTK.TabIndex = 26;
            this.button_taoTK.Text = "Tạo Tài khoản";
            this.button_taoTK.UseVisualStyleBackColor = true;
            this.button_taoTK.Click += new System.EventHandler(this.button_taoTK_Click);
            // 
            // radioButton_user
            // 
            this.radioButton_user.AutoSize = true;
            this.radioButton_user.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_user.Location = new System.Drawing.Point(538, 311);
            this.radioButton_user.Name = "radioButton_user";
            this.radioButton_user.Size = new System.Drawing.Size(55, 21);
            this.radioButton_user.TabIndex = 25;
            this.radioButton_user.TabStop = true;
            this.radioButton_user.Text = "User";
            this.radioButton_user.UseVisualStyleBackColor = true;
            // 
            // radioButton_chinhanh
            // 
            this.radioButton_chinhanh.AutoSize = true;
            this.radioButton_chinhanh.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_chinhanh.Location = new System.Drawing.Point(405, 311);
            this.radioButton_chinhanh.Name = "radioButton_chinhanh";
            this.radioButton_chinhanh.Size = new System.Drawing.Size(85, 21);
            this.radioButton_chinhanh.TabIndex = 24;
            this.radioButton_chinhanh.TabStop = true;
            this.radioButton_chinhanh.Text = "Chi nhánh";
            this.radioButton_chinhanh.UseVisualStyleBackColor = true;
            // 
            // radioButton_CTY
            // 
            this.radioButton_CTY.AutoSize = true;
            this.radioButton_CTY.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_CTY.Location = new System.Drawing.Point(304, 311);
            this.radioButton_CTY.Name = "radioButton_CTY";
            this.radioButton_CTY.Size = new System.Drawing.Size(72, 21);
            this.radioButton_CTY.TabIndex = 23;
            this.radioButton_CTY.TabStop = true;
            this.radioButton_CTY.Text = "Công ty";
            this.radioButton_CTY.UseVisualStyleBackColor = true;
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password.Location = new System.Drawing.Point(304, 215);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(289, 25);
            this.textBox_password.TabIndex = 20;
            this.textBox_password.UseSystemPasswordChar = true;
            // 
            // label_role
            // 
            this.label_role.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_role.Appearance.Options.UseFont = true;
            this.label_role.Location = new System.Drawing.Point(254, 311);
            this.label_role.Name = "label_role";
            this.label_role.Size = new System.Drawing.Size(30, 17);
            this.label_role.TabIndex = 19;
            this.label_role.Text = "Role:";
            // 
            // label_user
            // 
            this.label_user.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_user.Appearance.Options.UseFont = true;
            this.label_user.Location = new System.Drawing.Point(220, 258);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(64, 17);
            this.label_user.TabIndex = 18;
            this.label_user.Text = "Username:";
            // 
            // label_password
            // 
            this.label_password.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.Appearance.Options.UseFont = true;
            this.label_password.Location = new System.Drawing.Point(223, 219);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(61, 17);
            this.label_password.TabIndex = 17;
            this.label_password.Text = "Password:";
            // 
            // textBox_loginname
            // 
            this.textBox_loginname.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_loginname.Location = new System.Drawing.Point(304, 167);
            this.textBox_loginname.Name = "textBox_loginname";
            this.textBox_loginname.Size = new System.Drawing.Size(289, 25);
            this.textBox_loginname.TabIndex = 16;
            // 
            // Label_login
            // 
            this.Label_login.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_login.Appearance.Options.UseFont = true;
            this.Label_login.Location = new System.Drawing.Point(208, 172);
            this.Label_login.Name = "Label_login";
            this.Label_login.Size = new System.Drawing.Size(76, 17);
            this.Label_login.TabIndex = 15;
            this.Label_login.Text = "Login Name:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(478, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 30);
            this.button1.TabIndex = 28;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("labelControl1.ImageOptions.Image")));
            this.labelControl1.Location = new System.Drawing.Point(385, 56);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(105, 104);
            this.labelControl1.TabIndex = 29;
            // 
            // textBox_username
            // 
            this.textBox_username.Enabled = false;
            this.textBox_username.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_username.Location = new System.Drawing.Point(618, 253);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(46, 25);
            this.textBox_username.TabIndex = 30;
            // 
            // DS_QLVT
            // 
            this.DS_QLVT.DataSetName = "DS_QLVT";
            this.DS_QLVT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BDS_DSNV
            // 
            this.BDS_DSNV.DataMember = "DSNV";
            this.BDS_DSNV.DataSource = this.DS_QLVT;
            // 
            // DSNVTableAdapter
            // 
            this.DSNVTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DATHANGTableAdapter = null;
            this.tableAdapterManager.DSNVTableAdapter = this.DSNVTableAdapter;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.PHIEUXUATTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT_DE3.DS_QLVTTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // comboBox_username
            // 
            this.comboBox_username.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BDS_DSNV, "HOTEN", true));
            this.comboBox_username.DataSource = this.BDS_DSNV;
            this.comboBox_username.DisplayMember = "HOTEN";
            this.comboBox_username.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_username.FormattingEnabled = true;
            this.comboBox_username.Location = new System.Drawing.Point(304, 257);
            this.comboBox_username.Name = "comboBox_username";
            this.comboBox_username.Size = new System.Drawing.Size(289, 21);
            this.comboBox_username.TabIndex = 32;
            this.comboBox_username.ValueMember = "MANV";
            // 
            // FormTaoTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox_username);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox_show);
            this.Controls.Add(this.button_taoTK);
            this.Controls.Add(this.radioButton_user);
            this.Controls.Add(this.radioButton_chinhanh);
            this.Controls.Add(this.radioButton_CTY);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label_role);
            this.Controls.Add(this.label_user);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.textBox_loginname);
            this.Controls.Add(this.Label_login);
            this.Name = "FormTaoTaiKhoan";
            this.Text = "FormTaoTaiKhoan";
            this.Load += new System.EventHandler(this.FormTaoTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS_QLVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDS_DSNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_show;
        private System.Windows.Forms.Button button_taoTK;
        private System.Windows.Forms.RadioButton radioButton_user;
        private System.Windows.Forms.RadioButton radioButton_chinhanh;
        private System.Windows.Forms.RadioButton radioButton_CTY;
        private System.Windows.Forms.TextBox textBox_password;
        private DevExpress.XtraEditors.LabelControl label_role;
        private DevExpress.XtraEditors.LabelControl label_user;
        private DevExpress.XtraEditors.LabelControl label_password;
        private System.Windows.Forms.TextBox textBox_loginname;
        private DevExpress.XtraEditors.LabelControl Label_login;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox textBox_username;
        private DS_QLVT DS_QLVT;
        private System.Windows.Forms.BindingSource BDS_DSNV;
        private DS_QLVTTableAdapters.DSNVTableAdapter DSNVTableAdapter;
        private DS_QLVTTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox comboBox_username;
    }
}