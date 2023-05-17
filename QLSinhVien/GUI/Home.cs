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
    public partial class Home : Form
    {
        sinhvien sv = new sinhvien();
        phieuHP phieu = new phieuHP();
        LoadTTSinhvienBLL tt = new LoadTTSinhvienBLL();
        getMahpBLL bl = new getMahpBLL();
        public Home(sinhvien sv1)
        {
            sv = sv1;
            InitializeComponent();
        }

        private void btnDX_Click(object sender, EventArgs e)
        {
            DangNhap sn = new DangNhap();
            sn.Show();
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            loadTTSV();
            loadMahp();
        }
        void loadTTSV() {
            DataTable dt = tt.thongTinSVBLL(sv);
            sv.masv = txtMa.Text = dt.Rows[0]["MASV"].ToString();
            sv.tensv=  txtTen.Text = dt.Rows[0]["TENSV"].ToString();
            txtNS.Text = dt.Rows[0]["NGAYSINH"].ToString();
            sv.diachi = txtDC.Text = dt.Rows[0]["DIACHI"].ToString();
            sv.sdt = txtSDT.Text = dt.Rows[0]["SDT"].ToString();
            sv.pass = dt.Rows[0]["PASS"].ToString();
            sv.ngaysinh = DateTime.Parse(dt.Rows[0]["NGAYSINH"].ToString());
        }

        void loadMahp()
        {
            string hp = bl.layMahpBLL(sv);
            if(hp == "0")
            {
                MessageBox.Show("Khong lay dc ma HP");
                return;
            }
            else
            {
                phieu.maHP = hp;
                phieu.maSV = sv.masv;
            }
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            DoiMatKhau dk = new DoiMatKhau(sv);
            dk.Show();
            this.Hide();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            CapNhatThongTinSV cn = new CapNhatThongTinSV(sv);
            cn.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DangkiHP dk = new DangkiHP(sv, phieu);
            dk.Show();
            this.Hide();
        }

        private void btnHD_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon(phieu,sv);
            hd.Show();
            this.Hide();
        }
    }
}
