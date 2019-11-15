namespace QuanLyThuVien
{
    partial class frmQuanLyNhanVien
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnLamMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.chkAdminNo = new System.Windows.Forms.RadioButton();
            this.chkAdminYes = new System.Windows.Forms.RadioButton();
            this.pcBanned = new DevExpress.XtraEditors.PanelControl();
            this.chkBannedNo = new System.Windows.Forms.RadioButton();
            this.chkBannedYes = new System.Windows.Forms.RadioButton();
            this.txtHoTen = new DevExpress.XtraEditors.TextEdit();
            this.txtTenTaiKhoan = new DevExpress.XtraEditors.TextEdit();
            this.txtMaNhanVien = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.gcNhanVien = new DevExpress.XtraGrid.GridControl();
            this.gvNhanVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id_user = new DevExpress.XtraGrid.Columns.GridColumn();
            this.username = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fullname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.state = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBanned)).BeginInit();
            this.pcBanned.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTaiKhoan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.groupControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1167, 215);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnLamMoi);
            this.groupControl1.Controls.Add(this.btnXoa);
            this.groupControl1.Controls.Add(this.btnSua);
            this.groupControl1.Controls.Add(this.btnThem);
            this.groupControl1.Controls.Add(this.panelControl2);
            this.groupControl1.Controls.Add(this.pcBanned);
            this.groupControl1.Controls.Add(this.txtHoTen);
            this.groupControl1.Controls.Add(this.txtTenTaiKhoan);
            this.groupControl1.Controls.Add(this.txtMaNhanVien);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1143, 191);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Thông tin";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(461, 155);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(94, 29);
            this.btnLamMoi.TabIndex = 5;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(461, 112);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 29);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(461, 69);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 29);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(461, 26);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 29);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.chkAdminNo);
            this.panelControl2.Controls.Add(this.chkAdminYes);
            this.panelControl2.Location = new System.Drawing.Point(107, 165);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(126, 25);
            this.panelControl2.TabIndex = 9;
            // 
            // chkAdminNo
            // 
            this.chkAdminNo.AutoSize = true;
            this.chkAdminNo.Location = new System.Drawing.Point(55, 3);
            this.chkAdminNo.Name = "chkAdminNo";
            this.chkAdminNo.Size = new System.Drawing.Size(46, 21);
            this.chkAdminNo.TabIndex = 1;
            this.chkAdminNo.TabStop = true;
            this.chkAdminNo.Text = "No";
            this.chkAdminNo.UseVisualStyleBackColor = true;
            // 
            // chkAdminYes
            // 
            this.chkAdminYes.AutoSize = true;
            this.chkAdminYes.Location = new System.Drawing.Point(3, 3);
            this.chkAdminYes.Name = "chkAdminYes";
            this.chkAdminYes.Size = new System.Drawing.Size(50, 21);
            this.chkAdminYes.TabIndex = 0;
            this.chkAdminYes.TabStop = true;
            this.chkAdminYes.Text = "Yes";
            this.chkAdminYes.UseVisualStyleBackColor = true;
            // 
            // pcBanned
            // 
            this.pcBanned.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pcBanned.Controls.Add(this.chkBannedNo);
            this.pcBanned.Controls.Add(this.chkBannedYes);
            this.pcBanned.Enabled = false;
            this.pcBanned.Location = new System.Drawing.Point(107, 131);
            this.pcBanned.Name = "pcBanned";
            this.pcBanned.Size = new System.Drawing.Size(126, 25);
            this.pcBanned.TabIndex = 8;
            // 
            // chkBannedNo
            // 
            this.chkBannedNo.AutoSize = true;
            this.chkBannedNo.Location = new System.Drawing.Point(55, 3);
            this.chkBannedNo.Name = "chkBannedNo";
            this.chkBannedNo.Size = new System.Drawing.Size(46, 21);
            this.chkBannedNo.TabIndex = 1;
            this.chkBannedNo.TabStop = true;
            this.chkBannedNo.Text = "No";
            this.chkBannedNo.UseVisualStyleBackColor = true;
            // 
            // chkBannedYes
            // 
            this.chkBannedYes.AutoSize = true;
            this.chkBannedYes.Location = new System.Drawing.Point(3, 3);
            this.chkBannedYes.Name = "chkBannedYes";
            this.chkBannedYes.Size = new System.Drawing.Size(50, 21);
            this.chkBannedYes.TabIndex = 0;
            this.chkBannedYes.TabStop = true;
            this.chkBannedYes.Text = "Yes";
            this.chkBannedYes.UseVisualStyleBackColor = true;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(108, 101);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(324, 22);
            this.txtHoTen.TabIndex = 1;
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(108, 67);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Properties.Appearance.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTenTaiKhoan.Properties.Appearance.Options.UseBackColor = true;
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(324, 22);
            this.txtTenTaiKhoan.TabIndex = 0;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Enabled = false;
            this.txtMaNhanVien.Location = new System.Drawing.Point(108, 30);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.txtMaNhanVien.Properties.Appearance.Options.UseBackColor = true;
            this.txtMaNhanVien.Size = new System.Drawing.Size(324, 22);
            this.txtMaNhanVien.TabIndex = 5;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(10, 169);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(41, 16);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Admin:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(10, 135);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(47, 16);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Banned:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(10, 101);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(46, 17);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Họ tên:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(10, 67);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(88, 17);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên tài khoản:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(81, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã nhân viên:";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1167, 215);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.groupControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1147, 195);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.gcNhanVien);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(0, 215);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup1;
            this.layoutControl2.Size = new System.Drawing.Size(1167, 435);
            this.layoutControl2.TabIndex = 1;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // gcNhanVien
            // 
            this.gcNhanVien.Location = new System.Drawing.Point(12, 12);
            this.gcNhanVien.MainView = this.gvNhanVien;
            this.gcNhanVien.Name = "gcNhanVien";
            this.gcNhanVien.Size = new System.Drawing.Size(1143, 411);
            this.gcNhanVien.TabIndex = 0;
            this.gcNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNhanVien});
            this.gcNhanVien.MouseCaptureChanged += new System.EventHandler(this.gcNhanVien_MouseCaptureChanged);
            // 
            // gvNhanVien
            // 
            this.gvNhanVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id_user,
            this.username,
            this.fullname,
            this.state,
            this.mod});
            this.gvNhanVien.GridControl = this.gcNhanVien;
            this.gvNhanVien.Name = "gvNhanVien";
            this.gvNhanVien.OptionsBehavior.Editable = false;
            this.gvNhanVien.OptionsFind.AlwaysVisible = true;
            this.gvNhanVien.OptionsFind.FindDelay = 100;
            this.gvNhanVien.OptionsFind.FindNullPrompt = "Tìm kiếm...";
            this.gvNhanVien.OptionsFind.ShowClearButton = false;
            this.gvNhanVien.OptionsFind.ShowCloseButton = false;
            this.gvNhanVien.OptionsFind.ShowFindButton = false;
            this.gvNhanVien.OptionsFind.ShowSearchNavButtons = false;
            this.gvNhanVien.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvNhanVien.OptionsView.ShowGroupPanel = false;
            // 
            // id_user
            // 
            this.id_user.Caption = "Mã nhân viên";
            this.id_user.FieldName = "id_user";
            this.id_user.MaxWidth = 200;
            this.id_user.MinWidth = 25;
            this.id_user.Name = "id_user";
            this.id_user.Visible = true;
            this.id_user.VisibleIndex = 0;
            this.id_user.Width = 94;
            // 
            // username
            // 
            this.username.Caption = "Tên tài khoản";
            this.username.FieldName = "username";
            this.username.MaxWidth = 200;
            this.username.MinWidth = 25;
            this.username.Name = "username";
            this.username.Visible = true;
            this.username.VisibleIndex = 1;
            this.username.Width = 94;
            // 
            // fullname
            // 
            this.fullname.Caption = "Họ tên";
            this.fullname.FieldName = "fullname";
            this.fullname.MinWidth = 25;
            this.fullname.Name = "fullname";
            this.fullname.Visible = true;
            this.fullname.VisibleIndex = 2;
            this.fullname.Width = 94;
            // 
            // state
            // 
            this.state.Caption = "Banned";
            this.state.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.state.FieldName = "state";
            this.state.MaxWidth = 200;
            this.state.MinWidth = 25;
            this.state.Name = "state";
            this.state.Visible = true;
            this.state.VisibleIndex = 3;
            this.state.Width = 94;
            // 
            // mod
            // 
            this.mod.Caption = "Admin";
            this.mod.FieldName = "mod";
            this.mod.MaxWidth = 200;
            this.mod.MinWidth = 25;
            this.mod.Name = "mod";
            this.mod.Visible = true;
            this.mod.VisibleIndex = 4;
            this.mod.Width = 94;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1167, 435);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gcNhanVien;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1147, 415);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // frmQuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 650);
            this.Controls.Add(this.layoutControl2);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmQuanLyNhanVien";
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.frmQuanLyNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBanned)).EndInit();
            this.pcBanned.ResumeLayout(false);
            this.pcBanned.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTaiKhoan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraGrid.GridControl gcNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNhanVien;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl pcBanned;
        private DevExpress.XtraEditors.TextEdit txtHoTen;
        private DevExpress.XtraEditors.TextEdit txtTenTaiKhoan;
        private DevExpress.XtraEditors.TextEdit txtMaNhanVien;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn id_user;
        private DevExpress.XtraGrid.Columns.GridColumn username;
        private DevExpress.XtraGrid.Columns.GridColumn fullname;
        private DevExpress.XtraGrid.Columns.GridColumn state;
        private DevExpress.XtraGrid.Columns.GridColumn mod;
        private DevExpress.XtraEditors.SimpleButton btnLamMoi;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.RadioButton chkAdminNo;
        private System.Windows.Forms.RadioButton chkAdminYes;
        private System.Windows.Forms.RadioButton chkBannedNo;
        private System.Windows.Forms.RadioButton chkBannedYes;
    }
}