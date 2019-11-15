using DevExpress.XtraEditors;
using QuanLyThuVien.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class frmMuonSach : DevExpress.XtraEditors.XtraForm
    {
        Con_CRUD con = new Con_CRUD();
        string sqlR = "select * from lendingbook";
        string sqlRS = "select * from student";
        string sqlRB = "select book.id_book, book.bookname, book.author, provided.id_provided, book.publisher, provided.deposit from book join provided on book.id_book = provided.id_book";
        string id = frmLogin.id_user;
        DataTable dtSachMuon;
        DataTable dtPhieuMuon;
        public static rptPhieuMuon rpt = new rptPhieuMuon();

        public frmMuonSach()
        {
            InitializeComponent();
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {
        }
        private void loadStudent()
        {
            DataTable dt = con.readData(sqlRS);
            if (dt != null)
            {
                gcDocGia.DataSource = dt;
            }
        }

        private void loadBook()
        {
            DataTable dt = con.readData(sqlRB);
            if (dt != null)
            {
                gcSach.DataSource = dt;
            }
        }

        private void creatDTLendingBook()
        {
            dtSachMuon = new DataTable();
            dtSachMuon.Columns.Add("id_book");
            dtSachMuon.Columns.Add("bookname");
            dtSachMuon.Columns.Add("author");
            dtSachMuon.Columns.Add("lendingdate");
            dtSachMuon.Columns.Add("dateexpect");
            dtSachMuon.Columns.Add("deposit");
            dtSachMuon.Columns["deposit"].DataType = typeof(Int32);
            dtSachMuon.Columns.Add("id_provided");
        }

        private void creatDTPhieuMuon()
        {
            dtPhieuMuon = new DataTable();
            dtPhieuMuon.Columns.Add("id_book");
            dtPhieuMuon.Columns.Add("bookname");
            dtPhieuMuon.Columns.Add("author");
            dtPhieuMuon.Columns.Add("lendingdate");
            dtPhieuMuon.Columns.Add("dateexpect");
            dtPhieuMuon.Columns.Add("deposit");
            dtPhieuMuon.Columns["deposit"].DataType = typeof(Int32);
            foreach (DataRow item in dtSachMuon.Rows)
            {
                DataRow row = dtPhieuMuon.NewRow();
                row["id_book"] = item["id_book"];
                row["bookname"] = item["bookname"];
                row["author"] = item["author"];
                row["lendingdate"] = item["lendingdate"];
                row["dateexpect"] = item["dateexpect"];
                row["deposit"] = item["deposit"];
                dtPhieuMuon.Rows.Add(row);
            }
        }

        private void loadLendingBook()
        {                        
            gcSachMuon.DataSource = dtSachMuon;
        }

        private void frmMuonSach_Load(object sender, EventArgs e)
        {
            loadStudent();
            loadBook();
            creatDTLendingBook();
            loadLendingBook();
        }

        private void frmMuonSach_Resize(object sender, EventArgs e)
        {
            if (this.Width > 1600)
            {
                gvDocGia.Columns["address"].Visible = true;
                gvSach.Columns["publisher"].Visible = true;
            }
            else
            {
                gvDocGia.Columns["address"].Visible = false;
                gvSach.Columns["publisher"].Visible = false;
            }
        }        

        private void btnLapPhieuMuon_Click(object sender, EventArgs e)
        {
            if ((txtMaDocGia.EditValue == null) || (txtMaDocGia.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa chọn độc giả\r\nVui lòng chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dtSachMuon.Rows.Count == 0)
            {
                XtraMessageBox.Show("Bạn chưa sách để mượn\r\nVui lòng chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int row_index = gvSachMuon.FocusedRowHandle;
            int amount = 0;
            bool check = false;
            foreach (DataRow item in dtSachMuon.Rows)
            {
                string sqlRB = "select amount from provided where id_provided = '" + item["id_provided"] + "'";
                DataTable dt = new DataTable();
                dt = con.readData(sqlRB);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        amount = Convert.ToInt32(dr["amount"].ToString()) - 1;
                    }
                }
                string sqlU = "update provided set amount = '" + amount + "' where id_provided = '" + item["id_provided"] + "'";
                string sqlC = "insert into lendingbook values ('" + con.creatId("LB", sqlR) + "', '" + id + "', '" + item["id_provided"] + "', '" + txtMaDocGia.EditValue.ToString() + "', '" + Convert.ToDateTime(item["lendingdate"].ToString()).ToString("yyyy-MM-dd") + "', '" + Convert.ToDateTime(item["dateexpect"].ToString()).ToString("yyyy-MM-dd") + "', '" + Convert.ToInt32(item["deposit"].ToString()) + "')";
                if (con.exeData(sqlU) && con.exeData(sqlC))
                {
                    check = true;
                }
                else
                {
                    break;
                }
            }
            if (check)
            {
                XtraMessageBox.Show("Lập phiếu mượn thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(XtraMessageBox.Show("Bạn có muốn xuất phiếu mượn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    creatDTPhieuMuon();
                    int tong = 0;
                    foreach (DataRow item in dtPhieuMuon.Rows)
                    {
                        tong += Convert.ToInt32(item["deposit"]);
                    }
                    rptPhieuMuon rp = new rptPhieuMuon();
                    rp.DataSource = dtPhieuMuon;
                    rp.initData(DateTime.Now.Day.ToString(), DateTime.Now.Month.ToString(), DateTime.Now.Year.ToString(), frmLogin.name_user, txtMaDocGia.EditValue.ToString(), txtHoTen.EditValue.ToString(), tong);
                    rpt = rp;
                    frmPhieuMuon frm = new frmPhieuMuon();
                    frm.Show();
                }
                btnLamMoi.PerformClick();
            }
            else
            {
                XtraMessageBox.Show("Lập phiếu mượn thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLamMoi.PerformClick();
            }
        }

        private void btnThem_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int row_index = gvSach.FocusedRowHandle;
            if ((txtMaDocGia.EditValue == null) || (txtMaDocGia.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa chọn độc giả\r\nVui lòng chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            bool checkB = false;
            string sql = "select id_provided from lendingbook where id_provided = '" + gvSach.GetRowCellValue(row_index, "id_provided").ToString() + "' and id_student = '" + txtMaDocGia.EditValue.ToString() + "'";
            DataTable dt = new DataTable();
            dt = con.readData(sql);
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (gvSach.GetRowCellValue(row_index, "id_provided").ToString().Equals(dr["id_provided"].ToString()))
                    {
                        checkB = true;
                        break;
                    }
                }
            }
            if (checkB)
            {
                XtraMessageBox.Show("Độc giả đã mượn sách này và chưa trả\r\nVui lòng chọn sách khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }            
            bool check = false;
            foreach (DataRow item in dtSachMuon.Rows)
            {
                if(item["id_book"].ToString().Equals(gvSach.GetRowCellValue(row_index, "id_book").ToString()))
                {
                    check = true;
                    break;
                }
            }
            if(check)
            {
                XtraMessageBox.Show("Bạn đã thêm sách này rồi\r\nVui lòng chọn sách khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            frmDatePicker frm = new frmDatePicker();
            if (frm.ShowDialog() == DialogResult.OK)
            {                
                DataRow row = dtSachMuon.NewRow();
                row["id_book"] = gvSach.GetRowCellValue(row_index, "id_book").ToString();
                row["bookname"] = gvSach.GetRowCellValue(row_index, "bookname").ToString();
                row["author"] = gvSach.GetRowCellValue(row_index, "author").ToString();
                row["lendingdate"] = DateTime.Now.ToString("dd-MM-yyyy");
                row["dateexpect"] = Convert.ToDateTime(frmDatePicker.date).ToString("dd/MM/yyyy");
                row["deposit"] = Convert.ToInt32(gvSach.GetRowCellValue(row_index, "deposit"));
                row["id_provided"] = gvSach.GetRowCellValue(row_index, "id_provided").ToString();
                dtSachMuon.Rows.Add(row);
                loadLendingBook();
            }
        }          

        private void btnXoa_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc muốn xoá sách đang chọn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gvSachMuon.DeleteSelectedRows();
            }                   
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaDocGia.EditValue = null;
            txtHoTen.EditValue = null;
            txtNgaySinh.EditValue = null;
            txtDiaChi.EditValue = null;
            txtSoDienThoai.EditValue = null;
            dtSachMuon.Rows.Clear();
        }

        private void gcDocGia_MouseCaptureChanged(object sender, EventArgs e)
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
        }

        private void gcSach_EmbeddedNavigator_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e)
        {
        }

        private void gvSachMuon_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
        }

        private void groupControl3_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
