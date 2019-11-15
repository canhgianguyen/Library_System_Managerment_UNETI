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
using System.Security.Cryptography;

namespace QuanLyThuVien
{
    public partial class frmDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        Con_CRUD con = new Con_CRUD();
        string id = frmLogin.id_user;
        string password = frmLogin.password_user;         
        
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }
        private StringBuilder encrypt(String str)
        {
            StringBuilder sb = new StringBuilder();
            MD5 md5 = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.UTF8.GetBytes(str);
            byte[] hash = md5.ComputeHash(inputBytes);
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x"));
            }
            return sb;
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {           
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if ((txtOldPass.EditValue == null) || (txtOldPass.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa nhập mật khẩu cũ\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtOldPass.Focus();         
                return;
            }
            if ((txtNewPass.EditValue == null) || (txtNewPass.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa nhập mật khẩu mới\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNewPass.Focus();
                return;
            }
            if ((txtReNewPass.EditValue == null) || (txtReNewPass.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa nhập lại mật khẩu mới\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtReNewPass.Focus();
                return;
            }
            if (!txtNewPass.EditValue.ToString().Equals(txtReNewPass.EditValue.ToString()))
            {
                XtraMessageBox.Show("Hai mật khẩu mới không trùng nhau\r\nVui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtReNewPass.Focus();
                return;
            }
            if (!encrypt(txtOldPass.EditValue.ToString()).ToString().Equals(password))
            {
                XtraMessageBox.Show("Mật khẩu cũ không đúng\r\nVui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtOldPass.Focus();
                return;
            }
            string sqlU = "update users set password = '" + encrypt(txtNewPass.EditValue.ToString()).ToString() + "' where id_user = '" + id + "'";
            if (con.exeData(sqlU))
            {                
                XtraMessageBox.Show("Đổi mật khẩu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLamMoi.PerformClick();
            }
            else
            {
                XtraMessageBox.Show("Đổi mật khẩu thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtOldPass.EditValue = null;
            txtNewPass.EditValue = null;
            txtReNewPass.EditValue = null;
            txtOldPass.Focus();
        }

        private void buttonEdit1_Properties_Click(object sender, EventArgs e)
        {            
        }

        private void txtOldPass_Properties_Click(object sender, EventArgs e)
        {            
        }

        private void txtNewPass_Properties_Click(object sender, EventArgs e)
        {            
        }

        private void txtReNewPass_Properties_Click(object sender, EventArgs e)
        {            
        }

        private void txtNewPass_MouseCaptureChanged(object sender, EventArgs e)
        {            
        }

        private void txtNewPass_Click(object sender, EventArgs e)
        {            
        }

        private void txtReNewPass_Click(object sender, EventArgs e)
        {            
        }

        private void txtOldPass_Click(object sender, EventArgs e)
        {            
        }

        private void txtOldPass_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (txtOldPass.Properties.UseSystemPasswordChar)
            {
                txtOldPass.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                txtOldPass.Properties.UseSystemPasswordChar = true;
            }
        }

        private void txtNewPass_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (txtNewPass.Properties.UseSystemPasswordChar)
            {
                txtNewPass.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                txtNewPass.Properties.UseSystemPasswordChar = true;
            }
        }

        private void txtReNewPass_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (txtReNewPass.Properties.UseSystemPasswordChar)
            {
                txtReNewPass.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                txtReNewPass.Properties.UseSystemPasswordChar = true;
            }
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void groupControl3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}