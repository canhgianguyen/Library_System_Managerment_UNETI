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
    public partial class frmQuanLyNhanVien : DevExpress.XtraEditors.XtraForm
    {
        Con_CRUD con = new Con_CRUD();
        string sqlR = "select id_user, username, fullname, state, mod from users";
        string id = frmLogin.id_user;
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
        }        

        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            DataTable dt = con.readData(sqlR);
            if (dt != null)
            {
                gcNhanVien.DataSource = dt;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if ((txtTenTaiKhoan.EditValue == null) || (txtTenTaiKhoan.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa nhập tên Tài khoản\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenTaiKhoan.Focus();
                return;
            }
            if ((txtHoTen.EditValue == null) || (txtHoTen.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa nhập họ tên\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHoTen.Focus();
                return;
            }
            if(!chkAdminYes.Checked && !chkAdminNo.Checked)
            {
                XtraMessageBox.Show("Bạn chưa chọn chức vụ\r\nVui lòng chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool check = false;            
            string sql = "select username from users";
            DataTable dt = new DataTable();
            dt = con.readData(sql);
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if(txtTenTaiKhoan.EditValue.ToString().Trim().Equals(dr["username"].ToString()))
                    {
                        check = true;
                        break;
                    }                                      
                }
            }
            if (check)
            {
                XtraMessageBox.Show("Tên tài khoản đã tồn tại\r\nVui lòng chọn tên tài khoản khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenTaiKhoan.EditValue = null;
                txtTenTaiKhoan.Focus();
                return;
            }
            bool checkModUser = false;
            if(chkAdminYes.Checked)
            {
                checkModUser = true;                
            }                        
            string sqlC = "insert into users(id_user, username, password, fullname, sex, state, mod, dob) values ('" + con.creatId("U", sqlR) + "', '" + txtTenTaiKhoan.EditValue.ToString().Trim() + "', 'e1adc3949ba59abbe56e057f2f883e', N'" + txtHoTen.EditValue.ToString() + "', 'False', 'False', '" + checkModUser + "', '')";
            if (con.exeData(sqlC))
            {
                loadData();
                XtraMessageBox.Show("Thêm nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLamMoi.PerformClick();
            }
            else
            {
                XtraMessageBox.Show("Thêm nhân viên thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if ((txtMaNhanVien.EditValue == null) || (txtMaNhanVien.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa chọn nhân viên\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHoTen.Focus();
                return;
            }
            if ((txtHoTen.EditValue == null) || (txtHoTen.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa nhập họ tên\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHoTen.Focus();
                return;
            }
            if (!chkBannedYes.Checked && !chkBannedNo.Checked)
            {
                XtraMessageBox.Show("Bạn chưa chọn Banned\r\nVui lòng chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!chkAdminYes.Checked && !chkAdminNo.Checked)
            {
                XtraMessageBox.Show("Bạn chưa chọn chức vụ\r\nVui lòng chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            bool checkStateUser = false;
            if (chkBannedYes.Checked)
            {
                checkStateUser = true;
            }
            bool checkModUser = false;
            if (chkAdminYes.Checked)
            {
                checkModUser = true;
            }
            if (XtraMessageBox.Show("Bạn có chắc chắn muốn sửa nhân viên đang chọn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sqlU = "update users set fullname = N'" + txtHoTen.EditValue.ToString() + "', state = N'" + checkStateUser + "', mod = '" + checkModUser + "' where id_user = '" + txtMaNhanVien.EditValue.ToString() + "'";
                if (con.exeData(sqlU))
                {
                    loadData();
                    XtraMessageBox.Show("Sửa nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLamMoi.PerformClick();
                }
                else
                {
                    XtraMessageBox.Show("Sửa nhân viên thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if ((txtMaNhanVien.EditValue == null) || (txtMaNhanVien.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa chọn nhân viên\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHoTen.Focus();
                return;
            }
            if (XtraMessageBox.Show("Bạn có chắc chắn muốn xoá nhân viên đang chọn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sqlD = "delete from users where id_user = '" + txtMaNhanVien.EditValue.ToString() + "'";
                if (con.exeData(sqlD))
                {
                    loadData();
                    XtraMessageBox.Show("Xoá nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLamMoi.PerformClick();
                }
                else
                {
                    XtraMessageBox.Show("Xoá nhân viên thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaNhanVien.EditValue = null;
            txtTenTaiKhoan.EditValue = null;
            txtHoTen.EditValue = null;
            chkBannedYes.Checked = false;
            chkBannedNo.Checked = false;
            chkAdminYes.Checked = false;
            chkAdminNo.Checked = false;
            txtTenTaiKhoan.Enabled = true;
            txtTenTaiKhoan.BackColor = txtHoTen.BackColor;
            pcBanned.Enabled = false;
        }

        private void gcNhanVien_MouseCaptureChanged(object sender, EventArgs e)
        {
            int row_index = gvNhanVien.FocusedRowHandle;
            string colID = "id_user";
            string colUsername = "username";
            string colFullname = "fullname";
            string colState = "state";
            string colMod = "mod";            
            if ((gvNhanVien.GetRowCellValue(row_index, colID) != null) && (gvNhanVien.GetRowCellValue(row_index, colUsername) != null) && (gvNhanVien.GetRowCellValue(row_index, colFullname) != null) && (gvNhanVien.GetRowCellValue(row_index, colState) != null) && (gvNhanVien.GetRowCellValue(row_index, colMod) != null))
            {
                txtMaNhanVien.EditValue = gvNhanVien.GetRowCellValue(row_index, colID).ToString();
                txtTenTaiKhoan.EditValue = gvNhanVien.GetRowCellValue(row_index, colUsername).ToString();
                txtHoTen.EditValue = gvNhanVien.GetRowCellValue(row_index, colFullname).ToString();
                if(Convert.ToBoolean(gvNhanVien.GetRowCellValue(row_index, colState)))
                {
                    chkBannedYes.Checked = true;
                }
                else
                {
                    chkBannedNo.Checked = true;
                }
                if (Convert.ToBoolean(gvNhanVien.GetRowCellValue(row_index, colMod)))
                {
                    chkAdminYes.Checked = true;
                }
                else
                {
                    chkAdminNo.Checked = true;
                }
                txtTenTaiKhoan.Enabled = false;
                txtTenTaiKhoan.BackColor = txtMaNhanVien.BackColor;
                pcBanned.Enabled = true;
            }
        }
    }
}