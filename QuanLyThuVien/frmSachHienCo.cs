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
    public partial class frmSachHienCo : DevExpress.XtraEditors.XtraForm
    {
        Con_CRUD con = new Con_CRUD();
        string sqlR = "select provided.id_provided, provided.id_bookprovider, provided.id_book, book.bookname, provided.date, provided.amount, provided.deposit from book join provided on provided.id_book = book.id_book";
        string sqlRBP = "select * from bookprovider";
        string sqlRB = "select id_book, bookname from book";

        public frmSachHienCo()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            DataTable dt = con.readData(sqlR);
            if (dt != null)
            {
                gcSachHienCo.DataSource = dt;
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

        private void loadBookProvider()
        {
            DataTable dt = con.readData(sqlRBP);
            if (dt != null)
            {
                lueNhaCungCap.Properties.DataSource = dt;
                lueNhaCungCap.Properties.DisplayMember = "providername";
                lueNhaCungCap.Properties.ValueMember = "id_bookprovider";
            }
        }        

        private void frmSachHienCo_Load(object sender, EventArgs e)
        {
            loadData();
            loadBookProvider();
            loadBook();            
        }        

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {            
        }

        private void txtTimKiemSach_EditValueChanged(object sender, EventArgs e)
        {            
        }

        private void gcSach_MouseCaptureChanged(object sender, EventArgs e)
        {
            int row_index = gvSach.FocusedRowHandle;
            string colID = "id_book";
            string colName = "bookname";
            if ((gvSach.GetRowCellValue(row_index, colID) != null) && (gvSach.GetRowCellValue(row_index, colName) != null))
            {
                txtMaSach.EditValue = gvSach.GetRowCellValue(row_index, colID).ToString();
                txtTenSach.EditValue = gvSach.GetRowCellValue(row_index, colName).ToString();                
            }
        }

        private void gcSachHienCo_Click(object sender, EventArgs e)
        {
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int soLuong = -1;
            int deposit = -1;            
            if (lueNhaCungCap.EditValue.Equals(""))
            {
                XtraMessageBox.Show("Bạn chưa chọn nhà cung cấp\r\nVui lòng chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lueNhaCungCap.Focus();
                return;
            }
            if ((txtMaSach.EditValue == null) || (txtTenSach.EditValue == null))
            {
                XtraMessageBox.Show("Bạn chưa chọn sách để thêm vào thư viện\r\nVui lòng chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((txtSoLuong.EditValue == null) || (txtSoLuong.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa nhập số lượng\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuong.Focus();
                return;
            }
            try
            {
                soLuong = Int32.Parse(txtSoLuong.EditValue.ToString());
                if (soLuong< 1)
                {
                    XtraMessageBox.Show("Số lượng sách không được nhỏ hơn 1\r\nVui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSoLuong.Focus();
                    return;
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Số lượng phải là số\r\nVui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuong.Focus();
                return;
            }
            if ((txtDeposit.EditValue == null) || (txtDeposit.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa nhập tiền đặt cọc\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDeposit.Focus();
                return;
            }
            try
            {
                deposit = Int32.Parse(txtDeposit.EditValue.ToString());
                if (soLuong < 1)
                {
                    XtraMessageBox.Show("Tiền đặt cọc không được nhỏ hơn 1\r\nVui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDeposit.Focus();
                    return;
                }
            }
            catch (Exception)
            {

                XtraMessageBox.Show("Tiền đặt cọc phải là số\r\nVui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDeposit.Focus();
                return;
            }            
            bool checkB = false;
            string sql = "select id_bookprovider, id_book from provided";
            DataTable dt = new DataTable();
            dt = con.readData(sql);
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (txtMaSach.EditValue.ToString().Equals(dr["id_book"].ToString()) && lueNhaCungCap.EditValue.ToString().Equals(dr["id_bookprovider"].ToString()))
                    {
                        checkB = true;
                        break;
                    }
                }
            }
            if (checkB)
            {
                XtraMessageBox.Show("Sách có tên \"" + txtTenSach.EditValue.ToString() + "\" thuộc nhà cung cấp có mã \"" + lueNhaCungCap.EditValue.ToString().Trim() + "\" đã được thêm vào thư viện\r\nVui lòng chọn sách khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string sqlC = "insert into provided values ('" + con.creatId("P", sqlR) + "', '" + lueNhaCungCap.EditValue.ToString() + "', '" + txtMaSach.EditValue.ToString() + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + soLuong + "', '" + deposit + "')";
            if (con.exeData(sqlC))
            {
                loadData();
                XtraMessageBox.Show("Thêm sách vào thư viện thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLamMoi.PerformClick();
            }
            else
            {
                XtraMessageBox.Show("Thêm sách vào thư viện thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int soLuong = -1;
            int deposit = -1;            
            if ((txtSoLuong.EditValue == null) || (txtMaSach.EditValue == null) || (lueNhaCungCap.EditValue.Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa chọn sách để sửa\r\nVui lòng chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                soLuong = Int32.Parse(txtSoLuong.EditValue.ToString());
                if (soLuong < 1)
                {
                    XtraMessageBox.Show("Số lượng sách không được nhỏ hơn 1\r\nVui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSoLuong.Focus();
                    return;
                }
            }
            catch (Exception)
            {

                XtraMessageBox.Show("Số luọng phải là số\r\nVui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuong.Focus();
                return;
            }
            if ((txtDeposit.EditValue == null) || (txtDeposit.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa nhập tiền đặt cọc\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDeposit.Focus();
                return;
            }
            try
            {
                deposit = Int32.Parse(txtDeposit.EditValue.ToString());
                if (soLuong < 1)
                {
                    XtraMessageBox.Show("Tiền đặt cọc không được nhỏ hơn 1\r\nVui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDeposit.Focus();
                    return;
                }
            }
            catch (Exception)
            {

                XtraMessageBox.Show("Tiền đặt cọc phải là số\r\nVui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDeposit.Focus();
                return;
            }
            if (XtraMessageBox.Show("Bạn có chắc chắn muốn sửa sách đang chọn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {                
                string sqlU = "update provided set amount = '" + soLuong + "', deposit = '" + deposit + "' where id_bookprovider = '" + lueNhaCungCap.EditValue.ToString() + "' and id_book = '" + txtMaSach.EditValue.ToString() + "'";
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
            if ((txtSoLuong.EditValue == null) || (txtMaSach.EditValue == null) || (lueNhaCungCap.EditValue.Equals("")) || (txtSoLuong.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa chọn sách để xoá\r\nVui lòng chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (XtraMessageBox.Show("Bạn có chắc chắn muốn xoá sách đang chọn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sqlD = "delete from provided where id_bookprovider = '" + lueNhaCungCap.EditValue.ToString() + "' and id_book = '" + txtMaSach.EditValue.ToString() + "'";
                if (con.exeData(sqlD))
                {
                    loadData();
                    XtraMessageBox.Show("Xoá sách khỏi thư viện thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLamMoi.PerformClick();
                }
                else
                {
                    XtraMessageBox.Show("Xoá sách khỏi thư viện thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            lueNhaCungCap.EditValue = "";
            txtMaSach.EditValue = null;
            txtTenSach.EditValue = null;
            txtSoLuong.EditValue = null;
            txtDeposit.EditValue = null;
        }

        private void gcSachHienCo_MouseCaptureChanged(object sender, EventArgs e)
        {
            int row_index = gvSachHienCo.FocusedRowHandle;
            string colIDProvider = "id_bookprovider";
            string colIDBook = "id_book";
            string colBookName = "bookname";
            string colAmount = "amount";
            string colDeposit = "deposit";
            if ((gvSachHienCo.GetRowCellValue(row_index, id_bookprovider) != null) && (gvSachHienCo.GetRowCellValue(row_index, colIDBook) != null) && (gvSachHienCo.GetRowCellValue(row_index, colBookName) != null) && (gvSachHienCo.GetRowCellValue(row_index, colAmount) != null))
            {
                lueNhaCungCap.EditValue = gvSachHienCo.GetRowCellValue(row_index, colIDProvider).ToString();
                txtMaSach.EditValue = gvSachHienCo.GetRowCellValue(row_index, colIDBook).ToString();
                txtTenSach.EditValue = gvSachHienCo.GetRowCellValue(row_index, colBookName).ToString();
                txtSoLuong.EditValue = gvSachHienCo.GetRowCellValue(row_index, colAmount).ToString();
                txtDeposit.EditValue = gvSachHienCo.GetRowCellValue(row_index, colDeposit).ToString();
            }
        }

    }
}