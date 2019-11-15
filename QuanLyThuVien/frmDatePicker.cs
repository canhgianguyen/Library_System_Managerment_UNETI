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
    public partial class frmDatePicker : DevExpress.XtraEditors.XtraForm
    {
        public static string date = "";
        public frmDatePicker()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if((txtDate.EditValue == null) || (txtDate.EditValue.ToString().Equals("")))
            {
                XtraMessageBox.Show("Bạn chưa chọn ngày hẹn trả sách\r\nVui lòng chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(Convert.ToDateTime(txtDate.EditValue.ToString()).CompareTo(DateTime.Now.Date) < 0)
            {
                XtraMessageBox.Show("Ngày hẹn trả sách không được nhỏ hơn ngày hiện tại\r\nVui lòng chọn lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            date = txtDate.EditValue.ToString();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void frmDatePicker_Load(object sender, EventArgs e)
        {

        }
    }
}