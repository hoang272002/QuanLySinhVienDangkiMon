using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI
{
    public partial class HoaDon : Form
    {
        HoaDonThanhToan hd = new HoaDonThanhToan();
        phieuHP hp = new phieuHP();
        sinhvien sv = new sinhvien();
        LoadPhieuctBLL bl = new LoadPhieuctBLL();
        GetMaHoaDonBLL bll = new GetMaHoaDonBLL();
        public HoaDon(phieuHP hp1, sinhvien sv1)
        {
            hp = hp1;
            sv = sv1;
            InitializeComponent();
            
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {

            hd.maHP = hp.maHP;
            hd.maHD = bll.layMaHDBLL(hp);
            DataTable dt = bl.loadCTPhieu(hp);
            dataGridView1.DataSource = dt;
            int a = 0;
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                a += int.Parse( dt.Rows[i]["GIATIEN"].ToString());
            }

            hd.tongtien = a;

            txtTongTien.Text = a.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home h = new Home(sv);
            h.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThanhToan tt = new ThanhToan(hd,sv);
            tt.Show();
            this.Hide();
        }
    }
}
