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
    public partial class frmTimKiemSach : DevExpress.XtraEditors.XtraForm
    {
        Con_CRUD con = new Con_CRUD();
        string sqlR = "select provided.id_bookprovider, book.id_booktype, provided.id_book, book.bookname, book.author, book.publisher, book.publishingyear, book.pages, provided.date, provided.amount from provided join book on provided.id_book = book.id_book";

        public frmTimKiemSach()
        {
            InitializeComponent();
        }

        private void loadBook()
        {
            DataTable dt = con.readData(sqlR);
            if (dt != null)
            {
                gcSach.DataSource = dt;
            }
        }


        private void frmTimKiemSach_Load(object sender, EventArgs e)
        {
            loadBook();
        }
    }
}