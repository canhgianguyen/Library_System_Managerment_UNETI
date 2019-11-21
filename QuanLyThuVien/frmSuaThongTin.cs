﻿using System;
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
    public partial class frmSuaThongTin : DevExpress.XtraEditors.XtraForm
    {
        Con_CRUD con = new Con_CRUD();
        string id = frmLogin.id_user;
        
        public frmSuaThongTin()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if ((txtHoTen.EditValue == null) || (txtHoTen.EditValue.ToString().Trim().Equals("")))
            {
                XtraMessageBox.Show("Họ tên là bắt buộc\r\nVui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHoTen.Focus();
                return;
            }
            
            if (txtSoDienThoai.EditValue.ToString().Trim().Length > 1)
            {
                try
                {
                    int sdt = Convert.ToInt32(txtSoDienThoai.EditValue.ToString());
                }
                catch (Exception)
                {
                    XtraMessageBox.Show("Số điện thoại không hợp lệ\r\nVui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSoDienThoai.EditValue = null;
                    txtSoDienThoai.Focus();
                    return;
                }
                if ((txtSoDienThoai.EditValue.ToString().Length < 10 || txtSoDienThoai.EditValue.ToString().Length > 11))
                {
                    XtraMessageBox.Show("Số điện thoại phải có độ dài 10 hoặc 11 số\r\nVui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSoDienThoai.EditValue = null;
                    txtSoDienThoai.Focus();
                    return;
                }
            }
            
            bool check;
            if(chkNam.Checked)
            {
                check = false;
            }
            else
            {
                check = true;
            }
            string sqlU = "update users set fullname = N'" + txtHoTen.EditValue.ToString().Trim() + "', dob = '" + Convert.ToDateTime(txtNgaySinh.EditValue.ToString()).ToString("yyyy-MM-dd") + "', sex = '" + check + "', number = '" + txtSoDienThoai.EditValue.ToString().Trim() + "', address = N'" + txtDiaChi.EditValue.ToString().Trim() + "' where id_user = '" + id + "'";
            if (con.exeData(sqlU))
            {
                XtraMessageBox.Show("Thay đổi thông tin thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Thay đổi thông tin thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtNgaySinh.EditValue = null;
            txtSoDienThoai.EditValue = null;
            txtDiaChi.EditValue = null;
            txtHoTen.Focus();
        }

        private void frmSuaThongTin_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            string sqlR = "select fullname, dob, sex, number, address from users where id_user = '" + id + "'";
            DataTable dt = new DataTable();
            dt = con.readData(sqlR);
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    txtHoTen.EditValue = dr["fullname"].ToString();
                    txtNgaySinh.EditValue = Convert.ToDateTime(dr["dob"].ToString()).ToString("dd/MM/yyyy");
                    if(Convert.ToBoolean(dr["sex"]))
                    {
                        chkNu.Checked = true;
                    }
                    else
                    {
                        chkNam.Checked = true;
                    }
                    txtSoDienThoai.EditValue = dr["number"].ToString();
                    txtDiaChi.EditValue = dr["address"].ToString();
                }
            }
        }
    }
}