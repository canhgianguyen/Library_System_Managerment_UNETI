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
    public partial class frmQuanLyNhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        Con_CRUD con = new Con_CRUD();
        string sqlR = "select * from bookprovider";

        public frmQuanLyNhaCungCap()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            DataTable dt = con.readData(sqlR);
            if (dt != null)
            {
                gcQuanLyNhaCungCap.DataSource = dt;
            }
        }

        private void frmQuanLyNhaCungCap_Load(object sender, EventArgs e)
        {
            loadData();            
        }        

        private void simpleButton1_Click(object sender, EventArgs e) //btnThem
        {
            if ((txtTenNhaCungCap.EditValue == null) || (txtTenNhaCungCap.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa nhập tên nhà cung cấp\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNhaCungCap.Focus();
                return;
            }
            bool checkB = false;
            string sql = "select providername from bookprovider where providername = N'" + txtTenNhaCungCap.EditValue.ToString().Trim()+ "'";
            DataTable dt = new DataTable();
            dt = con.readData(sql);
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (txtTenNhaCungCap.EditValue.ToString().Trim().Equals(dr["providername"].ToString()))
                    {
                        checkB = true;
                        break;
                    }
                }
            }
            if (checkB)
            {
                XtraMessageBox.Show("Nhà cung cấp có tên \"" + txtTenNhaCungCap.EditValue.ToString() +"\" đã tồn tại\r\nVui lòng nhập tên khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLamMoi.PerformClick();
                return;
            }
            string sqlC = "insert into bookprovider values ('" + con.creatId("BP", sqlR) + "', N'" + txtTenNhaCungCap.EditValue.ToString() + "')";
            if (con.exeData(sqlC))
            {
                loadData();
                XtraMessageBox.Show("Thêm nhà cung cấp thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLamMoi.PerformClick();
            }
            else
            {
                XtraMessageBox.Show("Thêm nhà cung cấp thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNhaCungcap.EditValue == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn nhà cung cấp để sửa\r\nVui lòng chọn!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if ((txtTenNhaCungCap.EditValue == null) || (txtTenNhaCungCap.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Tên nhà cung cấp không được phép để trống\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNhaCungCap.Focus();
                return;
            }
            bool checkB = false;
            string sql = "select providername from bookprovider where providername = N'" + txtTenNhaCungCap.EditValue.ToString().Trim() + "'";
            DataTable dt = new DataTable();
            dt = con.readData(sql);
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (txtTenNhaCungCap.EditValue.ToString().Trim().Equals(dr["providername"].ToString()))
                    {
                        checkB = true;
                        break;
                    }
                }
            }
            if (checkB)
            {
                XtraMessageBox.Show("Nhà cung cấp có tên \"" + txtTenNhaCungCap.EditValue.ToString() + "\" đã tồn tại\r\nVui lòng nhập tên khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLamMoi.PerformClick();
                return;
            }
            if (XtraMessageBox.Show("Bạn có chắc chắn muốn sửa nhà cung cấp đang chọn?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sqlU = "update bookprovider set providername = N'" + txtTenNhaCungCap.EditValue.ToString() + "' where id_bookprovider = '" + txtMaNhaCungcap.EditValue.ToString() + "'";
                if (con.exeData(sqlU))
                {
                    loadData();
                    XtraMessageBox.Show("Sửa nhà cung cấp thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtLamMoi.PerformClick();
                }
                else
                {
                    XtraMessageBox.Show("Sửa nhà cung cấp thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(txtMaNhaCungcap.EditValue == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn nhà cung cấp để xoá\r\nVui lòng chọn!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (XtraMessageBox.Show("Bạn có chắc chắn muốn xoá nhà cung cấp đang chọn?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sqlD = "delete from bookprovider where id_bookprovider = '" + txtMaNhaCungcap.EditValue.ToString() + "'";
                if(con.exeData(sqlD))
                {
                    loadData();
                    XtraMessageBox.Show("Xoá nhà cung cấp thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtLamMoi.PerformClick();
                }
                else
                {
                    XtraMessageBox.Show("Xoá nhà cung cấp thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtLamMoi_Click(object sender, EventArgs e)
        {
            txtMaNhaCungcap.EditValue = null;
            txtTenNhaCungCap.EditValue = null;
            txtTenNhaCungCap.Focus();
        }

        private void gcQuanLyNhaCungCap_MouseCaptureChanged(object sender, EventArgs e)
        {
            int row_index = gvQuanLyNhaCungCap.FocusedRowHandle;
            string colID = "id_bookprovider";
            string colName = "providername";
            if ((gvQuanLyNhaCungCap.GetRowCellValue(row_index, colID) != null) && (gvQuanLyNhaCungCap.GetRowCellValue(row_index, colName) != null))
            {
                txtMaNhaCungcap.EditValue = gvQuanLyNhaCungCap.GetRowCellValue(row_index, colID).ToString();
                txtTenNhaCungCap.EditValue = gvQuanLyNhaCungCap.GetRowCellValue(row_index, colName).ToString();
            }
        }

        private void gcQuanLyNhaCungCap_MouseClick(object sender, MouseEventArgs e)
        {            
        }        

        private void labelControl1_Click(object sender, EventArgs e)
        {
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void gcQuanLyNhaCungCap_Click(object sender, EventArgs e)
        {
        }
    }
}