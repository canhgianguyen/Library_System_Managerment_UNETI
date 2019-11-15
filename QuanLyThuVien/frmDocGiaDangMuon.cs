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
    public partial class frmDocGiaDangMuon : DevExpress.XtraEditors.XtraForm
    {
        public frmDocGiaDangMuon()
        {
            InitializeComponent();
        }

        private void frmDocGiaDangMuon_Load(object sender, EventArgs e)
        {
            rptDocGiaDangMuon rpt = new rptDocGiaDangMuon();
            rpt.initData(DateTime.Now.Day.ToString(), DateTime.Now.Month.ToString(), DateTime.Now.Year.ToString(), frmLogin.name_user);
            documentViewer1.PrintingSystem = rpt.PrintingSystem;
            rpt.CreateDocument();
        }
    }
}