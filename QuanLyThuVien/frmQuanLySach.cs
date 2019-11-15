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
    public partial class frmQuanLySach : DevExpress.XtraEditors.XtraForm
    {
        Con_CRUD con = new Con_CRUD();
        string sqlR = "select * from book";
        string sqlRBT = "select * from booktype";
        public frmQuanLySach()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            DataTable dt = con.readData(sqlR);
            if (dt != null)
            {
                gcSach.DataSource = dt;
            }
        }

        private void loadBookType()
        {
            DataTable dt = con.readData(sqlRBT);
            if (dt != null)
            {
                lueLoaiSach.Properties.DataSource = dt;
                lueLoaiSach.Properties.DisplayMember = "booktypename";
                lueLoaiSach.Properties.ValueMember = "id_booktype";
            }
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {
        }

        private void frmQuanLySach_Load(object sender, EventArgs e)
        {
            loadData();
            loadBookType();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int namXuatban = -1;
            int soTrang = -1;            
            if ((txtTenSach.EditValue == null) || (txtTenSach.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa nhập tên sách\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenSach.Focus();
                return;
            }
            if ((txtTacGia.EditValue == null) || (txtTacGia.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa nhập tên tác giả\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTacGia.Focus();
                return;
            }
            if ((txtNhaXuatBan.EditValue == null) || (txtNhaXuatBan.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa nhập nhà xuất bản\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNhaXuatBan.Focus();
                return;
            }
            if ((txtNamXuatBan.EditValue == null) || (txtNamXuatBan.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa nhập năm xuất bản\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNamXuatBan.Focus();
                return;
            }
            if ((txtSoTrang.EditValue == null) || (txtSoTrang.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa nhập số trang\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoTrang.Focus();
                return;
            }
            if (lueLoaiSach.EditValue.Equals(""))
            {
                XtraMessageBox.Show("Bạn chưa chọn loại sách\r\nVui lòng chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lueLoaiSach.Focus();
                return;
            }
            try
            {
                namXuatban = Int32.Parse(txtNamXuatBan.EditValue.ToString());
                if ((namXuatban < 1) || (namXuatban > DateTime.Now.Year))
                {
                    XtraMessageBox.Show("Năm xuất bản không được nhỏ hơn 1 hoặc lớn hơn năm hiện tại\r\nVui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNamXuatBan.Focus();
                    return;
                }
            }
            catch (Exception)
            {

                XtraMessageBox.Show("Năm xuất bản phải là số\r\nVui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNamXuatBan.Focus();
                return;
            }
            try
            {
                soTrang = Int32.Parse(txtSoTrang.EditValue.ToString());
                if (soTrang < 1)
                {
                    XtraMessageBox.Show("Số trang không được phép nhỏ hơn 1\r\nVui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSoTrang.Focus();
                    return;
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Số trang phải là số\r\nVui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoTrang.Focus();
                return;
            }
            bool checkB = false;
            string sql = "select id_booktype, bookname from book where id_booktype = '" + lueLoaiSach.EditValue.ToString().Trim() + "' and bookname = N'" + txtTenSach.EditValue.ToString().Trim() + "'";
            DataTable dt = new DataTable();
            dt = con.readData(sql);
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (lueLoaiSach.EditValue.ToString().Trim().Equals(dr["id_booktype"].ToString()) && txtTenSach.EditValue.ToString().Trim().Equals(dr["bookname"].ToString()))
                    {
                        checkB = true;
                        break;
                    }
                }
            }
            if (checkB)
            {
                XtraMessageBox.Show("Sách có tên \"" + txtTenSach.EditValue.ToString() + "\" thuộc loại sách có mã \"" + lueLoaiSach.EditValue.ToString() + "\" đã tồn tại\r\nVui lòng nhập tên khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLamMoi.PerformClick();
                return;
            }
            string sqlC = "insert into book values ('" + con.creatId("B", sqlR) + "', '" + lueLoaiSach.EditValue.ToString() + "', N'" + txtTenSach.EditValue.ToString() + "', N'" + txtTacGia.EditValue.ToString() + "', N'" + txtNhaXuatBan.EditValue.ToString() + "', '" + namXuatban + "', '" + soTrang + "')";
            if (con.exeData(sqlC))
            {
                loadData();
                XtraMessageBox.Show("Thêm sách thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLamMoi.PerformClick();
            }
            else
            {
                XtraMessageBox.Show("Thêm sách thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaSach.EditValue == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn sách để sửa\r\nVui lòng chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((txtTenSach.EditValue == null) || (txtTenSach.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Tên sách không được phép để trống\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenSach.Focus();
                return;
            }
            if ((txtTacGia.EditValue == null) || (txtTacGia.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Tên tác giả không được phép để trống\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTacGia.Focus();
                return;
            }
            if ((txtNhaXuatBan.EditValue == null) || (txtNhaXuatBan.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Nhà xuất bản không được phép để trống\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNhaXuatBan.Focus();
                return;
            }
            int namXuatban = -1;
            int soTrang = -1;
            try
            {
                namXuatban = Int32.Parse(txtNamXuatBan.EditValue.ToString());
                if ((namXuatban < 1) || (namXuatban > DateTime.Now.Year))
                {
                    XtraMessageBox.Show("Năm xuất bản không được nhỏ hơn 1 hoặc lớn hơn năm hiện tại\r\nVui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNamXuatBan.Focus();
                    return;
                }
            }
            catch (Exception)
            {

                XtraMessageBox.Show("Năm xuất bản phải là số\r\nVui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNamXuatBan.Focus();
                return;
            }
            try
            {
                soTrang = Int32.Parse(txtSoTrang.EditValue.ToString());
                if (soTrang < 1)
                {
                    XtraMessageBox.Show("Số trang không được phép nhỏ hơn 1\r\nVui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSoTrang.Focus();
                    return;
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Số trang phải là số\r\nVui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoTrang.Focus();
                return;
            }
            bool checkB = false;
            string sql = "select id_booktype, bookname from book where id_booktype = '" + lueLoaiSach.EditValue.ToString().Trim() + "' and bookname = N'" + txtTenSach.EditValue.ToString().Trim() + "'";
            DataTable dt = new DataTable();
            dt = con.readData(sql);
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (lueLoaiSach.EditValue.ToString().Trim().Equals(dr["id_booktype"].ToString()) && txtTenSach.EditValue.ToString().Trim().Equals(dr["bookname"].ToString()))
                    {
                        checkB = true;
                        break;
                    }
                }
            }
            if (checkB)
            {
                XtraMessageBox.Show("Sách có tên \"" + txtTenSach.EditValue.ToString() + "\" thuộc loại sách có mã \"" + lueLoaiSach.EditValue.ToString() + "\" đã tồn tại\r\nVui lòng nhập tên khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLamMoi.PerformClick();
                return;
            }
            if (XtraMessageBox.Show("Bạn có chắc chắn muốn sửa sách đang chọn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {                
                string sqlU = "update book set bookname = N'" + txtTenSach.EditValue.ToString() + "', author = N'" + txtTacGia.EditValue.ToString() + "', publisher = N'" + txtNhaXuatBan.EditValue.ToString() + "', publishingyear = '" + namXuatban + "', pages = '" + soTrang + "', id_booktype = '" + lueLoaiSach.EditValue.ToString() + "' where id_book = '" + txtMaSach.EditValue.ToString() + "'";
                if (con.exeData(sqlU))
                {
                    loadData();
                    XtraMessageBox.Show("Sửa sách thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLamMoi.PerformClick();
                }
                else
                {
                    XtraMessageBox.Show("Sửa sách thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaSach.EditValue == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn sách để xoá\r\nVui lòng chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (XtraMessageBox.Show("Bạn có chắc chắn muốn xoá sách đang chọn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sqlD = "delete from book where id_book = '" + txtMaSach.EditValue.ToString() + "'";
                if (con.exeData(sqlD))
                {
                    loadData();
                    XtraMessageBox.Show("Xoá sách thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLamMoi.PerformClick();
                }
                else
                {
                    XtraMessageBox.Show("Xoá sách thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSach.EditValue = null;
            txtTenSach.EditValue = null;
            txtTacGia.EditValue = null;
            txtNhaXuatBan.EditValue = null;
            txtNamXuatBan.EditValue = null;
            txtSoTrang.EditValue = null;
            txtTenSach.Focus();
            lueLoaiSach.EditValue = "";
        }

        private void gcSach_MouseCaptureChanged(object sender, EventArgs e)
        {
            int row_index = gvSach.FocusedRowHandle;
            string colID = "id_book";
            string colName = "bookname";
            string colAuthor = "author";
            string colPublisher = "publisher";
            string colPublishingYear = "publishingyear";
            string colPages = "pages";
            string colType = "id_booktype";
            if ((gvSach.GetRowCellValue(row_index, colID) != null) && (gvSach.GetRowCellValue(row_index, colName) != null) && (gvSach.GetRowCellValue(row_index, colAuthor) != null) && (gvSach.GetRowCellValue(row_index, colPublisher) != null) && (gvSach.GetRowCellValue(row_index, colPublishingYear) != null) && (gvSach.GetRowCellValue(row_index, colPages) != null) && (gvSach.GetRowCellValue(row_index, colType) != null))
            {
                txtMaSach.EditValue = gvSach.GetRowCellValue(row_index, colID).ToString();
                txtTenSach.EditValue = gvSach.GetRowCellValue(row_index, colName).ToString();
                txtTacGia.EditValue = gvSach.GetRowCellValue(row_index, colAuthor).ToString();
                txtNhaXuatBan.EditValue = gvSach.GetRowCellValue(row_index, colPublisher).ToString();
                txtNamXuatBan.EditValue = gvSach.GetRowCellValue(row_index, colPublishingYear).ToString();
                txtSoTrang.EditValue = gvSach.GetRowCellValue(row_index, colPages).ToString();
                lueLoaiSach.EditValue = gvSach.GetRowCellValue(row_index, colType).ToString();
            }
        }
    }
}