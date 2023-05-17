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
    public partial class CapNhatThongTinSV : Form
    {
        sinhvien sv = new sinhvien();
        UpdateTTSVBLL up = new UpdateTTSVBLL();
        public CapNhatThongTinSV(sinhvien sv1)
        {
            sv = sv1;
            InitializeComponent();
        }

        private void CapNhatThongTinSV_Load(object sender, EventArgs e)
        {
            loadTT();

        }
        void loadTT() {
            txtTen.Text = sv.tensv;
            dateTimePicker1.Value = sv.ngaysinh;
            txtDC.Text = sv.diachi;
            txtSDT.Text = sv.sdt;
        }

        private void btnCN_Click(object sender, EventArgs e)
        {
            string kq = up.CapNhatTTBLL(sv,txtTen.Text,dateTimePicker1.Value,txtDC.Text,txtSDT.Text);
            if(kq == "1")
            {
                sv.tensv = txtTen.Text;
                sv.ngaysinh = dateTimePicker1.Value;
                sv.diachi = txtDC.Text;
                sv.sdt = txtSDT.Text;
                MessageBox.Show("Cập nhật thành công!");
                return;
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công!");
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home h = new Home(sv);
            h.Show();
            this.Close();
        }
    }
}
