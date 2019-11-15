using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QuanLyThuVien.Report
{
    public partial class rptPhieuMuon : DevExpress.XtraReports.UI.XtraReport
    {
        public rptPhieuMuon()
        {
            this.PaperKind = System.Drawing.Printing.PaperKind.A5;
            InitializeComponent();
        }
        public void initData(string day, string month, string year, string user, string id, string name, int tong)
        {
            this.day.Value = day;
            this.month.Value = month;
            this.year.Value = year;
            this.user.Value = user;
            this.id.Value = id;
            this.name.Value = name;
            txtSum.Text = String.Format("{0:N0}", tong);
            txtMaSach.DataBindings.Add("Text", DataSource, "id_book");
            txtTenSach.DataBindings.Add("Text", DataSource, "bookname");
            txtTacGia.DataBindings.Add("Text", DataSource, "author");
            txtNgayMuon.DataBindings.Add("Text", DataSource, "lendingdate");
            txtNgayHenTra.DataBindings.Add("Text", DataSource, "dateexpect");
            txtTienDatCoc.DataBindings.Add("Text", DataSource, "deposit");            
        }
    }
}
