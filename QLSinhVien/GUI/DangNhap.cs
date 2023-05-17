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
using DTO;

namespace GUI
{
    public partial class DangNhap : Form
    {
        sinhvien sv = new sinhvien();
        CheckLoginBLL login = new CheckLoginBLL();

        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            sv.masv = txtDN.Text;
            sv.pass = txtMK.Text;

            string kq = login.ktDangNhapBLL(sv);
            if(kq == "Ten tai khoan rong")
            {
                MessageBox.Show("Tên đăng nhập không được để trống!");
                return;
            }
            else if(kq == "mk rong")
            {
                MessageBox.Show("Mật khẩu không được để trống!");
                return;
            }
            else if (kq == "Đăng nhập thất bại!")
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
                return;
            }
            else
            {
                Home h = new Home(sv);
                h.Show();
                this.Hide();
            }
        }
    }
}
