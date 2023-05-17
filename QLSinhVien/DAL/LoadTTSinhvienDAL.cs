using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoadTTSinhvienDAL:database
    {
        public DataTable thongTinSVDAL(sinhvien sv)
        {
            DataTable dt = LoadDBSinhVienDTO(sv);
            return dt;
        }
    }
}
