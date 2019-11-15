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

namespace QuanLyThuVien
{
    public partial class frmSachTrongThuVien : DevExpress.XtraEditors.XtraForm
    {
        public frmSachTrongThuVien()
        {
            InitializeComponent();
        }

        private void frmSachTrongThuVien_Load(object sender, EventArgs e)
        {
            rptSachTrongThuVien rpt = new rptSachTrongThuVien();
            rpt.initData(DateTime.Now.Day.ToString(), DateTime.Now.Month.ToString(), DateTime.Now.Year.ToString(), frmLogin.name_user);
            documentViewer1.PrintingSystem = rpt.PrintingSystem;
            rpt.CreateDocument();
        }
    }
}