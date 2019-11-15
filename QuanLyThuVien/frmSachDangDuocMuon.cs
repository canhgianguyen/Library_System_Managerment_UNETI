using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyThuVien.Report;

namespace QuanLyThuVien
{
    public partial class frmSachDangDuocMuon : DevExpress.XtraEditors.XtraForm
    {
        public frmSachDangDuocMuon()
        {
            InitializeComponent();
        }

        private void frmSachDangDuocMuon_Load(object sender, EventArgs e)
        {
            rptSachDangDuocMuon rpt = new rptSachDangDuocMuon();
            rpt.initData(DateTime.Now.Day.ToString(), DateTime.Now.Month.ToString(), DateTime.Now.Year.ToString(), frmLogin.name_user);
            documentViewer1.PrintingSystem = rpt.PrintingSystem;
            rpt.CreateDocument();
        }
    }
}