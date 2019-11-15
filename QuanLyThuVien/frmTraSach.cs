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
    public partial class frmTraSach : DevExpress.XtraEditors.XtraForm
    {
        Con_CRUD con = new Con_CRUD();
        string sqlR = "select * from returningbook";
        string sqlRS = "select * from student";
        string id = frmLogin.id_user;
        public frmTraSach()
        {
            InitializeComponent();
        }

        private void loadStudent()
        {
            DataTable dt = con.readData(sqlRS);
            if (dt != null)
            {
                gridControl2.DataSource = dt;
            }
        }

        private void loadReturningBook()
        {
            string sql = "select lendingbook.id_user, provided.id_book, lendingbook.id_lendingbook, lendingbook.id_provided, book.bookname, book.author, lendingbook.lendingdate, lendingbook.dateexpect, lendingbook.deposit from lendingbook join provided on lendingbook.id_provided = provided.id_provided join book on provided.id_book = book.id_book where lendingbook.id_student = '" + txtMaDocGia.EditValue.ToString() + "'";
            DataTable dt = con.readData(sql);
            if (dt != null)
            {
                gcSachDangMuon.DataSource = dt;
            }
        }

        private void frmTraSach_Load(object sender, EventArgs e)
        {
            loadStudent();
        }

        private void btnTraSach_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int row_index = gvSachDangMuon.FocusedRowHandle;
            DateTime firstDT = Convert.ToDateTime(gvSachDangMuon.GetRowCellValue(row_index, "dateexpect").ToString());
            DateTime secondDT = DateTime.Now.Date;
            if (DateTime.Compare(firstDT, secondDT) > 0)
            {
                if (XtraMessageBox.Show("Sách trả trước ngày hẹn\r\nBạn có muốn trả sách này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    processReturnBook();
                }
            }
            else if (DateTime.Compare(firstDT, secondDT) < 0)
            {
                if (XtraMessageBox.Show("Sách trả sau ngày hẹn\r\nBạn có muốn trả sách này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    processReturnBook();
                }
            }
            else
            {
                if (XtraMessageBox.Show("Sách trả đúng ngày hẹn\r\nBạn có muốn trả sách này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    processReturnBook();
                }
            }
        }

        private void processReturnBook()
        {
            int row_index = gvSachDangMuon.FocusedRowHandle;
            int amount = 0;
            int fine = 0;
            if(XtraMessageBox.Show("Sách có bị hỏng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                fine = Convert.ToInt32(gvSachDangMuon.GetRowCellValue(row_index, "deposit"));
            }
            string sqlRB = "select amount from provided where id_provided = '" + gvSachDangMuon.GetRowCellValue(row_index, "id_provided").ToString() + "'";
            DataTable dt = new DataTable();
            dt = con.readData(sqlRB);
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    amount = Convert.ToInt32(dr["amount"].ToString());
                }
            }
            if(fine == 0)
            {
                amount++;
            }
            string sqlU = "update provided set amount = '" + amount + "' where id_provided = '" + gvSachDangMuon.GetRowCellValue(row_index, "id_provided").ToString() + "'";
            string sqlC = "insert into returningbook values ('" + con.creatId("RB", sqlR) + "', '" + id + "', '" + gvSachDangMuon.GetRowCellValue(row_index, "id_provided").ToString() + "', '" + txtMaDocGia.EditValue.ToString() + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + fine + "')";
            string sqlD = "delete from lendingbook where id_lendingbook = '" + gvSachDangMuon.GetRowCellValue(row_index, "id_lendingbook").ToString() + "'";
            if (con.exeData(sqlU) && con.exeData(sqlD) && con.exeData(sqlC))
            {
                XtraMessageBox.Show("Trả sách thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gvSachDangMuon.DeleteSelectedRows();
            }
            else
            {
                XtraMessageBox.Show("Trả sách thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                
            }
        }        

        private void gridControl2_MouseCaptureChanged(object sender, EventArgs e)
        {
            int row_index = gvDocGia.FocusedRowHandle;
            string colID = "id_student";
            string colName = "fullname";
            string colDOB = "dob";
            string colAddress = "address";
            string colNumber = "number";
            if ((gvDocGia.GetRowCellValue(row_index, colID) != null) && (gvDocGia.GetRowCellValue(row_index, colName) != null) && (gvDocGia.GetRowCellValue(row_index, colDOB) != null) && (gvDocGia.GetRowCellValue(row_index, colAddress) != null) && (gvDocGia.GetRowCellValue(row_index, colNumber) != null))
            {
                txtMaDocGia.EditValue = gvDocGia.GetRowCellValue(row_index, colID).ToString();
                txtHoTen.EditValue = gvDocGia.GetRowCellValue(row_index, colName).ToString();
                txtNgaySinh.EditValue = Convert.ToDateTime(gvDocGia.GetRowCellValue(row_index, colDOB).ToString()).ToString("dd-MM-yyyy");
                txtDiaChi.EditValue = gvDocGia.GetRowCellValue(row_index, colAddress).ToString();
                txtSoDienThoai.EditValue = gvDocGia.GetRowCellValue(row_index, colNumber).ToString();
            }
            loadReturningBook();
        }
    }
}