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
    public partial class frmSachQuaHan : DevExpress.XtraEditors.XtraForm
    {
        public frmSachQuaHan()
        {
            InitializeComponent();
        }

        private void frmSachQuaHan_Load(object sender, EventArgs e)
        {
            rptSachQuaHan rpt = new rptSachQuaHan();
            rpt.initData(DateTime.Now.Day.ToString(), DateTime.Now.Month.ToString(), DateTime.Now.Year.ToString(), frmLogin.name_user);
            documentViewer1.PrintingSystem = rpt.PrintingSystem;
            rpt.CreateDocument();
        }
    }
}