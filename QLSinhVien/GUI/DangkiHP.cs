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
    public partial class DangkiHP : Form
    {

        sinhvien sv = new sinhvien();
        phieuHP hp = new phieuHP();
        LoadTTMHBLL bl = new LoadTTMHBLL();
        LoadPhieuctBLL ct = new LoadPhieuctBLL();
        LuuPhieuCTBLL luu = new LuuPhieuCTBLL();
        public DangkiHP(sinhvien sv1, phieuHP hp1)
        {
            sv = sv1;
            hp = hp1;
            InitializeComponent();
        }

        private void DangkiHP_Load(object sender, EventArgs e)
        {
            DataTable dt = bl.layTTMHBLL();
            dataGridView1.DataSource = dt;

            DataTable dt1 = ct.loadCTPhieu(hp);
            dataGridView2.DataSource = dt1;
        }


        public void btnThem_Click(object sender, EventArgs e)
        {
            var dtable = dataGridView2.DataSource as DataTable;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                
                if (Convert.ToBoolean(row.Cells["choose"].Value) == true ) // Assuming checkbox column is at index 0
                {
                    string maMonHoc = row.Cells["MAMH"].Value?.ToString();

                    bool isDuplicate = false;

                    if (dataGridView2.Rows.Count == 0)
                    {

                        if (dtable != null)
                        {
                            DataRow newrow = dtable.NewRow();
                            newrow["MAMH"] = row.Cells["MAMH"].Value?.ToString();
                            newrow["TENMH"] = row.Cells["TENMH"].Value?.ToString();
                            newrow["SOTC"] = int.Parse(row.Cells["SOTC"].Value?.ToString());
                            newrow["GIATIEN"] = int.Parse(row.Cells["GIATIEN"].Value?.ToString());
                            dtable.Rows.Add(newrow);
                        }

                    }

                    foreach (DataGridViewRow row2 in dataGridView2.Rows)
                    {
                        string maMonHoc2 = row2.Cells["MAMH"].Value?.ToString();
                        if (maMonHoc == maMonHoc2)
                        {
                            isDuplicate = true;
                            break;
                        }
                    }

                    if (isDuplicate) { }
                    else
                    {
                        DataRow newrow = dtable.NewRow();
                        newrow["MAMH"] = row.Cells["MAMH"].Value?.ToString();
                        newrow["TENMH"] = row.Cells["TENMH"].Value?.ToString();
                        newrow["SOTC"] = int.Parse(row.Cells["SOTC"].Value?.ToString());
                        newrow["GIATIEN"] = int.Parse(row.Cells["GIATIEN"].Value?.ToString());
                        dtable.Rows.Add(newrow);
                    }
                }
            }
            dataGridView2.DataSource = dtable;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (Convert.ToBoolean(row.Cells["choice"].Value) == true)
                {
                    dataGridView2.Rows.Remove(row);
                }
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {

            DataTable dtable = new DataTable();
            dtable.Columns.Add("MAMH");
            dtable.Columns.Add("TENMH");
            dtable.Columns.Add("SOTC");
            dtable.Columns.Add("GIATIEN");

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (!row.IsNewRow) // Bỏ qua dòng mới của DataGridView nếu có
                {
                    DataRow newRow = dtable.Rows.Add();
                    for (int i = 1; i < row.Cells.Count; i++) // Bỏ qua cột đầu tiên (i = 0) và bắt đầu từ cột thứ hai (i = 1)
                    {
                        DataGridViewCell cell = row.Cells[i];
                        newRow[i - 1] = cell.Value;
                    }
                }
            }
            int a = dtable.Rows.Count;
            string h = luu.luuPhieuctBLL(hp, dtable);
            if (h == "1")
            {
                MessageBox.Show("Xac nhan thanh cong!");
            }
           
            else if (h == "0")
            {
                MessageBox.Show("Xac nhan khong thanh cong!");

            }

            Home home = new Home(sv);
            home.Show();
            this.Close();

        }
    }
}
