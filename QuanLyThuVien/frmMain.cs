using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System.Net;
using System.Threading;

namespace QuanLyThuVien
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Con_CRUD con = new Con_CRUD();
        string id = frmLogin.id_user;
        string name = frmLogin.name_user;
        public frmMain()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rect = ClientRectangle;
            rect.Y += Ribbon.Bounds.Bottom;
            rect.Height -= Ribbon.Height;
            e.Graphics.DrawImage(BackgroundImage, rect);
        }

        private Form formCheck(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }
       
        private void skinPaletteDropDownButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void frmMain_Load(object sender, EventArgs e)
        {            
            loadData();
        }

        private void loadData()
        {
            txtXinChao.Caption = "Xin chào: " + name;
            bool check = false;
            string sql = "select mod from users where id_user = '" + id + "'";
            DataTable dt = new DataTable();
            dt = con.readData(sql);
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    check = Convert.ToBoolean(dr["mod"]);                    
                }
            }
            if (!check)
            {
                rbNhanVien.Visible = false;
                rbThuVien.Visible = false;
            }
            frmHome frm = new frmHome();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnMuonSach_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = formCheck(typeof(frmMuonSach));
            if(frm == null)
            {
                frmMuonSach f = new frmMuonSach();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void barHeaderItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void btnTraSach_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = formCheck(typeof(frmTraSach));
            if (frm == null)
            {
                frmTraSach f = new frmTraSach();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnTimKiemSach_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = formCheck(typeof(frmTimKiemSach));
            if(frm == null)
            {
                frmTimKiemSach f = new frmTimKiemSach();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnTimKiemDocGia_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = formCheck(typeof(frmDocGia));
            if(frm == null)
            {
                frmDocGia f = new frmDocGia();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnSachTrongThuVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = formCheck(typeof(frmSachTrongThuVien));
            if (frm == null)
            {
                frmSachTrongThuVien f = new frmSachTrongThuVien();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnSachDangDuocMuon_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = formCheck(typeof(frmSachDangDuocMuon));
            if(frm == null)
            {
                frmSachDangDuocMuon f = new frmSachDangDuocMuon();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnSachQuaHanMuon_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = formCheck(typeof(frmSachQuaHan));
            if (frm == null)
            {
                frmSachQuaHan f = new frmSachQuaHan();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnDocGiaDangMuon_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = formCheck(typeof(frmDocGiaDangMuon));
            if (frm == null)
            {
                frmDocGiaDangMuon f = new frmDocGiaDangMuon();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void brnQuanLyNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = formCheck(typeof(frmQuanLyNhanVien));
            if (frm == null)
            {
                frmQuanLyNhanVien f = new frmQuanLyNhanVien();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnResetPassword_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = formCheck(typeof(frmDatLaiMatKhau));
            if (frm == null)
            {
                frmDatLaiMatKhau f = new frmDatLaiMatKhau();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnThemSach_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = formCheck(typeof(frmQuanLySach));
            if (frm == null)
            {
                frmQuanLySach f = new frmQuanLySach();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnThemLoaiSach_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = formCheck(typeof(frmQuanLyTheLoai));
            if (frm == null)
            {
                frmQuanLyTheLoai f = new frmQuanLyTheLoai();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnThemNhaCungCap_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = formCheck(typeof(frmQuanLyNhaCungCap));
            if (frm == null)
            {
                frmQuanLyNhaCungCap f = new frmQuanLyNhaCungCap();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnSuaThongTin_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = formCheck(typeof(frmSuaThongTin));
            if (frm == null)
            {
                frmSuaThongTin f = new frmSuaThongTin();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnDoiMatKhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = formCheck(typeof(frmDoiMatKhau));
            if (frm == null)
            {
                frmDoiMatKhau f = new frmDoiMatKhau();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                frm.Activate();
            }
        }       

        private void btnSachHienCo_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = formCheck(typeof(frmSachHienCo));
            if (frm == null)
            {
                frmSachHienCo f = new frmSachHienCo();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnSachBiHong_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = formCheck(typeof(frmSachBiHong));
            if (frm == null)
            {
                frmSachBiHong f = new frmSachBiHong();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(openLoginForm));
            t.SetApartmentState(ApartmentState.STA);
            this.FormClosing -= frmMain_FormClosing;
            if (XtraMessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                t.Start();
            }      
        }

        public static void openLoginForm()
        {
            Application.Run(new frmLogin());
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {                
                e.Cancel = true;
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {            
        }        
    }
}