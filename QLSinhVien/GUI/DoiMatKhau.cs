using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class DoiMatKhau : Form
    {
        sinhvien sv = new sinhvien();
        DoiMKBLL bl = new DoiMKBLL(); 
        public DoiMatKhau(sinhvien sv1)
        {
            sv = sv1;
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Home h = new Home(sv);
            h.Show();
            this.Hide();
        }

        private void btnDoi_Click(object sender, EventArgs e)
        {
            string kq = bl.DoiMatKhauBLL(sv, txtMKmoi.Text);
            if (txtMKcu.Text != sv.pass)
            {
                MessageBox.Show("Mật khẩu cũ không đúng!");
                return;
            }
            else if(kq == "0")
            {
                MessageBox.Show("Đổi mật khẩu thất bại!");
                return;
            }
            else if(kq == "1") 
            {
                sv.pass = txtMKmoi.Text;
                MessageBox.Show("Đổi mật khẩu thành công!");
                return;
            }
        }
    }
}
