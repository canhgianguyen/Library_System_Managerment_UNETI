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
    public partial class frmQuanLyTheLoai : DevExpress.XtraEditors.XtraForm
    {
        Con_CRUD con = new Con_CRUD();
        string sqlR = "select * from booktype";
        public frmQuanLyTheLoai()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            DataTable dt = con.readData(sqlR);
            if (dt != null)
            {
                gcQuanLyTheLoai.DataSource = dt;
            }
        }

        private void frmQuanLyTheLoai_Load(object sender, EventArgs e)
        {
            loadData();
        }        

        private void btnThem_Click(object sender, EventArgs e)
        {
            if ((txtTenLoaiSach.EditValue == null) || (txtTenLoaiSach.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa nhập tên loại sách\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenLoaiSach.Focus();
                return;
            }
            bool checkB = false;
            string sql = "select booktypename from booktype where booktypename = N'" + txtTenLoaiSach.EditValue.ToString().Trim() + "'";
            DataTable dt = new DataTable();
            dt = con.readData(sql);
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (txtTenLoaiSach.EditValue.ToString().Trim().Equals(dr["booktypename"].ToString()))
                    {
                        checkB = true;
                        break;
                    }
                }
            }
            if (checkB)
            {
                XtraMessageBox.Show("Loại sách có tên \"" + txtTenLoaiSach.EditValue.ToString() + "\" đã tồn tại\r\nVui lòng nhập tên khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLamMoi.PerformClick();
                return;
            }
            string sqlC = "insert into booktype values ('" + con.creatId("BT", sqlR) + "', N'" + txtTenLoaiSach.EditValue.ToString() + "')";
            if (con.exeData(sqlC))
            {
                loadData();
                XtraMessageBox.Show("Thêm loại sách thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLamMoi.PerformClick();
            }
            else
            {
                XtraMessageBox.Show("Thêm loại sách thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaLoaiSach.EditValue == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn loại sách để sửa\r\nVui lòng chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((txtTenLoaiSach.EditValue == null) || (txtTenLoaiSach.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Tên loại sách không được phép để trống\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenLoaiSach.Focus();
                return;
            }
            bool checkB = false;
            string sql = "select booktypename from booktype where booktypename = N'" + txtTenLoaiSach.EditValue.ToString().Trim() + "'";
            DataTable dt = new DataTable();
            dt = con.readData(sql);
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (txtTenLoaiSach.EditValue.ToString().Trim().Equals(dr["booktypename"].ToString()))
                    {
                        checkB = true;
                        break;
                    }
                }
            }
            if (checkB)
            {
                XtraMessageBox.Show("Loại sách có tên \"" + txtTenLoaiSach.EditValue.ToString() + "\" đã tồn tại\r\nVui lòng nhập tên khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLamMoi.PerformClick();
                return;
            }
            if (XtraMessageBox.Show("Bạn có chắc chắn muốn sửa loại sách đang chọn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {                
                string sqlU = "update booktype set booktypename = N'" + txtTenLoaiSach.EditValue.ToString() + "' where id_booktype = '" + txtMaLoaiSach.EditValue.ToString() + "'";
                if (con.exeData(sqlU))
                {
                    loadData();
                    XtraMessageBox.Show("Sửa loại sách thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLamMoi.PerformClick();
                }
                else
                {
                    XtraMessageBox.Show("Sửa loại sách thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaLoaiSach.EditValue == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn loại sách để xoá\r\nVui lòng chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (XtraMessageBox.Show("Bạn có chắc chắn muốn xoá loại sách đang chọn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sqlD = "delete from booktype where id_booktype = '" + txtMaLoaiSach.EditValue.ToString() + "'";
                if (con.exeData(sqlD))
                {
                    loadData();
                    XtraMessageBox.Show("Xoá loại sách thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLamMoi.PerformClick();
                }
                else
                {
                    XtraMessageBox.Show("Xoá loại sách thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaLoaiSach.EditValue = null;
            txtTenLoaiSach.EditValue = null;
            txtTenLoaiSach.Focus();
        }

        private void gcQuanLyTheLoai_MouseCaptureChanged(object sender, EventArgs e)
        {
            int row_index = gvQuanLyTheLoai.FocusedRowHandle;
            string colID = "id_booktype";
            string colName = "booktypename";
            if ((gvQuanLyTheLoai.GetRowCellValue(row_index, colID) != null) && (gvQuanLyTheLoai.GetRowCellValue(row_index, colName) != null))
            {
                txtMaLoaiSach.EditValue = gvQuanLyTheLoai.GetRowCellValue(row_index, colID).ToString();
                txtTenLoaiSach.EditValue = gvQuanLyTheLoai.GetRowCellValue(row_index, colName).ToString();
            }
        }
    }
}