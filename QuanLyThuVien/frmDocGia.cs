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
    public partial class frmDocGia : DevExpress.XtraEditors.XtraForm
    {
        Con_CRUD con = new Con_CRUD();
        string sqlR = "select * from student";
        public frmDocGia()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            DataTable dt = con.readData(sqlR);
            if (dt != null)
            {
                gcDocGia.DataSource = dt;
            }
        }

        private void frmDocGia_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if ((txtTenDocGia.EditValue == null) || (txtTenDocGia.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa nhập tên độc giả\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenDocGia.Focus();
                return;
            }
            if ((txtNgaySinh.EditValue == null) || (txtNgaySinh.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa chọn ngày sinh\r\nVui lòng chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNgaySinh.Focus();
                return;
            }
            if ((txtDiaChi.EditValue == null) || (txtDiaChi.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa nhậo địa chỉ\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
                return;
            }
            if ((txtSoDienThoai.EditValue == null) || (txtSoDienThoai.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa nhập số điện thoại\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoDienThoai.Focus();
                return;
            }
            int soDienThoai = 0;
            try
            {
                soDienThoai = Convert.ToInt32(txtSoDienThoai.EditValue.ToString());
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Số điện thoại phải là số\r\nVui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoDienThoai.Focus();
                return;
            }
            string sqlC = "insert into student values ('" + con.creatId("S", sqlR) + "', N'" + txtTenDocGia.EditValue.ToString() + "', '" + Convert.ToDateTime(txtNgaySinh.EditValue.ToString()).ToString("yyyy-MM-dd") + "', N'" + txtDiaChi.EditValue.ToString() + "', '" + txtSoDienThoai.EditValue.ToString() + "')";
            if (con.exeData(sqlC))
            {
                loadData();
                XtraMessageBox.Show("Thêm độc giả thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLamMoi.PerformClick();
            }
            else
            {
                XtraMessageBox.Show("Thêm độc giả thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaDocGia.EditValue == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn độc giả để sửa\r\nVui lòng chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((txtTenDocGia.EditValue == null) || (txtTenDocGia.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Tên độc giả không được phép để trống\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenDocGia.Focus();
                return;
            }
            if ((txtNgaySinh.EditValue == null) || (txtNgaySinh.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Ngày sinh không được phép để trống\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNgaySinh.Focus();
                return;
            }
            if ((txtDiaChi.EditValue == null) || (txtDiaChi.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Địa chỉ không được phép để trống\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
                return;
            }
            if ((txtSoDienThoai.EditValue == null) || (txtSoDienThoai.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Số điện thoại không được phép để trống\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoDienThoai.Focus();
                return;
            }
            int soDienThoai = 0;
            try
            {
                soDienThoai = Convert.ToInt32(txtSoDienThoai.EditValue.ToString());
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Số điện thoại phải là số\r\nVui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoDienThoai.Focus();
                return;
            }            
            if (XtraMessageBox.Show("Bạn có chắc chắn muốn sửa độc giả đang chọn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sqlU = "update student set fullname = N'" + txtTenDocGia.EditValue.ToString() + "', dob = '" + Convert.ToDateTime(txtNgaySinh.EditValue.ToString()).ToString("yyyy-MM-dd") + "', address = N'" + txtDiaChi.EditValue.ToString() + "', number = '" + txtSoDienThoai.EditValue.ToString() + "' where id_student = '" + txtMaDocGia.EditValue.ToString() + "'";
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
            if (txtMaDocGia.EditValue == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn độc giả để xoá\r\nVui lòng chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (XtraMessageBox.Show("Bạn có chắc chắn muốn xoá độc giả đang chọn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sqlD = "delete from student where id_student = '" + txtMaDocGia.EditValue.ToString() + "'";
                if (con.exeData(sqlD))
                {
                    loadData();
                    XtraMessageBox.Show("Xoá độc giả thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLamMoi.PerformClick();
                }
                else
                {
                    XtraMessageBox.Show("Xoá độc giả thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaDocGia.EditValue = null;
            txtTenDocGia.EditValue = null;
            txtNgaySinh.EditValue = null;
            txtDiaChi.EditValue = null;
            txtSoDienThoai.EditValue = null;
            txtTenDocGia.Focus();
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
                txtTenDocGia.EditValue = gvDocGia.GetRowCellValue(row_index, colName).ToString();
                txtNgaySinh.EditValue = Convert.ToDateTime(gvDocGia.GetRowCellValue(row_index, colDOB).ToString()).ToString("dd/MM/yyyy");
                txtDiaChi.EditValue = gvDocGia.GetRowCellValue(row_index, colAddress).ToString();
                txtSoDienThoai.EditValue = gvDocGia.GetRowCellValue(row_index, colNumber).ToString();                
            }
        }
    }
}