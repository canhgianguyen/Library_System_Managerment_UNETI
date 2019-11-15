using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QuanLyThuVien
{
    public partial class rptSachTrongThuVien : DevExpress.XtraReports.UI.XtraReport
    {
        public rptSachTrongThuVien()
        {
            InitializeComponent();
        }

        public void initData(string day, string month, string year, string user)
        {
            this.day.Value = day;
            this.month.Value = month;
            this.year.Value = year;
            this.user.Value = user;
        }

    }
}
