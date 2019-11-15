namespace QuanLyThuVien
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.rbHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbNhanVien = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.brnQuanLyNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnResetPassword = new DevExpress.XtraBars.BarButtonItem();
            this.rbThuVien = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnThemSach = new DevExpress.XtraBars.BarButtonItem();
            this.btnThemLoaiSach = new DevExpress.XtraBars.BarButtonItem();
            this.btnThemNhaCungCap = new DevExpress.XtraBars.BarButtonItem();
            this.btnSachHienCo = new DevExpress.XtraBars.BarButtonItem();
            this.rbOption = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnSuaThongTin = new DevExpress.XtraBars.BarButtonItem();
            this.btnDoiMatKhau = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.rbChucNang = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbgQuanLy = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnMuonSach = new DevExpress.XtraBars.BarButtonItem();
            this.btnTraSach = new DevExpress.XtraBars.BarButtonItem();
            this.btnTimKiemDocGia = new DevExpress.XtraBars.BarButtonItem();
            this.rbgTimKiem = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnTimKiemSach = new DevExpress.XtraBars.BarButtonItem();
            this.rbgThongKe = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnSachTrongThuVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnSachDangDuocMuon = new DevExpress.XtraBars.BarButtonItem();
            this.btnSachQuaHan = new DevExpress.XtraBars.BarButtonItem();
            this.btnSachBiHong = new DevExpress.XtraBars.BarButtonItem();
            this.btnDocGiaDangMuon = new DevExpress.XtraBars.BarButtonItem();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.txtXinChao = new DevExpress.XtraBars.BarHeaderItem();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbHeThong
            // 
            this.rbHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbNhanVien,
            this.rbThuVien,
            this.rbOption});
            this.rbHeThong.Name = "rbHeThong";
            this.rbHeThong.Text = "Hệ thống";
            // 
            // rbNhanVien
            // 
            this.rbNhanVien.ItemLinks.Add(this.brnQuanLyNhanVien);
            this.rbNhanVien.ItemLinks.Add(this.btnResetPassword);
            this.rbNhanVien.Name = "rbNhanVien";
            this.rbNhanVien.ShowCaptionButton = false;
            this.rbNhanVien.Text = "Nhân viên";
            // 
            // brnQuanLyNhanVien
            // 
            this.brnQuanLyNhanVien.Caption = "Quản lý nhân viên";
            this.brnQuanLyNhanVien.Id = 15;
            this.brnQuanLyNhanVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("brnQuanLyNhanVien.ImageOptions.Image")));
            this.brnQuanLyNhanVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("brnQuanLyNhanVien.ImageOptions.LargeImage")));
            this.brnQuanLyNhanVien.LargeWidth = 70;
            this.brnQuanLyNhanVien.Name = "brnQuanLyNhanVien";
            this.brnQuanLyNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.brnQuanLyNhanVien_ItemClick);
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Caption = "Đặt lại mật khẩu";
            this.btnResetPassword.Id = 22;
            this.btnResetPassword.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnResetPassword.ImageOptions.Image")));
            this.btnResetPassword.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnResetPassword.ImageOptions.LargeImage")));
            this.btnResetPassword.LargeWidth = 70;
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnResetPassword_ItemClick);
            // 
            // rbThuVien
            // 
            this.rbThuVien.ItemLinks.Add(this.btnThemSach);
            this.rbThuVien.ItemLinks.Add(this.btnThemLoaiSach);
            this.rbThuVien.ItemLinks.Add(this.btnThemNhaCungCap);
            this.rbThuVien.ItemLinks.Add(this.btnSachHienCo);
            this.rbThuVien.Name = "rbThuVien";
            this.rbThuVien.ShowCaptionButton = false;
            this.rbThuVien.Text = "Thư viện";
            // 
            // btnThemSach
            // 
            this.btnThemSach.Caption = "Quản lý sách";
            this.btnThemSach.Id = 18;
            this.btnThemSach.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemSach.ImageOptions.Image")));
            this.btnThemSach.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThemSach.ImageOptions.LargeImage")));
            this.btnThemSach.LargeWidth = 70;
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemSach_ItemClick);
            // 
            // btnThemLoaiSach
            // 
            this.btnThemLoaiSach.Caption = "Quản lý thể loại";
            this.btnThemLoaiSach.Id = 17;
            this.btnThemLoaiSach.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemLoaiSach.ImageOptions.Image")));
            this.btnThemLoaiSach.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThemLoaiSach.ImageOptions.LargeImage")));
            this.btnThemLoaiSach.LargeWidth = 70;
            this.btnThemLoaiSach.Name = "btnThemLoaiSach";
            this.btnThemLoaiSach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemLoaiSach_ItemClick);
            // 
            // btnThemNhaCungCap
            // 
            this.btnThemNhaCungCap.Caption = "Quản lý nhà cung cấp";
            this.btnThemNhaCungCap.Id = 16;
            this.btnThemNhaCungCap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemNhaCungCap.ImageOptions.Image")));
            this.btnThemNhaCungCap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThemNhaCungCap.ImageOptions.LargeImage")));
            this.btnThemNhaCungCap.LargeWidth = 70;
            this.btnThemNhaCungCap.Name = "btnThemNhaCungCap";
            this.btnThemNhaCungCap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemNhaCungCap_ItemClick);
            // 
            // btnSachHienCo
            // 
            this.btnSachHienCo.Caption = "Sách hiện có";
            this.btnSachHienCo.Id = 26;
            this.btnSachHienCo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSachHienCo.ImageOptions.Image")));
            this.btnSachHienCo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSachHienCo.ImageOptions.LargeImage")));
            this.btnSachHienCo.Name = "btnSachHienCo";
            this.btnSachHienCo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSachHienCo_ItemClick);
            // 
            // rbOption
            // 
            this.rbOption.ItemLinks.Add(this.btnSuaThongTin);
            this.rbOption.ItemLinks.Add(this.btnDoiMatKhau);
            this.rbOption.ItemLinks.Add(this.btnDangXuat);
            this.rbOption.Name = "rbOption";
            this.rbOption.ShowCaptionButton = false;
            this.rbOption.Text = "Options";
            // 
            // btnSuaThongTin
            // 
            this.btnSuaThongTin.Caption = "Sửa thông tin";
            this.btnSuaThongTin.Id = 25;
            this.btnSuaThongTin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaThongTin.ImageOptions.Image")));
            this.btnSuaThongTin.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSuaThongTin.ImageOptions.LargeImage")));
            this.btnSuaThongTin.LargeWidth = 70;
            this.btnSuaThongTin.Name = "btnSuaThongTin";
            this.btnSuaThongTin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSuaThongTin_ItemClick);
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Caption = "Đổi mật khẩu";
            this.btnDoiMatKhau.Id = 20;
            this.btnDoiMatKhau.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDoiMatKhau.ImageOptions.Image")));
            this.btnDoiMatKhau.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDoiMatKhau.ImageOptions.LargeImage")));
            this.btnDoiMatKhau.LargeWidth = 70;
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDoiMatKhau_ItemClick);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng xuất";
            this.btnDangXuat.Id = 21;
            this.btnDangXuat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDangXuat.ImageOptions.SvgImage")));
            this.btnDangXuat.LargeWidth = 70;
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // rbChucNang
            // 
            this.rbChucNang.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbgQuanLy,
            this.rbgTimKiem,
            this.rbgThongKe});
            this.rbChucNang.Name = "rbChucNang";
            this.rbChucNang.Text = "Chức năng";
            // 
            // rbgQuanLy
            // 
            this.rbgQuanLy.ItemLinks.Add(this.btnMuonSach);
            this.rbgQuanLy.ItemLinks.Add(this.btnTraSach);
            this.rbgQuanLy.ItemLinks.Add(this.btnTimKiemDocGia);
            this.rbgQuanLy.Name = "rbgQuanLy";
            this.rbgQuanLy.ShowCaptionButton = false;
            this.rbgQuanLy.Text = "Quản lý";
            // 
            // btnMuonSach
            // 
            this.btnMuonSach.Caption = "Mượn sách";
            this.btnMuonSach.Id = 1;
            this.btnMuonSach.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnMuonSach.ImageOptions.SvgImage")));
            this.btnMuonSach.LargeWidth = 70;
            this.btnMuonSach.Name = "btnMuonSach";
            this.btnMuonSach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMuonSach_ItemClick);
            // 
            // btnTraSach
            // 
            this.btnTraSach.Caption = "Trả sách";
            this.btnTraSach.Id = 15;
            this.btnTraSach.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTraSach.ImageOptions.SvgImage")));
            this.btnTraSach.LargeWidth = 70;
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTraSach_ItemClick);
            // 
            // btnTimKiemDocGia
            // 
            this.btnTimKiemDocGia.Caption = "Độc giả";
            this.btnTimKiemDocGia.Id = 5;
            this.btnTimKiemDocGia.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiemDocGia.ImageOptions.Image")));
            this.btnTimKiemDocGia.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTimKiemDocGia.ImageOptions.LargeImage")));
            this.btnTimKiemDocGia.LargeWidth = 70;
            this.btnTimKiemDocGia.Name = "btnTimKiemDocGia";
            this.btnTimKiemDocGia.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTimKiemDocGia_ItemClick);
            // 
            // rbgTimKiem
            // 
            this.rbgTimKiem.ItemLinks.Add(this.btnTimKiemSach);
            this.rbgTimKiem.Name = "rbgTimKiem";
            this.rbgTimKiem.ShowCaptionButton = false;
            this.rbgTimKiem.Text = "Tim kiếm";
            // 
            // btnTimKiemSach
            // 
            this.btnTimKiemSach.Caption = "Tìm kiếm sách";
            this.btnTimKiemSach.Id = 2;
            this.btnTimKiemSach.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiemSach.ImageOptions.Image")));
            this.btnTimKiemSach.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTimKiemSach.ImageOptions.LargeImage")));
            this.btnTimKiemSach.LargeWidth = 70;
            this.btnTimKiemSach.Name = "btnTimKiemSach";
            this.btnTimKiemSach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTimKiemSach_ItemClick);
            // 
            // rbgThongKe
            // 
            this.rbgThongKe.ItemLinks.Add(this.btnSachTrongThuVien);
            this.rbgThongKe.ItemLinks.Add(this.btnSachDangDuocMuon);
            this.rbgThongKe.ItemLinks.Add(this.btnSachQuaHan);
            this.rbgThongKe.ItemLinks.Add(this.btnSachBiHong);
            this.rbgThongKe.ItemLinks.Add(this.btnDocGiaDangMuon);
            this.rbgThongKe.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.TwoRows;
            this.rbgThongKe.Name = "rbgThongKe";
            this.rbgThongKe.ShowCaptionButton = false;
            this.rbgThongKe.Text = "Thống kê";
            // 
            // btnSachTrongThuVien
            // 
            this.btnSachTrongThuVien.Caption = "Sách trong thư viện";
            this.btnSachTrongThuVien.Id = 6;
            this.btnSachTrongThuVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSachTrongThuVien.ImageOptions.Image")));
            this.btnSachTrongThuVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSachTrongThuVien.ImageOptions.LargeImage")));
            this.btnSachTrongThuVien.LargeWidth = 70;
            this.btnSachTrongThuVien.Name = "btnSachTrongThuVien";
            this.btnSachTrongThuVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSachTrongThuVien_ItemClick);
            // 
            // btnSachDangDuocMuon
            // 
            this.btnSachDangDuocMuon.Caption = "Sách đang được mượn";
            this.btnSachDangDuocMuon.Id = 7;
            this.btnSachDangDuocMuon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSachDangDuocMuon.ImageOptions.Image")));
            this.btnSachDangDuocMuon.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSachDangDuocMuon.ImageOptions.LargeImage")));
            this.btnSachDangDuocMuon.LargeWidth = 70;
            this.btnSachDangDuocMuon.Name = "btnSachDangDuocMuon";
            this.btnSachDangDuocMuon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSachDangDuocMuon_ItemClick);
            // 
            // btnSachQuaHan
            // 
            this.btnSachQuaHan.Caption = "Sách quá hạn";
            this.btnSachQuaHan.Id = 9;
            this.btnSachQuaHan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSachQuaHan.ImageOptions.Image")));
            this.btnSachQuaHan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSachQuaHan.ImageOptions.LargeImage")));
            this.btnSachQuaHan.LargeWidth = 70;
            this.btnSachQuaHan.Name = "btnSachQuaHan";
            this.btnSachQuaHan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSachQuaHanMuon_ItemClick);
            // 
            // btnSachBiHong
            // 
            this.btnSachBiHong.Caption = "Sách bị hỏng";
            this.btnSachBiHong.Id = 2;
            this.btnSachBiHong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSachBiHong.ImageOptions.Image")));
            this.btnSachBiHong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSachBiHong.ImageOptions.LargeImage")));
            this.btnSachBiHong.Name = "btnSachBiHong";
            this.btnSachBiHong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSachBiHong_ItemClick);
            // 
            // btnDocGiaDangMuon
            // 
            this.btnDocGiaDangMuon.Caption = "Độc giả đang mượn";
            this.btnDocGiaDangMuon.Id = 8;
            this.btnDocGiaDangMuon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDocGiaDangMuon.ImageOptions.Image")));
            this.btnDocGiaDangMuon.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDocGiaDangMuon.ImageOptions.LargeImage")));
            this.btnDocGiaDangMuon.LargeWidth = 70;
            this.btnDocGiaDangMuon.Name = "btnDocGiaDangMuon";
            this.btnDocGiaDangMuon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDocGiaDangMuon_ItemClick);
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Caption = "Hê looooooo!";
            this.barHeaderItem1.Id = 23;
            this.barHeaderItem1.Name = "barHeaderItem1";
            this.barHeaderItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barHeaderItem1_ItemClick);
            // 
            // ribbon
            // 
            this.ribbon.ApplicationButtonAnimationLength = 0;
            this.ribbon.ApplicationButtonImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbon.ApplicationButtonImageOptions.Image")));
            this.ribbon.ApplicationButtonImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None;
            this.ribbon.CaptionBarItemLinks.Add(this.txtXinChao);
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.txtXinChao,
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnMuonSach,
            this.btnTimKiemSach,
            this.btnTimKiemDocGia,
            this.btnSachTrongThuVien,
            this.btnSachDangDuocMuon,
            this.btnDocGiaDangMuon,
            this.btnSachQuaHan,
            this.btnTraSach,
            this.brnQuanLyNhanVien,
            this.btnThemNhaCungCap,
            this.btnThemLoaiSach,
            this.btnThemSach,
            this.btnDoiMatKhau,
            this.btnDangXuat,
            this.btnResetPassword,
            this.barHeaderItem1,
            this.btnSuaThongTin,
            this.btnSachHienCo,
            this.btnSachBiHong});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 3;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbChucNang,
            this.rbHeThong});
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.True;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(1932, 183);
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // txtXinChao
            // 
            this.txtXinChao.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXinChao.Appearance.Options.UseFont = true;
            this.txtXinChao.Caption = "Xin chào: Nguyễn Gia Cảnh";
            this.txtXinChao.Id = 24;
            this.txtXinChao.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("txtXinChao.ImageOptions.SvgImage")));
            this.txtXinChao.Name = "txtXinChao";
            this.txtXinChao.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.AppearancePage.HeaderActive.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.xtraTabbedMdiManager1.AppearancePage.HeaderActive.Options.UseFont = true;
            this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // frmMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1932, 1061);
            this.Controls.Add(this.ribbon);
            this.Font = new System.Drawing.Font("Arial Unicode MS", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(1494, 797);
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.Text = "Quản lý thư viện";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonPage rbHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbChucNang;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbgQuanLy;
        private DevExpress.XtraBars.BarButtonItem btnMuonSach;
        private DevExpress.XtraBars.BarButtonItem btnTraSach;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbgTimKiem;
        private DevExpress.XtraBars.BarButtonItem btnTimKiemSach;
        private DevExpress.XtraBars.BarButtonItem btnTimKiemDocGia;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbgThongKe;
        private DevExpress.XtraBars.BarButtonItem btnSachTrongThuVien;
        private DevExpress.XtraBars.BarButtonItem btnSachDangDuocMuon;
        private DevExpress.XtraBars.BarButtonItem btnSachQuaHan;
        private DevExpress.XtraBars.BarButtonItem btnDocGiaDangMuon;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbNhanVien;
        private DevExpress.XtraBars.BarButtonItem brnQuanLyNhanVien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbThuVien;
        private DevExpress.XtraBars.BarButtonItem btnThemSach;
        private DevExpress.XtraBars.BarButtonItem btnThemLoaiSach;
        private DevExpress.XtraBars.BarButtonItem btnThemNhaCungCap;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbOption;
        private DevExpress.XtraBars.BarButtonItem btnDoiMatKhau;
        private DevExpress.XtraBars.BarButtonItem btnResetPassword;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private DevExpress.XtraBars.BarHeaderItem txtXinChao;
        private DevExpress.XtraBars.BarButtonItem btnSuaThongTin;
        private DevExpress.XtraBars.BarButtonItem btnSachHienCo;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.BarButtonItem btnSachBiHong;
    }
}