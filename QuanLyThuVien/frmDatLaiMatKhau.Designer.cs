namespace QuanLyThuVien
{
    partial class frmDatLaiMatKhau
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatLaiMatKhau));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.gcNhanVien = new DevExpress.XtraGrid.GridControl();
            this.gvNhanVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id_user = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fullname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dob = new DevExpress.XtraGrid.Columns.GridColumn();
            this.number = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnReset = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.gcNhanVien);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(0, 0);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup1;
            this.layoutControl2.Size = new System.Drawing.Size(1029, 503);
            this.layoutControl2.TabIndex = 1;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // gcNhanVien
            // 
            this.gcNhanVien.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gcNhanVien_EmbeddedNavigator_ButtonClick);
            this.gcNhanVien.Location = new System.Drawing.Point(12, 12);
            this.gcNhanVien.MainView = this.gvNhanVien;
            this.gcNhanVien.Name = "gcNhanVien";
            this.gcNhanVien.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnReset});
            this.gcNhanVien.Size = new System.Drawing.Size(1005, 479);
            this.gcNhanVien.TabIndex = 0;
            this.gcNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNhanVien});
            // 
            // gvNhanVien
            // 
            this.gvNhanVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id_user,
            this.fullname,
            this.dob,
            this.number,
            this.button});
            this.gvNhanVien.GridControl = this.gcNhanVien;
            this.gvNhanVien.Name = "gvNhanVien";
            this.gvNhanVien.OptionsFind.AlwaysVisible = true;
            this.gvNhanVien.OptionsFind.FindDelay = 100;
            this.gvNhanVien.OptionsFind.FindNullPrompt = "Tìm kiếm...";
            this.gvNhanVien.OptionsFind.ShowClearButton = false;
            this.gvNhanVien.OptionsFind.ShowCloseButton = false;
            this.gvNhanVien.OptionsFind.ShowFindButton = false;
            this.gvNhanVien.OptionsFind.ShowSearchNavButtons = false;
            this.gvNhanVien.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvNhanVien.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
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
            // fullname
            // 
            this.fullname.Caption = "Tên nhân viên";
            this.fullname.FieldName = "fullname";
            this.fullname.MinWidth = 25;
            this.fullname.Name = "fullname";
            this.fullname.Visible = true;
            this.fullname.VisibleIndex = 1;
            this.fullname.Width = 94;
            // 
            // dob
            // 
            this.dob.Caption = "Ngày sinh";
            this.dob.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dob.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dob.FieldName = "dob";
            this.dob.MaxWidth = 200;
            this.dob.MinWidth = 25;
            this.dob.Name = "dob";
            this.dob.Visible = true;
            this.dob.VisibleIndex = 2;
            this.dob.Width = 94;
            // 
            // number
            // 
            this.number.Caption = "Số điện thoại";
            this.number.FieldName = "number";
            this.number.MaxWidth = 200;
            this.number.MinWidth = 25;
            this.number.Name = "number";
            this.number.Visible = true;
            this.number.VisibleIndex = 3;
            this.number.Width = 94;
            // 
            // button
            // 
            this.button.Caption = "Đặt lại mật khẩu";
            this.button.ColumnEdit = this.btnReset;
            this.button.MaxWidth = 150;
            this.button.MinWidth = 25;
            this.button.Name = "button";
            this.button.Visible = true;
            this.button.VisibleIndex = 4;
            this.button.Width = 94;
            // 
            // btnReset
            // 
            this.btnReset.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnReset.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnReset.Name = "btnReset";
            this.btnReset.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnReset.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnReset_ButtonClick);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1029, 503);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gcNhanVien;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1009, 483);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // frmDatLaiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 503);
            this.Controls.Add(this.layoutControl2);
            this.Name = "frmDatLaiMatKhau";
            this.Text = "Đặt lại mật khẩu nhân viên";
            this.Load += new System.EventHandler(this.frmDatLaiMatKhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraGrid.GridControl gcNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn id_user;
        private DevExpress.XtraGrid.Columns.GridColumn fullname;
        private DevExpress.XtraGrid.Columns.GridColumn dob;
        private DevExpress.XtraGrid.Columns.GridColumn number;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Columns.GridColumn button;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnReset;
    }
}