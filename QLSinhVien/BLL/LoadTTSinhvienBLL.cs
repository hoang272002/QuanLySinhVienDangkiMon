using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class LoadTTSinhvienBLL
    {
        LoadTTSinhvienDAL dl = new LoadTTSinhvienDAL();
        public DataTable thongTinSVBLL (sinhvien sv)
        {
            DataTable dt = dl.thongTinSVDAL (sv);
            return dt;
        }
    }
}
