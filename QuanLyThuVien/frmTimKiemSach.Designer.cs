namespace QuanLyThuVien
{
    partial class frmTimKiemSach
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
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.gcSach = new DevExpress.XtraGrid.GridControl();
            this.gvSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.id_bookprovider = new DevExpress.XtraGrid.Columns.GridColumn();
            this.id_book = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bookname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.author = new DevExpress.XtraGrid.Columns.GridColumn();
            this.publisher = new DevExpress.XtraGrid.Columns.GridColumn();
            this.publishingyear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pages = new DevExpress.XtraGrid.Columns.GridColumn();
            this.date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.amount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.id_booktype = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcSach);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1154, 490);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1154, 490);
            this.Root.TextVisible = false;
            // 
            // gcSach
            // 
            this.gcSach.Location = new System.Drawing.Point(12, 12);
            this.gcSach.MainView = this.gvSach;
            this.gcSach.Name = "gcSach";
            this.gcSach.Size = new System.Drawing.Size(1130, 466);
            this.gcSach.TabIndex = 4;
            this.gcSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSach});
            // 
            // gvSach
            // 
            this.gvSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id_bookprovider,
            this.id_book,
            this.id_booktype,
            this.bookname,
            this.author,
            this.publisher,
            this.publishingyear,
            this.pages,
            this.date,
            this.amount});
            this.gvSach.GridControl = this.gcSach;
            this.gvSach.Name = "gvSach";
            this.gvSach.OptionsBehavior.Editable = false;
            this.gvSach.OptionsFind.AlwaysVisible = true;
            this.gvSach.OptionsFind.FindDelay = 100;
            this.gvSach.OptionsFind.FindNullPrompt = "Tìm kiếm...";
            this.gvSach.OptionsFind.ShowClearButton = false;
            this.gvSach.OptionsFind.ShowCloseButton = false;
            this.gvSach.OptionsFind.ShowFindButton = false;
            this.gvSach.OptionsFind.ShowSearchNavButtons = false;
            this.gvSach.OptionsSelection.EnableAppearanceFocusedCell = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcSach;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1134, 470);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // id_bookprovider
            // 
            this.id_bookprovider.Caption = "Mã nhà cung cấp";
            this.id_bookprovider.FieldName = "id_bookprovider";
            this.id_bookprovider.MaxWidth = 150;
            this.id_bookprovider.MinWidth = 25;
            this.id_bookprovider.Name = "id_bookprovider";
            this.id_bookprovider.Visible = true;
            this.id_bookprovider.VisibleIndex = 0;
            this.id_bookprovider.Width = 94;
            // 
            // id_book
            // 
            this.id_book.Caption = "Mã sách";
            this.id_book.FieldName = "id_book";
            this.id_book.MaxWidth = 150;
            this.id_book.MinWidth = 25;
            this.id_book.Name = "id_book";
            this.id_book.Visible = true;
            this.id_book.VisibleIndex = 2;
            this.id_book.Width = 94;
            // 
            // bookname
            // 
            this.bookname.Caption = "Tên sách";
            this.bookname.FieldName = "bookname";
            this.bookname.MinWidth = 25;
            this.bookname.Name = "bookname";
            this.bookname.Visible = true;
            this.bookname.VisibleIndex = 3;
            this.bookname.Width = 94;
            // 
            // author
            // 
            this.author.Caption = "Tác giả";
            this.author.FieldName = "author";
            this.author.MaxWidth = 200;
            this.author.MinWidth = 25;
            this.author.Name = "author";
            this.author.Visible = true;
            this.author.VisibleIndex = 4;
            this.author.Width = 94;
            // 
            // publisher
            // 
            this.publisher.Caption = "Nhà xuất bản";
            this.publisher.FieldName = "publisher";
            this.publisher.MaxWidth = 250;
            this.publisher.MinWidth = 25;
            this.publisher.Name = "publisher";
            this.publisher.Visible = true;
            this.publisher.VisibleIndex = 5;
            this.publisher.Width = 94;
            // 
            // publishingyear
            // 
            this.publishingyear.Caption = "Năm xuất bản";
            this.publishingyear.FieldName = "publishingyear";
            this.publishingyear.MaxWidth = 150;
            this.publishingyear.MinWidth = 25;
            this.publishingyear.Name = "publishingyear";
            this.publishingyear.Visible = true;
            this.publishingyear.VisibleIndex = 6;
            this.publishingyear.Width = 94;
            // 
            // pages
            // 
            this.pages.Caption = "Số trang";
            this.pages.FieldName = "pages";
            this.pages.MaxWidth = 150;
            this.pages.MinWidth = 25;
            this.pages.Name = "pages";
            this.pages.Visible = true;
            this.pages.VisibleIndex = 7;
            this.pages.Width = 94;
            // 
            // date
            // 
            this.date.Caption = "Ngày nhập";
            this.date.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.date.FieldName = "date";
            this.date.MaxWidth = 150;
            this.date.MinWidth = 25;
            this.date.Name = "date";
            this.date.Visible = true;
            this.date.VisibleIndex = 8;
            this.date.Width = 94;
            // 
            // amount
            // 
            this.amount.Caption = "Số lượng";
            this.amount.FieldName = "amount";
            this.amount.MaxWidth = 150;
            this.amount.MinWidth = 25;
            this.amount.Name = "amount";
            this.amount.Visible = true;
            this.amount.VisibleIndex = 9;
            this.amount.Width = 94;
            // 
            // id_booktype
            // 
            this.id_booktype.Caption = "Mã loại sách";
            this.id_booktype.FieldName = "id_booktype";
            this.id_booktype.MaxWidth = 150;
            this.id_booktype.MinWidth = 25;
            this.id_booktype.Name = "id_booktype";
            this.id_booktype.Visible = true;
            this.id_booktype.VisibleIndex = 1;
            this.id_booktype.Width = 94;
            // 
            // frmTimKiemSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 490);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmTimKiemSach";
            this.Text = "Tìm kiếm sách";
            this.Load += new System.EventHandler(this.frmTimKiemSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gcSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSach;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn id_bookprovider;
        private DevExpress.XtraGrid.Columns.GridColumn id_book;
        private DevExpress.XtraGrid.Columns.GridColumn bookname;
        private DevExpress.XtraGrid.Columns.GridColumn author;
        private DevExpress.XtraGrid.Columns.GridColumn publisher;
        private DevExpress.XtraGrid.Columns.GridColumn publishingyear;
        private DevExpress.XtraGrid.Columns.GridColumn pages;
        private DevExpress.XtraGrid.Columns.GridColumn date;
        private DevExpress.XtraGrid.Columns.GridColumn amount;
        private DevExpress.XtraGrid.Columns.GridColumn id_booktype;
    }
}