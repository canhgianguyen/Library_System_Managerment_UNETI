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
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        Con_CRUD con = new Con_CRUD();     
        private const string ID_USER = "id_user";
        private const string PASSWORD = "password";
        private const string FULLNAME = "fullname";
        private const string STATE = "state";
        public static string id_user = "";
        public static string name_user = "";
        public static string password_user = "";
        public static int mod = 0;
        public frmLogin()
        {
            InitializeComponent();
        }

        private StringBuilder encrypt(String str)
        {
            StringBuilder sb = new StringBuilder();
            MD5 md5 = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.UTF8.GetBytes(str);
            byte[] hash = md5.ComputeHash(inputBytes);
            for(int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x"));
            }
            return sb;
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void chkHideShow_CheckedChanged(object sender, EventArgs e)
        {
            if(txtPassword.Properties.UseSystemPasswordChar)
            {
                txtPassword.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.Properties.UseSystemPasswordChar = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
           
        }

        private string getInfo(string info)
        {
            string id = "";
            try
            {
                string sqlR = "select * from users where username = '" + txtUsername.EditValue.ToString() + "' and password = '" + encrypt(txtPassword.EditValue.ToString()).ToString() + "'";
                DataTable dt = new DataTable();
                dt = con.readData(sqlR);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        id = dr[info].ToString();
                    }
                }
            }
            catch (Exception)
            {
                id = "";
            }                
            return id;
        }        

        private void btnLogin_Click(object sender, EventArgs e)
        {            
            if(txtUsername.EditValue == null)
            {
                XtraMessageBox.Show("Bạn chưa nhập tên đăng nhập \r\nVui lòng nhập!", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsername.Focus();
                return;
            }
            if (txtPassword.EditValue == null)
            {
                XtraMessageBox.Show("Bạn chưa nhập mật khẩu \r\nVui lòng nhập!", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.Focus();
                return;
            }
            if(getInfo(STATE).ToString().Equals("True"))
            {
                XtraMessageBox.Show("Tài khoản của bạn hiện đang bị cấm\r\nVui lòng liên hệ admin để biết thêm thông tin!", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsername.EditValue = null;
                txtPassword.EditValue = null;
                txtUsername.Focus();
                return;
            }
            try
            {
                id_user = getInfo(ID_USER);                                
                if (id_user != "")
                {
                    name_user = getInfo(FULLNAME);
                    password_user = getInfo(PASSWORD);
                    frmMain frm = new frmMain();
                    this.Hide();
                    frm.ShowDialog();
                    this.Dispose();                 
                }
                else
                {
                    XtraMessageBox.Show("Thông tin tài khoản hoặc mật khẩu không đúng \r\nVui lòng đăng nhập lại!", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsername.EditValue = null;
                    txtPassword.EditValue = null;
                    txtUsername.Focus();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi!" + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void txtPassword_Properties_Click(object sender, EventArgs e)
        {
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {            
        }

        private void txtPassword_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (txtPassword.Properties.UseSystemPasswordChar)
            {
                txtPassword.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.Properties.UseSystemPasswordChar = true;
            }
        }

        private void searchControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
        }        
    }
}