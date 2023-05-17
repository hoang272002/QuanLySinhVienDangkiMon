using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class UpdateTTSVDAL:database
    {
        public string capNhatTTSVDAL(sinhvien sv,string d,DateTime a,string b,string c)
        {
            string kq = CapNhatTTDTO(sv,d,a,b,c);
            return kq;
        }
    }
}
