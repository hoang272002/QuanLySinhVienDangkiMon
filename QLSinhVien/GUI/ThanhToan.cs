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
    public partial class ThanhToan : Form
    {
        sinhvien sv = new sinhvien();
        HoaDonThanhToan hd = new HoaDonThanhToan();
        UpdateHoaDonBLL bl = new UpdateHoaDonBLL();
        public ThanhToan(HoaDonThanhToan hd1,sinhvien sv1)
        {
            hd = hd1;
            sv = sv1;
            InitializeComponent();
        }

        private void ThanhToan_Load(object sender, EventArgs e)
        {
            txtMaHD.Text = hd.maHD.ToString();
            txtTong.Text = hd.tongtien.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hd.phThuc = cbxPTH.SelectedIndex.ToString();
            string h = bl.capNhatHDBLL(hd);
            if(h =="1")
            {
                MessageBox.Show("Ghi nhan thanh cong");
                Home a = new Home(sv);
                a.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Ghi nhan khong thanh cong!");
                return;
            }

        }
    }
}
