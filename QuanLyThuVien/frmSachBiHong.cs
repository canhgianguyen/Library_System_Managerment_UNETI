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
    public partial class frmSachBiHong : DevExpress.XtraEditors.XtraForm
    {
        public frmSachBiHong()
        {
            InitializeComponent();
        }

        private void frmSachBiHong_Load(object sender, EventArgs e)
        {
            rptSachBiHong rpt = new rptSachBiHong();
            rpt.initData(DateTime.Now.Day.ToString(), DateTime.Now.Month.ToString(), DateTime.Now.Year.ToString(), frmLogin.name_user);
            documentViewer1.PrintingSystem = rpt.PrintingSystem;
            rpt.CreateDocument();
        }
    }
}